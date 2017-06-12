using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KSharpGui.MVC
{
	public class ModelBase : INotifyPropertyChanged
	{
		public virtual void OnNavigateTo(object parameter)
		{
		}

		public virtual void RecieveMessage<T>(T message)
		{
		}

		protected void NotifyOfPropertyChange<TProperty>(Expression<Func<TProperty>> property)
		{
			var propertyName = ExtractPropertyName(property);

			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
		{
			if (propertyExpression == null)
			{
				throw new ArgumentNullException("propertyExpression");
			}

			var memberExpression = propertyExpression.Body as MemberExpression;
			if (memberExpression == null)
			{
				throw new ArgumentException("not a member expression", "propertyExpression");
			}

			var property = memberExpression.Member as PropertyInfo;
			if (property == null)
			{
				throw new ArgumentException("not a property", "propertyExpression");
			}

			var getMethod = property.GetGetMethod(true);
			if (getMethod.IsStatic)
			{
				throw new ArgumentException("can't be static", "propertyExpression");
			}

			return memberExpression.Member.Name;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		
		// IDataErrorInfo

		
		public string Error { get; set; }
	}
}