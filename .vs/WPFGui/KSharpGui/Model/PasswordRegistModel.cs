using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSharpGui.Model
{
    class PasswordRegistModel
    {
        public Boolean SpecialChars { get; set; }
        public Boolean NumberChars { get; set; }
        public Boolean UpperCaseChars { get; set; }
        public Boolean LowerCaseChars { get; set; }
        public int PasswordLength { get; set; }
    }
}
