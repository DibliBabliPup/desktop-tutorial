using System;

namespace ConsoleApp5
{
    public class Program
    {
        public class Worker
        {
            public string Name;
            public string Surname;
            public int Rate;
            public int Days;
            
            public static int GetSalary(int Rate, int Days)
            {
                return Rate * Days;
            }

            public static string Fullname(string Name, string Surname)
            {
                return Name + " " + Surname;
            }
        }

        static void Main(string[] args)
        {
            Worker First = new Worker();
            First.Name = "Lena";
            First.Surname = "Golovach";
            First.Rate = 2000;
            First.Days = 31;
            Console.WriteLine(Worker.Fullname(First.Name, First.Surname));
            Console.Write(Worker.GetSalary(First.Rate, First.Days));
        }
    }
}


using System;

namespace ConsoleApp5
{
    public class Program
    {
        public class Worker
        {
            private string Name;
            private string Surname;
            private int Rate;
            private int Days;

            public string PublickName
            {
                get { return Name; }
            }
            
            public string PublickSurname
            {
                get { return Surname; }
            }
            
            public int PublickRate
            {
                get { return Rate; }
            }
            
            public int PublickDays
            {
                get { return Days; }
            }

            public Worker(string Name, string Surname, int Rate, int Days)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.Rate = Rate;
                this.Days = Days;
            }
            public int GetSalary()
            {
                return Rate * Days;
            }

            public string Fullname()
            {
                return Name + " " + Surname;
            }
        }

        static void Main(string[] args)
        {
            Worker First = new Worker("Lena", "Golovach", 2000, 31);
            Console.WriteLine(First.Fullname());
            Console.WriteLine(First.GetSalary());
        }
    }
}


using System;

namespace ConsoleApp5
{
    public class Program
    {
        public class Calculation
        {
            public string CalculationLine;
            
            public void SetCalculationLine(string UserLine)
            {
                CalculationLine = UserLine;
            }

            public string SetLastSymbolCalculationLine(string LastSymbol)
            {
                CalculationLine = CalculationLine + LastSymbol;
                return CalculationLine;
            }

            public string GetCalculationLine()
            {
                return CalculationLine;
            }

            public string GetLastSymbol(string LastSymbol)
            {
                return LastSymbol;
            }

            public string DeleteLastSymbol()
            {
                CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
                return CalculationLine;
            }
        }
        
        static void Main(string[] args)
        {
            Calculation temp = new Calculation();
            temp.SetCalculationLine("Lena");
            temp.SetLastSymbolCalculationLine("G");
            temp.GetCalculationLine();
            temp.GetLastSymbol("G");
            temp.DeleteLastSymbol();
            Console.WriteLine(temp.GetCalculationLine());
            Console.WriteLine(temp.SetLastSymbolCalculationLine("G"));
            Console.WriteLine(temp.GetLastSymbol("G"));
            Console.WriteLine(temp.DeleteLastSymbol());
        }
    }
}

