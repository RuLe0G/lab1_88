using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                ConsoleKeyInfo cl;

                do
                {

                    display();
                    cl = Console.ReadKey(false);
                    switch (cl.KeyChar.ToString())
                    {
                        case "1":
                            tabl();
                            break;
                        case "2":
                            tst();
                            break;
                        case "3":
                            swap();
                            break;
                        case "4":
                            prost();
                            break;
                        case "5":
                            month();
                            break;
                        case "6":
                            break;
                        default:
                            break;
                    }
                } while (cl.Key != ConsoleKey.Escape);

            }
        }

        static void display()
        {
            Console.Clear();
            Console.WriteLine("1. Таблица умножения");
            Console.WriteLine("2. Является ли введённый символ цифрой?");
            Console.WriteLine("3. Обмен значениями");
            Console.WriteLine("4. Простые числа от 0 до числа, введённого пользователем");
            Console.WriteLine("5. Название времени года, соответствующему номеру месяца, введённому пользователем");
            Console.WriteLine("6. Ничего");
            Console.WriteLine("esc. Выход");
        }

        static void tabl()
        {
            Console.Clear();
            for (int a = 2; a < 11; a++)
            {
                for (int b = 2; b < 11; b++)
                {
                    int p = a * b;
                    Console.WriteLine("---------------");
                    Console.Write("{0,2} * {1,2} = {2,3} |\n", a, b, p);

                }
                Console.WriteLine("---------------\n");
            }
            Console.ReadLine();
        }   //1



        static void tst()
        {
            Console.Clear();
            Console.Write("Введите cимвол: ");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    Console.Write("Введённый символ является цифрой\n"); break;
                default: Console.WriteLine("Введённый символ не является цифрой\n"); break;
            }
            Console.ReadLine();
        }       //2



        static void swap()
        {
            Console.Clear();
            double a = 0.56;
            double b = 987.1212121;
            Console.WriteLine("До обмена a = {0} b = {1}", a, b);
            double v = b;
            b = a;
            a = v;
            Console.WriteLine("После обмена a = {0} b = {1}", a, b);
            Console.ReadLine();
        }   //3



        static void mas()
        {
            Console.Clear();
            Random rnd = new Random();
            Console.Write("Введите минимальное значение");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное значение");
            int b = int.Parse(Console.ReadLine());
            int[,] mas = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas[i, j] = rnd.Next(a, b);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,3}", mas[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }       //4



        static void prost()
        {
            Console.Clear();
            Console.Write("Введите число... ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                if (tstpro(i) == 1)
                    Console.Write("{0} ", i);

            }
            Console.ReadLine();
        }   //5

        static int tstpro(int m)
        {
            int pr = 1;

            for (int i = 2; i <= m / 2; i++)
            {
                if (m % i == 0)
                {
                    pr = 0;
                    break;
                }
            }
            return pr;
        }



        static void month()
        {
            Console.Clear();
        up:
            Console.Write("Введите номер месяца... ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 12:
                case 1:
                case 2: Console.Write("Это зима"); break;
                case 3:
                case 4:
                case 5: Console.Write("Это весна"); break;
                case 6:
                case 7:
                case 8: Console.Write("Это лето"); break;
                case 9:
                case 10:
                case 11: Console.Write("Это осень"); break;
                default:
                    Console.WriteLine("Проверьте ввод (месяцев 12)");
                    goto up;
            }
            Console.ReadLine();
        }   //6



        struct Sstudent
        {
            public string fio;
            public byte performance;
        }

        static void Struc()
        {
            Sstudent Stud = new Sstudent();
            Stud.fio = "Jo Jo";
            Stud.performance = 5;

        }
    }
}
