using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class DisplayConstant
    {
        public const string INPUT_ADDRESS_INFO = "====================== Person Info =====================";

        #region input address book
        public const string INPUT_NAME = "Please input name: ";
        public const string INPUT_DATEOFBIRTH = "Please input Date of birth: ";
        public const string INPUT_EMAIL = "Please input email: ";
        public const string INPUT_PHONE = "Please input phone: ";
        #endregion

        #region Output address book
        public const string OUTPUT_NAME = "Name: {0}";
        public const string OUTPUT_DATEOFBIRTH = "Date of Birth: {0}";
        public const string OUTPUT_EMAIL = "Email: {0}";
        public const string OUPUT_PHONE = "Phone: {0}";
        #endregion

        #region direction
        public const string MENU_START = "Please choice function";
        public const string MENU_CREATE = "1. Create address book";
        public const string MENU_DISPLAY = "2. Display address book";
        public const string MENU_EXIT = "3. Exit system";
        public const string MENU_FUNCTION = "This function don't support in the system";
        #endregion

        public const string END_OF_PAGE_MESSAGE = "====================== End Of page message ===================";
    }
}
