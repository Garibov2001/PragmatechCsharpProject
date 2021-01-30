using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Validations
{
    
    public static class RegisterFormValidation
    {
        //Extension method for string
        public static bool IsValidName(this string argName, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argName))
            {
                feedback.Append("Ad xanası boş ola bilməz\n");
                return false;
            }
            else if(argName.Any(elem => !char.IsLetter(elem)))
            {
                feedback.Append("Ad xanası yalnız hərflərdən təşkil oluna bilər\n");
                return false;
            }

            return true;
        }

        public static bool IsValidSurname(this string argSurname, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argSurname))
            {
                feedback.Append("Soyad xanası boş ola bilməz\n");
                return false;
            }
            else if (argSurname.Any(elem => !char.IsLetter(elem)))
            {
                feedback.Append("Soyad xanası yalnız hərflərdən təşkil oluna bilər ola bilməz\n");
                return false;
            }

            return true;
        }

        public static bool IsValidEmail(this string argEmail, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argEmail))
            {
                feedback.Append("Email xanası boş ola bilməz\n");
                return false;
            }

            //intentionally not validated strongly:  
            else if (!argEmail.Any(elem => elem == '@'))
            {
                feedback.Append("Email standartlara uygun gelmir\n");
                return false;
            }

            return true;
        }

        public static bool IsValidPhoneNumber(this string argPhoneNumber, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argPhoneNumber))
            {
                feedback.Append("Telefon xanası boş ola bilməz\n");
                return false;
            }

            //intentionally not validated strongly:  
            else if (!argPhoneNumber.Any(elem => char.IsDigit(elem)))
            {
                feedback.Append("Telefon nömrəsi yalnız rəqəmlərdən təşkil oluna bilər, (p.s 0503144847)\n");
                return false;
            }

            return true;
        }

        public static bool IsValidPassword(this string argPassword, string confirmPassword, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argPassword))
            {
                feedback.Append("Sifre xanası boş ola bilməz\n");
                return false;
            }


            else if (!(argPassword == confirmPassword))
            {
                feedback.Append("Daxil etdiyiniz sifreler uyusmur\n");
                return false;
            }

            return true;
        }
    }
}
