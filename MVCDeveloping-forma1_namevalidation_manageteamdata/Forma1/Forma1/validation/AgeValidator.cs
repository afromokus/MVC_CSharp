using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    /// <summary>
    /// Az életkor minAge és maxAge közé kell essen
    /// Készítsem el a validation metódust amely ellenőrzi a feltételt
    /// AgeIsLessThanMinAge - kivétel készítése
    /// greater than max - szintén
    /// </summary>

    public class AgeValidator
    {
        int age;

        const int minAge = 18;
        const int maxAge = 60;

        public AgeValidator(int age)
        {
            this.age = age;
        }
    }
}
