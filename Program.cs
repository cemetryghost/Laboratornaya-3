namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели (0-6)");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите час (0-23)");
            int times = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введенная дата: ");
            Dayys(day);
            Timmes(times);
        }

        public static void Dayys(int day)
        {
            DayTime dayTime = (DayTime)day;

            switch (dayTime)
            {
                case DayTime.Monday: Console.Write("Понедельнк, "); 
                    break;
                case DayTime.Tuesday: Console.Write("Вторник, ");
                    break;
                case DayTime.Wednesday: Console.Write("Среда, ");
                    break;
                case DayTime.Thursday: Console.Write("Четверг, ");
                    break;
                case DayTime.Friday: Console.Write("Пятница, ");
                    break;
                case DayTime.Saturday: Console.Write("Суббота, ");
                    break;
                case DayTime.Sunday: Console.Write("Воскресенье, ");
                    break;
                default: Console.Write("Дней недели всего 7");
                    break;
            }
        }
        public static void Timmes(int times)
        {
            if (times >= 7 && times <= 12) { Console.Write("Утро"); }

            else if (times >= 13 && times <= 18) { Console.Write("День"); }

            else if (times >= 19 && times <= 23) { Console.Write("Вечер"); }

            else if (times >= 0 && times <= 6) { Console.Write("Ночь"); }

            else Console.WriteLine("В сутках 24 часа, от 0 до 23");
        }

        enum DayTime { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        enum TimeDay { Morning, Day, Evening, Night }
    }
}

