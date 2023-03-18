using System;
using System.Collections.Generic;
namespace ConsoleApp5
{
    public class Program
    {
        public class Student
                 {
                private string secondName;
                private DateTime dateOfBirth;
                private int group;
                private List<int> grades = new List<int>();
        
        
                public void PrintInfo()
                {
                    Console.WriteLine($"Фамилия - {secondName}\nГруппа - {group}\nДата рождения - {dateOfBirth}");
                    foreach (int grade in grades)
                    {
                        System.Console.Write(grade + " ");
                    }
                    System.Console.WriteLine();
                }
                
                public void Changeinfo(string secondName)
                {
                    this.secondName = secondName;
                }
                public void Changeinfo(string secondName, DateTime dateOfBirth)
                {
                    this.secondName = secondName;
                    this.dateOfBirth = dateOfBirth;
                }
                public void Changeinfo(string secondName, DateTime dateOfBirth, int group)
                {
                    this.secondName = secondName;
                    this.dateOfBirth = dateOfBirth;
                    this.group = group;
                }
        
                public Student(string secondName, DateTime dateOfBirth, int group, List<int> grades)
                {
                    this.secondName = secondName;
                    this.dateOfBirth = dateOfBirth;
                    this.group = group;
                    this.grades = grades;
                }
            }
        
            static void Main()
            {
                Student ivan = new Student("Вострокнутов", new DateTime(1991, 12, 26), 666, new List<int> {5, 2, 3, 3, 4});
                ivan.Changeinfo(secondName: "Анчаров", dateOfBirth: new DateTime(2004,03,25), group: 621);
                ivan.PrintInfo();
            }
    }
}


using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Program
    {
        public class Train
        {
            private string stantion;
            public int id { get; private set; }
            private DateTime timeDepature;

            public void PrintInfo()
            {

                Console.WriteLine(
                    $"Станция - {this.stantion}\nНомер поезда - {this.id}\nВремя отправления - {this.timeDepature}");

            }

            public Train(string stantion, int id, DateTime timeDepature)
            {
                this.stantion = stantion;
                this.id = id;
                this.timeDepature = timeDepature;
            }
        }

        static void Main()
        {
            List<Train> trains = new List<Train>()
            {
                new Train("Барнаул", 1, new DateTime(year: 2023, month: 3, day: 17, hour: 1, minute: 5, second: 0)),
                new Train("Александровское", 2, new DateTime(year: 2024, month: 4, day: 14, hour: 14, minute: 5, second: 0)),
                new Train("Магадан", 3, new DateTime(year: 2033, month: 5, day: 13, hour: 12, minute: 5, second: 0))
            };
            int _id = int.Parse(Console.ReadLine());
            foreach (Train train in trains)
            {
                if (train.id == _id)
                    train.PrintInfo();
            }
        }
    }
}


using System;
namespace ConsoleApp5
{
    public class Program
    {
        class MATH
        {
            public int NUMBER1;
            public int NUMBER2;
        }

        static void Main(string[] args)
        {
            MATH FIRST_NUMBER = new MATH();
            MATH SECOND_NUMBER = new MATH();
            FIRST_NUMBER.NUMBER1 = 10;
            SECOND_NUMBER.NUMBER2 = 25;

            Console.WriteLine("1 - ВЫВОД НА ДИСПЛЕЙ, 2 - ИЗМЕНЕНИЕ НОМЕРА, 3 - ПОИСК НАИБОЛЬШЕГО ЧИСЛА, 4 - СУММА ЧИСЕЛ");
            int CHOICE = int.Parse(Console.ReadLine());
            switch (CHOICE)
            {
                case 1:
                    Console.WriteLine($"{FIRST_NUMBER.NUMBER1}, {SECOND_NUMBER.NUMBER2}");
                    break;
                case 2:
                    Console.WriteLine("ИЗМЕНИТЕ ПЕРВЫЙ НОМЕР");
                    int NUMBER_CHANGE1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ИЗМЕНИТЕ ВТОРОЙ НОМЕР");
                    int NUMBER_CHANGE2 = int.Parse(Console.ReadLine());

                    FIRST_NUMBER.NUMBER1 = NUMBER_CHANGE1;
                    SECOND_NUMBER.NUMBER2 = NUMBER_CHANGE2;
                    Console.WriteLine($"{FIRST_NUMBER.NUMBER1}, {SECOND_NUMBER.NUMBER2}");
                    
                    Console.WriteLine("ВЫ ХОТИТЕ ИСПОЛЬЗОВАТЬ ОПЕРАЦИЮ ДЛЯ НОВЫХ НОМЕРОВ? ЕСЛИ ВЫ ХОТИТЕ, НАЖМИТЕ 1, В ПРОТИВНОМ СЛУЧАЕ НАЖМИТЕ 2");
                    int CHOISE2 = int.Parse(Console.ReadLine());

                    if (CHOISE2 == 1)
                    {
                        Console.WriteLine("1 - Нахождение наивысшего значения, 2 - Сумма чисел");
                        int CHOICE_IN_CHOISE = int.Parse(Console.ReadLine());
                        switch (CHOICE_IN_CHOISE)
                        {
                            case 1:
                                if (FIRST_NUMBER.NUMBER1 < SECOND_NUMBER.NUMBER2)
                                {
                                    Console.WriteLine($"Наивысшее значение= {SECOND_NUMBER.NUMBER2}");
                                }
                                else
                                {
                                    Console.WriteLine($"Наивысшее значение = {FIRST_NUMBER.NUMBER1}");
                                }
                                break;
                            case 2:
                                int SUM_IN_CHOICE = 0;
                                SUM_IN_CHOICE = FIRST_NUMBER.NUMBER1 + SECOND_NUMBER.NUMBER2;
                                Console.WriteLine($"Сумма всех элементов = {SUM_IN_CHOICE}");
                                break;
                        }
                    }

                    else if (CHOISE2 == 2)
                    {
                        Console.WriteLine(" ? ");
                    }
                    
                    break;
                case 3:
                    if (FIRST_NUMBER.NUMBER1 < SECOND_NUMBER.NUMBER2)
                    {
                        Console.WriteLine($"Наивысшее значение = {SECOND_NUMBER.NUMBER2}");
                    }
                    else
                    {
                        Console.WriteLine($"Наивысшее значение  = {FIRST_NUMBER.NUMBER1}");
                    }
                    break;
                case 4:
                    int SUM = 0;
                    SUM = FIRST_NUMBER.NUMBER1 + SECOND_NUMBER.NUMBER2;
                    Console.WriteLine($"Cумма всех эелементов= {SUM}");
                    break;
            }
        }
    }
}



