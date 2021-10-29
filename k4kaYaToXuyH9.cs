using System;
using System.Collections;

namespace Table
{
    public class OOP
    {
        public enum Type
        {
            F, US
        }
        public class Country
        {
            public String StateName;
            public String Capital;
            public int population;
            public Type CountryType;
            public Country(string StateName, string Capital, int population, Type CountryType)
            {
                this.StateName = StateName;
                this.Capital = Capital;
                this.population = population;
                this.CountryType = CountryType;
            }

            public void Print()
            {
                Console.WriteLine($"|{this.StateName,-24}|{this.Capital,-12}|{this.population,-20}|{this.CountryType,-15}|");
            }
        }
        private static void Main()
        {
            ArrayList list = new();      
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Название гос-ва:");
                string name = Console.ReadLine();

                Type CountryType;
                while (true)
                {
                    Console.WriteLine("Перечисляемый тип(F, US):");
                    string tmp = Console.ReadLine();
                    if (tmp == "F")
                    {
                        CountryType = Type.F;
                        break;
                    }
                    else if (tmp == "US")
                    {
                        CountryType = Type.US;
                        break;
                    }
                    else Console.WriteLine("Некорректный ввод значения. Введите еще раз.");

                }
                Console.WriteLine("Кол-во населения:");
                int population = int.Parse(Console.ReadLine());

                Console.WriteLine("Столица:");
                string Capital = Console.ReadLine();
                Country value = new(name, Capital, population, CountryType);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }
            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|География",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Государство",-25}|{"Столица",-12}|{"Население",-20}|{"Тип",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Country item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: F – федерация, US - унитарное гос-во",-75}|");
            Console.WriteLine(new String('-', 76));
        }
    }
}
