using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBookService.LoggingBroker
{
    internal interface IUserInputData
    {
        public void Registration(Data data);

        public void Login(string phoneNumber,Data data);

        

        public void UpdateData(string phoneNumber,Data data);

        public void DeleteData(string phoneNumber,Data data);

        


    }
}
