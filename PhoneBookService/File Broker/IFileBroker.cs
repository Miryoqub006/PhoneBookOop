using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBookService.File_Broker;

internal interface IFileBroker
{
    

    public void GetAllData();

    public void DeleteAllData();

    public void DeleteById(string phone) ;

    public void GetDataById(string phone   );




}
