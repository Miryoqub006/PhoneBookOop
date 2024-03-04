using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model;

internal class Data
{
    public string Name  { get; set; }

    public string PhoneNum { get; set; }

    public string InfoUser { get; set; }

    public override string ToString()
    {
        return "Data" + Name + PhoneNum + InfoUser;
    }


}
