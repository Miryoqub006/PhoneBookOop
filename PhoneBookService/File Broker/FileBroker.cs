using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Model;
using PhoneBook.Model;

namespace PhoneBook.PhoneBookService.File_Broker;

internal class FileBroker : IFileBroker
{
    private string _filePath = @"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt";

    

    public void DeleteAllData()
    {
        using (File.Open(@"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt", FileMode.Open))
        {
            File.WriteAllText(@"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt", null);
        }
    }

    public void DeleteById(string phone)
    {
        
    }

    public void GetAllData()
    {
        using (File.Open(_filePath, FileMode.Open))
        {
            Console.Write(File.ReadAllLines(_filePath));
        }



    }

    public void GetDataById(string phone)
    {
        
    }
    

    
}
