using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee type (1 for HR, 2 for Admin, 3 for Software Developer): ");
            int employeeType = int.Parse(Console.ReadLine());

            switch (employeeType)
            {
                case 1:
                    Console.WriteLine("Enter working hours and working days for HR (separated by space): ");
                    int[] hrInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    if (hrInput.Length >= 2)
                    {
                        Console.WriteLine($"Monthly Salary for HR: {CalculateSalary(hrInput[0], hrInput[1])}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for HR. Please provide both working hours and working days.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter working days and project handles for Admin (separated by space): ");
                    int[] adminInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    if (adminInput.Length >= 2)
                    {
                        Console.WriteLine($"Monthly Salary for Admin: {CalculateSalary(adminInput[0], adminInput[1])}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Admin. Please provide both working days and project handles.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter working hours, working days, project handles, and extras for Software Developer (separated by space): ");
                    int[] devInput = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    if (devInput.Length >= 4)
                    {
                        Console.WriteLine($"Monthly Salary for Software Developer: {CalculateSalary(devInput[0], devInput[1], devInput[2], devInput[3])}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Software Developer. Please provide all required values.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid employee type.");
                    break;
            }

            Console.ReadKey();
        }

        static double CalculateSalary(int wHours, int wDays, int projectHandles = 0, int extras = 0)
        {
            double baseSalary = wHours * wDays * 100;
            double projectBonus = projectHandles * 3000;
            double totalExtras = extras;

            return baseSalary + projectBonus + totalExtras;
        }
    }
}
