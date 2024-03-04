using PhoneBook.Model;
using PhoneBook.PhoneBookService.File_Broker;
using PhoneBook.PhoneBookService.LoggingBroker;
using PhoneBook.PhoneBookService.SystemService.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBookService.SystemService
{
    internal class AllSystemService
    {

        public void Menu()
        {
            Data data = new Data();
            UserInputData userInputData = new UserInputData(10);
            FileBroker fileBroker = new FileBroker();
            Menu2();
            void Menu2() 
            {


                Console.WriteLine(@"1.Royhatdan otish
2.Login.");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Registration();
                        Console.WriteLine(@"1.Malumotlarni ozgartirish
2.Malumotlarni hammasini ochirish
3.Malumotlarni hammasini korish ");
                        int choice2=Convert.ToInt32(Console.ReadLine());

                        switch (choice2)
                        {
                            case 1:
                                Console.Write("Malumotlarni ozgartirish uchun telefon raqam kiriting - ");
                                string phN= Console.ReadLine();
                                Console.Write("Ismingizni kiriting - ");
                                data.Name = Console.ReadLine();
                                try
                                {
                                    Console.Write("Telefon raqam - ");

                                  data.PhoneNum = Console.ReadLine();

                                    if (!(RegexPatterns.PhoneNumPattern(data.PhoneNum)))
                                    {
                                        //Console.WriteLine("Telefon raqam formati xato");
                                    }
                                    else
                                    {
                                        throw new IncorrectPhoneNumberExeption("Telefon raqam formati xato");
                                    }
                                }
                                catch (IncorrectPhoneNumberExeption exeption)
                                {
                                    Console.WriteLine($"Xatolik - {exeption}");
                                }
                                finally
                                {
                                   
                                }



                                Console.Write("Malumotlaringizni kiriting");
                                data.InfoUser = Console.ReadLine();

                                userInputData.UpdateData(phN,data);


                                break;

                                

                        }


                        break;
                        case 2:
                        Login();
                        break;
                }
                 void Registration()
                 {
                    Console.Write("Ismingizni kiriting - ");
                     data.Name = Console.ReadLine();
                    Console.Write("Telefon raqam - ");
                    data.PhoneNum  = Console.ReadLine();
                    Console.Write("Malumotlaringizni kiriting");
                    data.InfoUser = Console.ReadLine();
                    userInputData.Registration(data);

                    
                 }
                void Login()
                {
                   
                }

            }

           

        }

        
    }
}
