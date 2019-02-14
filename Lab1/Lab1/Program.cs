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
                            mas();
                            break;
                        case "5":
                            prost();
                            break;
                        case "6":
                            month();
                            break;
                        case "7":
                            Struc();
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
            Console.WriteLine("4. Массив со случайными числами в диапазоне, введённом пользователем");
            Console.WriteLine("5. Простые числа от 0 до числа, введённого пользователем");
            Console.WriteLine("6. Название времени года, соответствующему номеру месяца, введённому пользователем");
            Console.WriteLine("7. Пока ничего");
            Console.WriteLine("esc. Выход");
        }

        static void tabl()
        {
            Console.Clear();
            for (int a = 2; a < 11; a++)
            {
                for (int b = 1; b < 11; b++)
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
            Console.Write("Введите минимальное значение ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное значение ");
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
            public byte performance1;
        }


        static void Struc()
        {
            Sstudent[] students = new Sstudent[10];
            //Inpstud(ref students[i].fio, ref students[i].performance1, ref students[i].performance2);

            int i = 0;
            int j = 0;
            do

            {
            up1:
                Console.WriteLine("Вы хотите добавить студента? (Вы можите добавить ещё {0} студентов)", (10 - i));
                Console.WriteLine("1 - да | 0 - нет");

                ConsoleKeyInfo a;
                a = Console.ReadKey(false);
                switch (a.KeyChar.ToString())
                {
                    case "1":
                        Inpstud(ref students[i].fio, ref students[i].performance1);
                        j = i + 1;
                        break;
                    case "0":
                        i = 10;

                        break;
                    default:
                        goto up1;

                }
                i++;
            } while (i < 10);
        up2:
            Console.WriteLine("Желаете увидеть список студентов?");
            Console.WriteLine("2 - показать только лучшего | 1 - показать всех | 0 - нет");
            ConsoleKeyInfo cl;
            cl = Console.ReadKey(false);
            switch (cl.KeyChar.ToString())
            {
                case "2":
                    int b=0;
                    for (int m = 0; m != j; m++ ){
                        if (students[m].performance1 > b) b = m;
                    }
                    Outstud(students[b].fio, students[b].performance1);
                    Console.ReadKey();
                    break;

                case "1":
                    for (int m = 0; m != j; m++)
                    {
                        Outstud(students[m].fio, students[m].performance1);

                    }
                    Console.ReadKey();
                    break;
                case "0":
                    break;
                default:
                    goto up2;

            }

        }

        static void Inpstud(ref string FIO, ref byte a)
        {
            Console.WriteLine("Введите ФИО студента.. ");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите его оценки по чему-то.. ");
            a = byte.Parse(Console.ReadLine());
        }

        static void Outstud(string FIO, byte a)
        {
            Console.WriteLine("ФИО студента.. {0} ", FIO);
            Console.WriteLine("Оценка по чему-то.. {0} ", a);

        }


    }

}