using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek3
{
    class Program
    {
        public enum Gender
        {
            MALE,
            FEMALE
        }

        public static void DateOfBirthAndAge()
        {
            //Date of birth
            Console.WriteLine("Enter your day of birth: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your month of birth (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your year of birth: ");
            int year = int.Parse(Console.ReadLine());
            DateTime dateOfBirth = new DateTime(year, month, day);

            //Age
            double daysPerYear = 365.25;
            TimeSpan timeSpan = DateTime.Now - dateOfBirth;
            double ageInDays = timeSpan.TotalDays;
            double actualAge = ageInDays / daysPerYear;
        }

        static void Main(string[] args)
        {
            DateOfBirthAndAge();

            //Enter the gender
            Console.WriteLine("Enter gender (m/f): ");
            string genderLetter = Console.ReadLine().ToLower().Trim();
            Gender gender = Gender.MALE;
            switch (genderLetter)
            {
                case "m":
                    gender = Gender.MALE;
                    break;
                case "f":
                    gender = Gender.FEMALE;
                    break;
                default:
                    throw new Exception("Invalid value for gender");
            }

            //Age of retirement
            int ageOfRetirement = (gender == Gender.MALE) ? 65 : 63;
            Console.WriteLine(ageOfRetirement);

        }
    }
}
