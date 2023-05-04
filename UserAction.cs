using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Console;

namespace SortedList
{
    public class UserAction
    {
        public Person person = null;
        public SortedList<string, Person> addressBook = new SortedList<string, Person>();
        public static UserAction useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if(useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }
        public enum Options
        {
            Create = 1,
            Display = 2,
            Exit = 3
        }
        
        public void Print(SortedList<string, Person> list)
        {
            WriteLine($"People in the list: {list.Count}");
            foreach(KeyValuePair<string, Person> item in addressBook)
            {
                WriteLine($"- {item.Key} - {item.Value.Name} - {item.Value.DateOfBirth} - {item.Value.Email} - {item.Value.Phone}");
            }
        }

        public void Perform()
        {
            Options option;
            do
            {
                WriteLine(DisplayConstant.INPUT_ADDRESS_INFO);
                WriteLine(DisplayConstant.MENU_START);
                WriteLine();
                WriteLine(DisplayConstant.MENU_CREATE);
                WriteLine();
                WriteLine(DisplayConstant.MENU_DISPLAY);
                WriteLine();
                WriteLine(DisplayConstant.MENU_EXIT);
                WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);
                Enum.TryParse(ReadLine(), out option);

                switch (option)
                {
                    case Options.Create:
                        {
                            try
                            {
                                person = person ?? new Person();
                                person.InputAddressBook();
                                addressBook.Add(person.Name, person);
                            }
                            catch(Exception ex)
                            {
                                WriteLine(ex);
                            }
                            break;
                        }
                    case Options.Display:
                        {
                            Print(addressBook);
                            break;
                        }
                    case Options.Exit:
                        {
                            break;
                        }
                    default:
                        {
                            WriteLine(DisplayConstant.MENU_FUNCTION);
                            break;
                        }
                }
            }
            while (option != Options.Exit);
        }
    }
}
