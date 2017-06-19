using System;
using KSharpGui.MVC;


namespace KSharpGui.Model
{
    public class PasswordRegistModel: ModelBase
    {
        public Boolean SpecialChars { get; set; }
        public Boolean NumberChars { get; set; }
        public Boolean UpperCaseChars { get; set; }
        public Boolean LowerCaseChars { get; set; }
        public int PasswordLength { get; set; }
    }
}
