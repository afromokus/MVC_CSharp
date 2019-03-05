using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class NameValidator
    {
        private string name;
        public NameValidator(string name)
        {
            this.name = name;
        }
        public void validation()
        {
            if (isEmtyName())
                throw new NameNotValidNameIsEmptyException("A név nem lehet üres!");
            if (isFistLetterNotUppercase())
                throw new NameNotValidFirstLetterProblemException("A név nagy kezdőbetűvel kell kezdőjön!");
            if (isNextToFirstLetterIsNotLower())
                throw new NextToFirstLetterIsNotLowerException("Az első karakter után kisbetűket kell írni");
        }

        private bool isNextToFirstLetterIsNotLower()
        {
            for(int i=1;i<name.Length;i++)
            {
                if (!char.IsLetter(name.ElementAt(i)) ||
                    char.IsUpper(name.ElementAt(i)))
                    return true;
            }
            return false;
        }

        private bool isFistLetterNotUppercase()
        {
            if (char.IsUpper(name.ElementAt(0)))
                return false;
            else
                return true;
        }

        private bool isEmtyName()
        {
            if (string.IsNullOrEmpty(name))
                return true;
            else
                return false;
        }
    }
}