using System;
namespace ConsoleApp5
{
    public class Program
    {
        class counter
        {
            public int CountNumber;
        }

        static void Main(string[] args)
        {
            counter UserNumber = new counter();
            int count = 100;
            Console.WriteLine("1 - use ur value, 2 - use default value(100)");
            int InitialChoise = int.Parse(Console.ReadLine());
            
            if (InitialChoise == 1)
            {
                Console.WriteLine("Enter ur number");
                UserNumber.CountNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter 1 - if you want to increase the number, 2 - decrease the number");

                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    bool Increase = true;
                    while (Increase == true)
                    {
                        UserNumber.CountNumber++;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int IncreaseChoise = int.Parse(Console.ReadLine());

                        switch (IncreaseChoise)
                        {
                            case 1:
                                Increase = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {UserNumber.CountNumber}");
                                Increase = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {UserNumber.CountNumber - 1}");
                                Increase = false;
                                break;
                        }
                    }
                }
                else if (Choice == 2)
                {
                    bool Decrease = true;
                    while (Decrease == true)
                    {
                        UserNumber.CountNumber--;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int DecreaseChoise = int.Parse(Console.ReadLine());

                        switch (DecreaseChoise)
                        {
                            case 1:
                                Decrease = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {UserNumber.CountNumber}");
                                Decrease = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {UserNumber.CountNumber + 1}");
                                Decrease = false;
                                break;
                        }
                    }
                }
            }
            else if (InitialChoise == 2)
            {
                Console.WriteLine("Enter 1 - if you want to increase the number, 2 - decrease the number");

                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    bool Increase = true;
                    while (Increase == true)
                    {
                        count++;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int IncreaseChoise = int.Parse(Console.ReadLine());

                        switch (IncreaseChoise)
                        {
                            case 1:
                                Increase = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {count}");
                                Increase = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {count - 1}");
                                Increase = false;
                                break;
                        }
                    }
                }
                else if (Choice == 2)
                {
                    bool Decrease = true;
                    while (Decrease == true)
                    {
                        count--;
                        Console.WriteLine(
                            "1 - if u want to continue, 2 - If you want to see the result and continue, 3 - finish and get results");
                        int DecreaseChoise = int.Parse(Console.ReadLine());

                        switch (DecreaseChoise)
                        {
                            case 1:
                                Decrease = true;
                                break;
                            case 2:
                                Console.WriteLine($"Result = {count}");
                                Decrease = true;
                                break;
                            case 3:
                                Console.WriteLine($"Result = {count + 1}");
                                Decrease = false;
                                break;
                        }
                    }
                }
            }
        }
    }
}


using System;

namespace ConsoleApp5
{
    public class Program
    {
        class counter
        {
            public class Program
            {
                public class Default
                {
                    public string Name;
                    public int Age;

                    public Default()
                    {
                        Name = "Igor";
                        Age = 54;
                    }

                    public Default(string Name, int Age)
                    {
                        if (Name == "Igor" && Age == 54)
                        {
                            Console.WriteLine("Conditions met");
                        }
                        else
                        {
                            Console.WriteLine("Conditions not met");
                        }
                    }

                    ~Default()
                    {
                        Console.Write("objects removed");
                    }

                }

                static void Main(string[] args)
                {
                    Default temp = new Default();
                    Default User = new Default("Igor", 54);
                }


            }
        }
    }
}




