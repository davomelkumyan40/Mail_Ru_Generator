using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRuCreator
{
    class UserData
    {
        //ctor1
        public UserData()
        {
            randomIndex = 0;
            this.Name = string.Empty;
            this.SurName = string.Empty;
            this.Password = string.Empty;
            this.MailAddress = string.Empty;
            this.Date = new DateTime();
            this.YearIndex = 0;
            this.Sex = false;
            MailPrefixIndex = r.Next(162, 166);
        }
        //ctor2
        public UserData(string UserName, string UserSurName)
        {
            randomIndex = r.Next(4, 6);
            this.Name = UserName;
            this.SurName = UserSurName;
            this.Password = GeneratePassword(randomIndex);
            this.MailAddress = $"{UserName}.{UserSurName}{Date}";
            this.Date = new DateTime(r.Next(1970, 1999), r.Next(1, 13), r.Next(1, 28));
            this.YearIndex = r.Next(43, 162);
            this.Sex = Convert.ToBoolean(r.Next(0, 2));
            MailPrefixIndex = r.Next(162, 166);
        }
        //ctor3
        public UserData(string UserName, string UserSurName, DateTime UserAge, string UserPassword)
        {
            Random r = new Random();
            randomIndex = r.Next(2, 6);
            this.Name = UserName;
            this.SurName = UserSurName;
            this.Password = UserPassword;
            this.MailAddress = $"{UserName}.{UserSurName}{UserAge}";
            this.Date = UserAge;
            this.YearIndex = r.Next(43, 162);
            this.Sex = Convert.ToBoolean(r.Next(0, 2));
            MailPrefixIndex = r.Next(162, 166);
        }

        private Random r = new Random();
        private char[] symbols0 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] symbols1 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        private string[] emails = { "mail.ru", "inbox.ru", "list.ru", "bk.ru" };
        public int MailPrefixIndex { get; set; }

        private int randomIndex;
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Date { get; set; }
        public int YearIndex { get; set; }
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public bool Sex { get; set; }
        public string FullMailAddress => MailAddress + "@" + GetMailPrefix(162);
        public string GetMailPrefix (int startIndex) => emails[MailPrefixIndex - startIndex];


        public UserData GenerateUser()
        {
            //Age
            this.Sex = Convert.ToBoolean(r.Next(0, 2));
            this.YearIndex = r.Next(43, 162);
            Date = this.Date = new DateTime(r.Next(1901, 2020), r.Next(1, 13), r.Next(1, 28));
            randomIndex = r.Next(4, 6);
            Password = GeneratePassword(randomIndex);
            //Name
            for (int i = 0; i < randomIndex; i++)
            {
                Name += $"{symbols0[r.Next(0, symbols0.Length)]}";
                // Name += $"{symbols1[r.Next(0, symbols1.Length)]}";
            };
            //randomIndex = r.Next(4, 8);
            //SurName
            for (int i = 0; i < randomIndex; i++)
            {
                SurName += $"{symbols0[r.Next(0, symbols0.Length)]}";
                //SurName += $"{symbols1[r.Next(0, symbols1.Length)]}";
            };
            MailAddress = $"{Name}.{SurName}{Date.Day}";

            return this;
        }

        public string GetMonth(int monthIndex)
        {
            return months[monthIndex - 1];
        }


        public string GetMonthString(int monthNum) => months[monthNum - 1];

        public string GeneratePassword(int length)
        {
            string userPassword = string.Empty;
            for (int i = 0; i < length; i++)
            {
                userPassword += $"{symbols0[r.Next(0, symbols0.Length)]}";
                userPassword += $"{symbols1[r.Next(0, symbols1.Length)]}";
                userPassword += $"{r.Next(0, 99)}";
            };
            return userPassword;
        }

        public void ClearUser()
        {
            randomIndex = 0;
            this.Name = string.Empty;
            this.SurName = string.Empty;
            this.Password = string.Empty;
            this.MailAddress = string.Empty;
            this.MailPrefixIndex = 0;
            this.Date = DateTime.MinValue;
        }
    }
}
