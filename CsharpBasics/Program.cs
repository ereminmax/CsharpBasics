using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Posobie
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstESC.writeESC();
            //SecondOne.writeTable();
            //SecondTwo.devideIt();
            //SecondThree.writeASCII();
            //Three.justDoIt();
            //Console.Write(FiveException.getResult());
            //Console.Write(FiveException.getResult());
            //SixRandom.justDoIt();
            //SevenEqual.justDoIt();
            //EightString.justDoIt();
            //new NineClass().justDoIt(); // И ОДИННАДЦААТАЯ
            //TenInstance.justDoIt();
            //двенадцать
            //Тринадцать. Сдалать 9 с использованием коллекций. List
            new TwelveThirteen("input.bat").justDoIt();

            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }

    //РАБОТА С ESC
    static class FirstESC
    {
        public static void writeESC()
        {
            Console.Write("C:\\Program Files\\Far\nD:\\Program Files\\Far\rF");
        }
    }

    //ВЫВЕСТИ ТАБЛИЦУ РАЗМЕРОВ ТИПОВ ДАННЫХ ТАБ 2.1
    static class SecondOne
    {
        public static void writeTable()
        {
            Console.Write("sizeof(int) = \t\t" + sizeof(int) + "\n");
            Console.Write("sizeof(double) = \t" + sizeof(double) + "\n");
            Console.Write("sizeof(decimal) = \t" + sizeof(decimal) + "\n");
            Console.Write("sizeof(bool) = \t\t" + sizeof(bool) + "\n");
            Console.Write("sizeof(char) = \t\t" + sizeof(char) + "\n");
        }
    }

    //ПОДЕЛИТЬ ДВА ЧИСЛА
    static class SecondTwo
    {
        private static int _x = 10, _y = 3;

        public static void devideIt()
        {
            Console.Write("result =\t" + (double)(_x) / _y);
        }
    }

    //ВЫВЕСТИ ASCII КОД СИМВОЛА И ЕГО СОСЕДЕЙ
    static class SecondThree
    {
        private static char _ch = 'G';

        public static void writeASCII()
        {
            int chCode = _ch;
            Console.Write(chCode + " " + (char)(--chCode) + " " + (char)(chCode += 2) + "\n");
        }
    }

    static class Three
    {
        private static String str1;
        private static String str2;
        private static double d;

        static DateTime today = DateTime.Now;

        public static void justDoIt()
        {
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            d = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WindowHeight = 32;
            Console.SetCursorPosition(Console.WindowWidth - 10, Console.WindowHeight - Console.WindowHeight);
            Console.Write("{0:M}", today);
            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth,
                                      Console.WindowHeight - Console.WindowHeight);
            Console.Write("{0} = {2:F2}\n{1} = {2:F2}", str1, str2, d);
            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth,
                                      Console.WindowHeight - 2);
            Console.Write("{0} = {2:F2}\n{1} = {2:F2}", str1, str2, d);
        }
    }

    //Формула нахождения давления. Задание 4 и 5
    static class FiveException
    {
        private static String _result;

        private static int doDevide(int x, int y)
        {
            if (x < 0 || y < 0) throw new Exception("Отрицательное число! ");
            return x / y;
        }

        private static void doIt()
        {
            try
            {
                Console.WriteLine("Введите два числа: ");
                int f = int.Parse(Console.ReadLine());
                int s = int.Parse(Console.ReadLine());

                int result = doDevide(f, s);
                _result = result.ToString();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0! ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число! ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static String getResult()
        {
            doIt();
            return _result;
        }

    }

    //Задание 6. Рандом
    static class SixRandom
    {
        private static Boolean _check;

        public static void justDoIt()
        {
            Random rand = new Random();

            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(2);
            }

            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i++])
                {
                    _check = true;
                }
            }

            if (_check == true) Console.WriteLine("Чередования нет ");
            else Console.WriteLine("Чередование есть ");
        }
    }

    //Задание 7. Вывести координаты элементов совпадающих с заданным
    static class SevenEqual
    {
        private static String getResult(int[][] arr, int number)
        {
            String str = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    if (arr[i][j] == number)
                    {
                        str += i.ToString();
                        str += j.ToString();
                        str += ' ';
                    }
                }
            }
            return str;
        }

        public static void justDoIt()
        {
            try
            {
                Console.WriteLine("Введите искомое число ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 1) throw new Exception("Выход за диапазон возможных чисел ");

                Random rand = new Random();

                int[][] arr = new int[3][];
                arr[0] = new int[5];
                arr[1] = new int[4];
                arr[2] = new int[3];

                for (int i = 0; i < arr.GetLength(0); i++)
                {

                    for (int j = 0; j < arr[i].GetLength(0); j++)
                    {
                        arr[i][j] = rand.Next(2);

                        Console.Write(arr[i][j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Координаты совпадающих эл-тов: " + getResult(arr, number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    //Задание 8. Строки
    static class EightString
    {
        private static String _str = "олОло ололошенька лОл ололошки олоЛоло";

        public static void justDoIt()
        {
            try
            {
                String[] strArray = new String[5];

                String[] strArrayResult = new String[5]; //Вспомогательный массив
                int i = 0;

                StringBuilder strBuilder = new StringBuilder(); //Для второго способа

                strArray = _str.Split();

                foreach (String el in strArray)
                {
                    if (el[0] == el[el.Length - 1])
                    {
                        strArrayResult[i] = el;
                        i++;
                        strBuilder.Append(el + ' '); //Второй способ (без использования вспомогательного массива)
                    }
                }

                String strResult = String.Join(" ", strArrayResult); //Восстанавливаем строку

                Console.WriteLine(strResult);
                Console.WriteLine(strBuilder);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }

    //Задание 9 и 11
    enum category { местный, муждународный, всероссийский };

    class NineClass //non-static                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
    {
        //StreamReader fileInput = new StreamReader("input.txt");
        //private static int[] yearArray = new int[3];
        //private static String[] titleArray = new String[3];
        //private static String[] categoryArray = new String[3];
        //String str = "";
        //String[] buffer;

        //while ( (str = fileInput.ReadLine()) != null) {}

        //private HistoricalEvent[] ob = new HistoricalEvent[3]; //non-static
        //private static int[] yearArray = new int[3] { 1342, 1995, 1812};
        //private static String[] titleArray = new String[3] { "Донской", "ВОВ", "Наполеон"};
        //private static String[] categoryArray = new String[3] { "Местный", "Муждународный", "Всероссийский"};
        //enum category { местный, муждународный, всероссийский };

        static HistoricalEvent[] ob = {
                                       new HistoricalEvent(1342, "Донской", category.местный),
                                       new HistoricalEvent(1995, "ВОВ", category.муждународный),
                                       new HistoricalEvent(1812, "Наполеон", category.всероссийский)
                                   };

        public void addElement(int year, String title, category categori)
        {
            int sizeOfArray = ob.Length;
            ob[sizeOfArray++] = new HistoricalEvent(year, title, categori);
        }

        public void justDoIt() //non-static
        {
            try
            {
                //for (int i = 0; i < ob.Length; i++)
                //{
                //    //Console.WriteLine("Введи данные события № " + i);
                //    //int year = int.Parse(Console.ReadLine());
                //    //String title = Console.ReadLine();
                //    //String category = Console.ReadLine();

                //    HistoricalEvent he = new HistoricalEvent(yearArray[i], titleArray[i], /*categoryArray[i]*/ category.);
                //    //HistoricalEvent he = new HistoricalEvent(1995, "ВОВ", "Мировой");
                //    ob[i] = he;
                //    //he = null;
                //    //Нужно ли обнулять he? he = null;
                //}

                //Console.WriteLine("Введи номера событий, у которых хочешь узнать разницу во времени");
                //int firstEvent = int.Parse(Console.ReadLine());
                //int secondEvent = int.Parse(Console.ReadLine());
                //Console.WriteLine(getDifference(firstEvent, secondEvent));

                //Console.WriteLine("Вывести события по следующей котегории: ");
                //String keyWord = Console.ReadLine();
                //searchArray(keyWord);

                //Пошло задание 11
                //Console.WriteLine("Отсортированный по году и событию массив [IComparer]: ");
                //sortArrayIComparer();

                //Console.WriteLine("Отсортированный по уровню [IComparable]: ");
                //sortArrayIComparable();

                //Console.WriteLine("Вывести события по следующей котегории исп. мод-ый ==: ");
                //String keyWord = Console.ReadLine();
                //searchOverridedEqual(keyWord);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int getDifference(int firstEvent, int secondEvent) //non-static
        {
            return Math.Abs(ob[firstEvent] - ob[secondEvent]);
        }

        public void searchArray(String keyWord) //non-static
        {
            if (keyWord == "") throw new Exception("Забыл ввести ключевое слово");

            for (int i = 0; i < ob.Length; i++)
            {
                if (ob[i].getCategory() == keyWord) Console.WriteLine(ob[i].getYear() + " " + ob[i].getTitle() + " " + ob[i].getCategory());
            }
        }

        public void sortArrayIComparer() //non-static
        {
            //https://msdn.microsoft.com/ru-ru/library/6tf1f0bc(v=vs.110).aspx
            //Отсортируем по комбинации с помощью интерфейса IComparer
            Array.Sort(ob, new sortByYearAndTitle());

            foreach (HistoricalEvent el in ob)
            {
                Console.WriteLine(el.getYear() + " " + el.getTitle() + " " + el.getCategory());
            }
        }

        public void sortArrayIComparable() //non-static
        {
            //http://www.c-sharpcorner.com/uploadfile/yougerthen/using-icomparable-and-icomparer-to-compare-objects/
            //Отсортируем по уровню с помощью интерфейса IComparable
            HistoricalEvent temp = null;
            int state;
            bool flag = false;

            for (int j = 0; j < ob.Length - 1; j++)
            {
                for (int i = j; i < ob.Length; i++)
                {
                    state = ob[j].CompareTo(ob[i]);
                    if (state == 1)
                    {
                        temp = ob[j];
                        ob[j] = ob[i];
                        ob[i] = temp;
                    }

                    if (j == ob.Length - 2 && i == ob.Length - 1)
                    {
                        flag = true;
                        Console.WriteLine(ob[j].getYear() + " " + ob[j].getTitle() + " " + ob[j].getCategory());
                        Console.WriteLine(ob[i].getYear() + " " + ob[i].getTitle() + " " + ob[i].getCategory());
                        break;
                    }
                }
                if (flag != true) Console.WriteLine(ob[j].getYear() + " " + ob[j].getTitle() + " " + ob[j].getCategory());
            }
        }

        public void searchOverridedEqual(String keyWord)
        {
            if (keyWord == "") throw new Exception("Забыл ввести ключевое слово");

            for (int i = 0; i < ob.Length; i++)
            {
                if (ob[i] == keyWord) Console.WriteLine(ob[i].getYear() + " " + ob[i].getTitle() + " " + ob[i].getCategory());
            }
        }
    }

    //Переопределяем метод Compare, создав пользовательский Интерфейс
    class sortByYearAndTitle : IComparer<HistoricalEvent>
    {
        public int Compare(HistoricalEvent x1, HistoricalEvent y1)
        {
            //http://stackoverflow.com/questions/5980780/difference-between-icomparable-and-icomparer
            //Сравнение по комбинации
            if (x1.getYear() < y1.getYear() && String.Compare(x1.getTitle(), y1.getTitle()) == 1)
            {
                return 1;
            }
            if (x1.getYear() > y1.getYear() && String.Compare(x1.getTitle(), y1.getTitle()) == -1)
            {
                return -1;
            }
            else return 0;
        }
    }

    [Serializable]
    class HistoricalEvent : IComparable//<HistoricalEvent>
    {
        private int year;           //год
        private String title;       //название
        private category categori;    //уровень

        public HistoricalEvent() { Console.WriteLine("Пропущены параметры конструктора "); }                    //конструктор 1
        public HistoricalEvent(int number) { Console.WriteLine("Параметров три: число, строка, строка"); }      //конструктор 2
        public HistoricalEvent(int year, String title, category categori)                                         //конструктор 3
        {
            this.year = year;
            this.title = title;
            this.categori = categori;
        }

        //Переопределим Equals как сравнение событий по уровню
        //http://www.intuit.ru/studies/courses/629/485/lecture/11015?page=3
        //public override bool Equals(object obj)
        //{
        //    if (obj == null || GetType() != obj.GetType()) return false;

        //    HistoricalEvent temp = (HistoricalEvent)obj;
        //    return category == temp.getCategory();
        //}

        public override bool Equals(Object obj)
        {
            //if (obj == null || GetType() != obj.GetType()) return false;

            String temp = (String)obj;
            return categori.ToString() == temp;
        }

        //Соответственно переопределим hashcode
        public override int GetHashCode()
        {
            return title.GetHashCode();
        }

        //Переоп
        public static bool operator ==(HistoricalEvent a, String b)
        {
            return a.Equals(b);
        }

        public static int operator -(HistoricalEvent a, HistoricalEvent other)
        {
            return Math.Abs(a.year - other.year);
        }

        public static bool operator !=(HistoricalEvent a, String b)
        {
            return !(a.Equals(b));
        }

        //Переопределим CompareTo, как сравнение по уровню
        public int CompareTo(Object obj)
        {
            HistoricalEvent temp = (HistoricalEvent)obj;
            if (String.Compare(this.categori.ToString(), temp.categori.ToString()) == 1) return 1;
            if (String.Compare(this.categori.ToString(), temp.categori.ToString()) == -1) return -1;
            else return 0;
        }

        public int getYear()
        {
            return this.year;
        }

        public String getTitle()
        {
            return this.title;
        }

        public String getCategory()
        {
            return this.categori.ToString();
        }
    }

    //Задание 10. Наследование
    static class TenInstance
    {
        public static void justDoIt()
        {
            try
            {
                CTrapezoid ct = new CTrapezoid(1, 3, 4, 5,
                                                4, 4, 3, 0);
                Console.WriteLine(ct.getPerimetr() + " " + ct.getSquare() + " " + ct.isEqual());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class CPoint { }

    class CRectangle : CPoint
    {
        protected int x1, x2, x3, x4, y1, y2, y3, y4;

        public CRectangle()
        {
            Console.WriteLine("Нарисован квадрат");
        }

        public CRectangle(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
    }

    class CTrapezoid : CRectangle
    {
        public CTrapezoid(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4) : base(x1, x2, x3, x4, y1, y2, y3, y4) { }

        private void checkIt()
        {
            if (((double)(y1 - y4) / (x1 - x4)) != ((double)(y2 - y3) / (x2 - x3))) throw new Exception("Not trapezoid!");
        }

        public double getPerimetr()
        {
            checkIt();
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) + //с
                   Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)) + //b
                   Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)) + //d
                   Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));  //a

            //Math.Abs(x1 - x4) + Math.Abs(x2 - x3) + Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + 
            //   Math.Pow(Math.Abs(y1 - y2), 2)) + Math.Sqrt(Math.Pow(Math.Abs(x4 - x3), 2) + 
            //   Math.Pow(Math.Abs(y3 - y4), 2));
        }

        public double getSquare()
        {
            double p = getPerimetr() / 2;
            checkIt();
            return (
                       Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)) +
                       Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))
                   ) / Math.Abs
                   (
                       Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)) -
                       Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))
                   ) * Math.Sqrt
                   (
                       (p - Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2))) *
                       (p - Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))) *
                       (p - Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)) -
                       Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))) *
                       (p - Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)) -
                       Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)))
                   )
                ;

            //(double)(Math.Abs(y1 - y2)) * 0.5 * (Math.Abs(x1 - x4) + Math.Abs(x2 - x3));
        }

        public Boolean isEqual()
        {
            checkIt();
            return Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)) ==
                   Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
        }
    }

    // Задание 12 и 13
    [Serializable]
    class TwelveThirteen
    {
        private String fileName;
        private List<HistoricalEvent> list;  
        private HistoricalEvent[] ob;

        public TwelveThirteen(String fileName) 
        { 
            this.fileName = fileName; 
        }

        public void justDoIt() 
        {
            // Загрузить файл
            loadState();

            // Логика
            toDo();

            // Сохранить файл
            saveState();
        }

        private void toDo()
        {
            try
            {
                Console.WriteLine("Введи номера событий, у которых хочешь узнать разницу во времени");
                int firstEvent = int.Parse(Console.ReadLine());
                int secondEvent = int.Parse(Console.ReadLine());

                list.Add(new HistoricalEvent(3, "One", category.всероссийский));
                list.Add(new HistoricalEvent(1, "Two", category.местный));
                list.Add(new HistoricalEvent(3, "Three", category.всероссийский));
                // Andrew Troelsen page 341
                // Коллекцию в массив
                ob = list.ToArray();
                Console.WriteLine(getDifference(firstEvent, secondEvent));

                Console.WriteLine("Вывести события по следующей котегории: ");
                String keyWord = Console.ReadLine();
                searchArray(keyWord);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка в toDo: " + e.Message);
            }
        }

        private int getDifference(int firstEvent, int secondEvent)
        {
            return Math.Abs(ob[firstEvent].getYear() - ob[secondEvent].getYear());
        }

        private void searchArray(String keyWord)
        {
            if (keyWord == "") throw new Exception("Забыл ввести ключевое слово");

            for (int i = 0; i < ob.Length; i++)
            {
                if (ob[i].getCategory() == keyWord) Console.WriteLine(ob[i].getYear() + " " + ob[i].getTitle() + " " + ob[i].getCategory());
            }
        }

        private void loadState()
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    list = new List<HistoricalEvent>();
                    list = (List<HistoricalEvent>)bf.Deserialize(fs);
                }       
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение в loadState: " + e.Message);
            }
        }

        private void saveState()
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Write, FileShare.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка в saveState: " + e.Message);
            }
        }
    }  // Class
} // Namespace