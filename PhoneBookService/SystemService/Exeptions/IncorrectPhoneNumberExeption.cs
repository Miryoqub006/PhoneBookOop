using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBookService.SystemService.Exeptions
{
    internal class IncorrectPhoneNumberExeption : Exception
    {
        public IncorrectPhoneNumberExeption() { }

        public IncorrectPhoneNumberExeption(string message) : base(message) { }

    }
}
