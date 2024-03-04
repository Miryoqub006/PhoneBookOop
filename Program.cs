using PhoneBook.PhoneBookService.SystemService;

namespace PhoneBook;

internal class Program
{
    static void Main(string[] args)
    {
        AllSystemService allSystemService = new AllSystemService();
        allSystemService.Menu();


    }

   
}
