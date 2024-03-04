using PhoneBook.Model;
using PhoneBook.PhoneBookService;
using PhoneBook.PhoneBookService.File_Broker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBookService.LoggingBroker
{
    internal class UserInputData : IUserInputData 
    {

        public Data[] UserInfo;

        
        public UserInputData(int arrayNum)
        {
            UserInfo = new Data[arrayNum];
        }
        
        public void DeleteData(string phoneNumber,Data data)
        {
           for(int i = 0; i < UserInfo.Length; i++)
            {
                if(data.PhoneNum == UserInfo[i].PhoneNum)
                {
                    UserInfo[i] = null;
                    using (File.Open(@"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt", FileMode.Open))
                    {
                        File.WriteAllText(@"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt", null);
                    }
                }
            }
        }

        public void Login(string phoneNum,Data data)
        {
            if(data.PhoneNum == phoneNum)
            {

            }
        }

        

        public void Registration(Data user)
        {
            string[] warp = new string[UserInfo.Length]; 
             for(int i = 0; i < UserInfo.Length; i++)
             {
                if (UserInfo[i] is null && warp[i] is null)
                {
                    
                    UserInfo[i] = user;
                    warp[i] = UserInfo[i].ToString();
                    using
                    (
                     File.Open(@"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt", FileMode.Open)
                    )
                    {
                        File.WriteAllLines(@"C:\Users\Asus\Desktop\c#\PhoneBook\FIle.txt", warp);
                    }

                    break;
                }

               } 
                   


               
            
        }

        public void UpdateData(string phoneNumber, Data data)
        {
            if (data.PhoneNum == phoneNumber)
            {
                for(int i = 0;i < UserInfo.Length;i++)
                {
                    if (UserInfo[i] is null)
                    {
                        UserInfo[i] = data;
                    }
                }

                
            }
        }


    }
}
