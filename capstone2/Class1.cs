using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Week2CapstoneTaskList
{
    class Task
    {
        public List<string> members;
        public string date;
        public bool status;
        public string description;


        public Task()
        {
            //instantiating member 
            members = new List<string>();
            status = false;
        }
        public static string GetName(string input)
        {
            bool regexNameValidator;
            regexNameValidator = Regex.IsMatch(input, @"^[a-zA-Z]+$");
            try
                {
                   if(!regexNameValidator)
                {
                    throw new Exception("Plesae enter valid Name");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return input;

        }
        public static string CheckNumber()
        {
          
            string input = Console.ReadLine();
            
            if(Regex.IsMatch(input, @"^([1-9]{1,5})$"))
                {
                return input;
                }
            else
            {
                Console.WriteLine("Plesae enter a number between 1 and 5");
                return CheckNumber();
            }
        }
        public static DateTime GetDate()
        {
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out DateTime checkdate))
            {
                return checkdate;
            }
            else
            {
                Console.WriteLine("Plesae enter valiod date");
                return GetDate();
            }
        }
    }
}

        