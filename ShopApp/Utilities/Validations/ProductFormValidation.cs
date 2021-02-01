using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Validations
{
    public static class ProductFormValidation
    {
        public static bool IsValidName(string argName, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argName))
            {
                feedback.Append("Productun ad xanası boş ola bilməz\n");
                return false;
            }
            else if (argName.Any(elem => !char.IsLetter(elem)))
            {
                feedback.Append("Productun adi yalnız hərflərdən təşkil oluna bilər\n");
                return false;
            }

            return true;
        }
        public static bool IsValidPrice(string argPrice, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argPrice))
            {
                feedback.Append("Dəyər xanası boş ola bilməz\n");
                return false;
            }
            else if (argPrice.Any(elem => !char.IsDigit(elem)))
            {
                feedback.Append("Productun Dəyəri yalnız ədədlərdən təşkil oluna bilər\n");
                return false;
            }

            return true;
        }
        public static bool IsValidCount(string argCount, StringBuilder feedback)
        {
            if (string.IsNullOrEmpty(argCount))
            {
                feedback.Append("Sayı xanası boş ola bilməz\n");
                return false;
            }
            else if (argCount.Any(elem => !char.IsDigit(elem)))
            {
                feedback.Append("Productun sayı yalnız ədədlərdən təşkil oluna bilər\n");
                return false;
            }

            return true;
        }
        public static bool IsValidCategory(object argObj, StringBuilder feedback)
        {
            if (argObj == null)
            {
                feedback.Append("Məhsulun kategoriyası seçilməlidir\n");
                return false;
            }

            return true;
        }
    }
}