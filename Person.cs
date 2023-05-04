using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortedList
{
    public class Person
    {
        private string _name;
        private DateTime _dateOfBirth;
        private string _email;
        private int _phone;
        
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }  
        public string Email { get { return _email; } set { _email = value; } }
        public int Phone { get { return _phone; } set { if (_phone >= 0) { _phone = value; } } }

        public Person()
        {
        }
        public Person(string name, DateTime dateOfBirth, string email, int phone)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
            _email = email;
            _phone = phone;
        }

        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }
        public void InputAddressBook()
        {
            _name = InputInfo(DisplayConstant.INPUT_NAME);
            _dateOfBirth = Convert.ToDateTime(InputInfo(DisplayConstant.INPUT_DATEOFBIRTH));
            _email = InputInfo(DisplayConstant.INPUT_EMAIL);
            _phone = Convert.ToInt32(InputInfo(DisplayConstant.INPUT_PHONE));
            ReadLine();
        }

        public void DisplayAddressBook()
        {
            WriteLine(DisplayConstant.OUTPUT_NAME, _name);
            WriteLine(DisplayConstant.OUTPUT_DATEOFBIRTH, _dateOfBirth);
            WriteLine(DisplayConstant.OUTPUT_EMAIL, _email);
            WriteLine(DisplayConstant.OUPUT_PHONE, _phone);
        }
    }
}
