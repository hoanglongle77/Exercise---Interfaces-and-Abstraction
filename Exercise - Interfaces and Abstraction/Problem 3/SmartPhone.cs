using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Interfaces_and_Abstraction.Problem_3
{
    internal class SmartPhone : ISmartphone
    {
        public SmartPhone()
        {
        }

        public SmartPhone(string model)
        {
            Model=model;
        }

        public string Model { get; private set; }


        public string Browse(string url)
        {
            if (this.IsUrlValid(url))
            {
                return $"Browsing: {url}!";
            }

            return "Invalid URL!";
        }

        private bool IsUrlValid(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public string Call(string phoneNumber)
        {
            if (this.IsNumberValid(phoneNumber)&&phoneNumber.Length == 10)
            {
                return $"Calling... {phoneNumber}";
            }else if (this.IsNumberValid(phoneNumber) && phoneNumber.Length == 7)
            {
                return $"Dialing... {phoneNumber}";
            }

            return "Invalid number!";
        }

        private bool IsNumberValid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
