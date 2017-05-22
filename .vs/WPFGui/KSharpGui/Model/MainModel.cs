using KSharpGui.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSharpGui.Model
{
    class MainModel: ModelBase
    {
        public MainModel()
        {
            buttonText = "asdfasdf";
            //NotifyOfPropertyChange(() => buttonText);

        }
        private string _buttonText;
        public string buttonText{ get { return _buttonText; } set
            {
                _buttonText = value;
                OnPropertyChanged();
            } }

    }
}
