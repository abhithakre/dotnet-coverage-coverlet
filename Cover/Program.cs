using System;

namespace Cover
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World test1 23!");
        }

        public static int Sum(int a, int b)  // <--- Important! Add the public keyword here
        {
            return a + b;
        }
        public class Employee
        {
            public int empId { get; set; }
            public string empName { get; set; }

        }

        public bool BookTime(Employee employee, DateTime date, decimal duration)
        {
            if (employee.empId <= 0)
            {
                throw new ArgumentOutOfRangeException("Employee id cannot be 0");
            }

            if (date.Date < DateTime.Today || date.Date > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException("You can book for today only.");
            }

            if (duration > 9)
            {
                throw new ArgumentOutOfRangeException("You can book for 9hrs only");
            }


            return true;

            //return _bookingProcessor.Create(employee.empId,date,duration);
        }

      
    }
}
