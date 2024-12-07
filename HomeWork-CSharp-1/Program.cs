using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_CSharp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи по теме: \"Ввод и вывод числовых данных. Оператор присваивания\" (48 задачи)" +
                "\n    1) Простейшие программы. Арифметические выражения (13 задач)" +
                "\n    2) Вычисления по известным формулам (30 задач)" +
                "\n    3) Часто используемые эффективные алгоритмы (5 задач)" +
                "\nВведите номер параграфа (1-3):");
            int paragraphNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (paragraphNumber)
            {
                case 1: goto paragraph_1;
                case 2: goto paragraph_2;
                case 3: goto paragraph_3;
            }
        paragraph_1:
            {
                Console.WriteLine("Простейшие программы. Арифметические выражения (13 задач)" +
                    "\n" +
                    "\n1) Вывести на экран число  с точностью до сотых." +
                    "\n2) Вывести на экран число e (основание натурального логарифма) с точностью до десятых." +
                    "\n3) Составить программу вывода на экран числа, вводимого с клавиатуры. " +
                    "\n   Выводимому числу должно предшествовать сообщение \"Вы ввели число\"." +
                    "\n4) Составить программу вывода на экран числа, вводимого с клавиатуры." +
                    "\n   После выводимого числа должно следовать сообщение \" — вот какое число Вы ввели\"." +
                    "\n5) Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними." +
                    "\n6) Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними." +
                    "\n7) Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними." +
                    "\n8) Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними." +
                    "\n9) Вывести на экран числа 50 и 10 одно под другим." +
                    "\n10)Вывести на экран числа 5, 10 и 21 одно под другим." +
                    "\n11)Составить программу вывода на экран \"столбиком\" четырех любых чисел." +
                    "\n12)Составить программу вывода на экран следующей информации:\n   5 10\n   7 см" +
                    "\n13)Составить программу вывода на экран следующей информации:\n   2 кг\n   13 17" +
                    "\n" + new string('*', Console.WindowWidth) +
                    "\nВведите номер задачи: ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (taskNumber)
                {
                    case 1: goto task_1_1;
                    case 2: goto task_1_2;
                    case 3: goto task_1_3;
                    case 4: goto task_1_4;
                    case 5: goto task_1_5;
                    case 6: goto task_1_6;
                    case 7: goto task_1_7;
                    case 8: goto task_1_8;
                    case 9: goto task_1_9;
                    case 10: goto task_1_10;
                    case 11: goto task_1_11;
                    case 12: goto task_1_12;
                    case 13: goto task_1_13;
                }
            task_1_1:
                {
                    //1.1. Вывести на экран число с точностью до сотых.
                    Console.WriteLine("Условие задачи:\nВывести на экран число с точностью до сотых");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Random rnd = new Random();  //Создание объекта для генерации чисел.
                    double number = rnd.NextDouble() + rnd.Next(0, 9);   //Сложение рандомного натурального числа и рандомного целого числа.
                    string value = string.Format("{0:f}", number);   //Преревод числительной переменной в строку и форматирование дробного числа.
                    Console.WriteLine(value); return;
                }
            task_1_2:
                {
                    //1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
                    Console.WriteLine("Условие задачи:\nВывести на экран число e (основание натурального логарифма) с точностью до десятых.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    double numberE = Math.E; //Определяем переменную и присваеваем ей константу (E).
                    double result = Math.Round(numberE, 1); //сокращаем до 1го символова после целого числа.
                    Console.WriteLine(result); return;
                }
            task_1_3:
                {
                    //1.3.Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».            
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран числа, вводимого с клавиатуры." +
                        "\nВыводимому числу должно предшествовать сообщение \"Вы ввели число\".");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    int value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Вы ввели число " + value); return;
                }
            task_1_4:
                {
                    //1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение « — вот какое число Вы ввели».
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран числа, вводимого с клавиатуры." +
                        "\nПосле выводимого числа должно следовать сообщение \" — вот какое число Вы ввели\".");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{number} — вот какое число Вы ввели"); return;
                }
            task_1_5:
                {
                    //1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
                    Console.WriteLine("Условие задачи:\nВывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.WriteLine("1" + "13" + " 49"); return;
                }
            task_1_6:
                {
                    //1.6.Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
                    Console.WriteLine("Условие задачи:\nВывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.WriteLine("5 15 100"); return;
                }
            task_1_7:
                {
                    //1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Random rnd = new Random();
                    int valueOne = rnd.Next();
                    int valueTwo = rnd.Next();
                    int valueThree = rnd.Next();
                    Console.WriteLine(valueOne + " " + valueTwo + " " + valueThree); return;
                }
            task_1_8:
                {
                    //1.8. Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Random rnd = new Random();
                    int valueOne = rnd.Next();
                    int valueTwo = rnd.Next();
                    int valueThree = rnd.Next();
                    int valueFour = rnd.Next();
                    Console.WriteLine($"{valueOne}{valueTwo} {valueThree}{valueFour}"); return;
                }
            task_1_9:
                {
                    //1.9. Вывести на экран числа 50 и 10 одно под другим.
                    Console.WriteLine("Условие задачи:\nВывести на экран числа 50 и 10 одно под другим.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.WriteLine("50\n10"); return;
                }
            task_1_10:
                {
                    //1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
                    Console.WriteLine("Условие задачи:\nВывести на экран числа 5, 10 и 21 одно под другим.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    int five = 5;
                    int ten = 10;
                    int twentyOne = 21;
                    Console.WriteLine($"{five}\n{ten}\n{twentyOne}"); return;
                }
            task_1_11:
                {
                    //1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран \"столбиком\" четырех любых чисел.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Random rnd = new Random();
                    for (int i = 0; i < 4; i++)
                    {
                        int a = rnd.Next();
                        Console.WriteLine($"{a}");
                    }
                    return;
                }
            task_1_12:
                {
                    //1.12. Составить программу вывода на экран следующей информации:
                    //5 10
                    //7 см
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран следующей информации:\n5 10\n7 см");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    int a = 5; int b = 10;
                    int c = 7; string d = "см";
                    Console.WriteLine($"{a} {b}\n{c} {d}"); return;
                }
            task_1_13:
                {
                    //1.13.Составить программу вывода на экран следующей информации:
                    //2 кг
                    //13 17
                    Console.WriteLine("Условие задачи:\nСоставить программу вывода на экран следующей информации:\n2 кг\n13 17");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    int a = 2; string b = "кг";
                    int c = 13; int d = 17;
                    Console.WriteLine($"{a} {b}\n{c} {d}"); return;
                }
            }
        paragraph_2:
            {
                Console.WriteLine("Вычисления по известным формулам (30 задач)" +
                    "\n" +
                    "\n1) Составить программу:" +
                    "\n   а) вычисления значения функции y=7x^2+3x+6 при любом значении x;" +
                    "\n   б) вычисления значения функции x=12a^2+7a+12 при любом значении а." +
                    "\n2) Дана сторона квадрата. Найти его периметр." +
                    "\n3) Дан радиус окружности. Найти ее диаметр." +
                    "\n4) Считая, что Земля — идеальная сфера с радиусом R=6350 км. \n    Определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей." +
                    "\n5) Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности." +
                    "\n6) Дан радиус окружности. Найти длину окружности и площадь круга." +
                    "\n7) Даны два целых числа. Найти:\n   а) их среднее арифметическое;\n   б) их среднее геометрическое." +
                    "\n8) Известны объем и масса тела. Определить плотность материала этого тела." +
                    "\n9) Известны количество жителей в государстве и площадь его территории. \n   Определить плотность населения в этом государстве." +
                    "\n10)Составить программу решения линейного уравнения ax+b=0 (a != 0)." +
                    "\n11)Даны катеты прямоугольного треугольника. Найти его гипотенузу." +
                    "\n12)Найти площадь кольца по заданным внешнему и внутреннему радиусам." +
                    "\n13)Даны катеты прямоугольного треугольника. Найти его периметр." +
                    "\n14)Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей." +
                    "\n15)Даны основания и высота равнобедренной трапеции. Найти ее периметр." +
                    "\n16)Даны стороны прямоугольника. Найти его периметр и длину диагонали." +
                    "\n17)Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе." +
                    "\n18)Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности." +
                    "\n19)Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними." +
                    "\n20)Даны основания и высота равнобедренной трапеции. Найти периметр трапеции." +
                    "\n21)Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции." +
                    "\n22)Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника." +
                    "\n23)Выпуклый четырехугольник задан координатами своих вершин. \n   Найти площадь этого четырехугольника как сумму площадей треугольников." +
                    "\n24)Известна стоимость 1 кг конфет, печенья и яблок. \n   Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок." +
                    "\n25)Известна стоимость монитора, системного блока, клавиатуры и мыши. \n  Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?" +
                    "\n26)Возраст Тани — X лет, а возраст Мити — Y лет." +
                    "\n   Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения." +
                    "\n27)Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час." +
                    "\n   Определить, через какое время автомобили встретятся, если расстояние между ними было S км." +
                    "\n28)Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2)." +
                    "\n   Какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км." +
                    "\n29)Известно значение температуры по шкале Цельсия. Найти соответствующее  значение температуры по шкале:\n   а) Фаренгейта; \n   б) Кельвина." +
                    "\n30)У американского писателя-фантаста Рэя Бредбери есть роман \"450 градусов  по Фаренгейту\"." +
                    "\n   Какой температуре по шкале Цельсия соответствует указанное в названии значение?" +
                    "\n" + new string('*', Console.WindowWidth) +
                    "\nВведите номер задачи (1-30): ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (taskNumber)
                {
                    case 1: goto task_2_1;
                    case 2: goto task_2_2;
                    case 3: goto task_2_3;
                    case 4: goto task_2_4;
                    case 5: goto task_2_5;
                    case 6: goto task_2_6;
                    case 7: goto task_2_7;
                    case 8: goto task_2_8;
                    case 9: goto task_2_9;
                    case 10: goto task_2_10;
                    case 11: goto task_2_11;
                    case 12: goto task_2_12;
                    case 13: goto task_2_13;
                    case 14: goto task_2_14;
                    case 15: goto task_2_15;
                    case 16: goto task_2_16;
                    case 17: goto task_2_17;
                    case 18: goto task_2_18;
                    case 19: goto task_2_19;
                    case 20: goto task_2_20;
                    case 21: goto task_2_21;
                    case 22: goto task_2_22;
                    case 23: goto task_2_23;
                    case 24: goto task_2_24;
                    case 25: goto task_2_25;
                    case 26: goto task_2_26;
                    case 27: goto task_2_27;
                    case 28: goto task_2_28;
                    case 29: goto task_2_29;
                    case 30: goto task_2_30;
                }
            task_2_1:
                {
                    //2.1. Составить программу:
                    //а) вычисления значения функции y = 7x^2 + 3x + 6 при любом значении x;
                    //б) вычисления значения функции x = 12a^2 + 7a + 12 при любом значении а.
                    Console.WriteLine("Условие задачи:\nСоставить программу:\nа) вычисления значения функции y = 7x^2 + 3x + 6 при любом значении x;\nб) вычисления значения функции x = 12a^2 + 7a + 12 при любом значении а.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("а) Вычислите значение функции y = 7x^2 + 3x + 6\nВведите значение X: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = (7 * (x * x)) + (3 * x) + 6;
                    Console.WriteLine($"Значение функции У при значении X = {x} равняется {y}");
                    Console.Write("б) Вычислите значение функции x = 12a^2 + 7a + 12\nВведите значение A: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double x1 = (12 * (a * a)) + (7 * a) + 12;
                    Console.WriteLine($"Значение функции X при значении A = {a} равняется {x1}"); return;
                }
            task_2_2:
                {
                    //2.2. Дана сторона квадрата. Найти его периметр.
                    Console.WriteLine("Условие задачи:\nДана сторона квадрата. Найти его периметр.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                input:
                    Console.Write("Сторона квадрата равна: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    while (!(a >= 0))
                    {
                        Console.WriteLine("Вы ввели неверное значение");
                        goto input;
                    }
                    double P = 4 * a;
                    Console.WriteLine("Периметр квадрата равен " + P); return;
                }
            task_2_3:
                {
                    //2.3. Дан радиус окружности. Найти ее диаметр.
                    Console.WriteLine("Условие задачи:\nДан радиус окружности. Найти ее диаметр.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                input:
                    Console.Write("Радиус окружности равен: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    while (!(r > 0))
                    {
                        Console.WriteLine("Вы ввели неверное значение");
                        goto input;
                    }
                    double D = 2 * r;
                    Console.WriteLine("Диаметр окружности равен " + D); return;
                }
            task_2_4:
                {
                    //2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
                    //h = AB - высота, OA = OG = R - радиус Земли, BG - расстояние до горизонта, BG перпендикулярна OG как касательная к окружности.
                    Console.WriteLine("Условие задачи:\nСчитая, что Земля — идеальная сфера с радиусом R=6350 км. \nОпределить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    int r = 6350;
                    int OA = r;
                    int OG = r;
                input:
                    Console.WriteLine("Введите расстояние над землёй (км) ");
                    double AB = Convert.ToDouble(Console.ReadLine());
                    while (!(AB > 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto input;
                    }
                    double GB = Math.Sqrt(Math.Pow(OA + AB, 2) - (Math.Pow(OG, 2)));
                    Console.WriteLine(GB.ToString("#.##") + " км"); return;
                }
            task_2_5:
                {
                    //2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности. 
                    Console.WriteLine("Условие задачи:\nДана длина ребра куба. Найти объем куба и площадь его боковой поверхности.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                input:
                    Console.Write("Введите значение длины ребра \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    while (!(a > 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto input;
                    }
                    double V = Math.Pow(a, 3);  //Объём куба
                    double S = 4 * Math.Pow(a, 2);  //Площадь стороны куба
                    Console.WriteLine($"Объём куба равен {V}\nПлощадь стороны куба равна {S}"); return;
                }
            task_2_6:
                {
                    //2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
                    Console.WriteLine("Условие задачи:\nДан радиус окружности. Найти длину окружности и площадь круга.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                input:
                    Console.Write("Введите значение радиуса окружности \"r\": ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    while (!(r > 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto input;
                    }
                    double d = 2 * r;   //Диамерт через радиус
                    double C = Math.PI * d;  //Длина окружности через диаметр
                    double S = Math.PI * Math.Pow(r, 2);    //Площадь круга
                    Console.WriteLine($"Длина окружности равна {C.ToString("#.##")}\nПлощадь круга равна {S.ToString("#.##")}"); return;
                }
            task_2_7:
                {
                    //2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
                    Console.WriteLine("Условие задачи:\nДаны два целых числа. Найти:\nа) их среднее арифметическое;\nб) их среднее геометрическое.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите первое число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    double A = (x + y) / 2;
                    double G = Math.Sqrt(x * y);
                    Console.WriteLine($"Ответ:\nа) Среднее арифметическое чисел {x} и {y} равно: {A.ToString("#.##")}" +
                        $"\nб) Среднее геометрическое чисел {x} и {y} равно: {G.ToString("#.##")}"); return;
                }
            task_2_8:
                {
                    //2.8. Известны объем и масса тела. Определить плотность материала этого тела.
                    Console.WriteLine("Условие задачи:\nИзвестны объем и масса тела. Определить плотность материала этого тела.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                input:
                    Console.Write("Введите объём тела: ");
                    double V = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите массу тела: ");
                    double m = Convert.ToDouble(Console.ReadLine());
                    while (!(V > 0 && m > 0))
                    {
                        Console.WriteLine("Введены неверные параметры");
                        goto input;
                    }
                    double p = m / V;
                    Console.WriteLine("Плотность материала равна: " + p.ToString("#.##")); return;
                }
            task_2_9:
                {
                    //2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.
                    Console.WriteLine("Условие задачи:\nИзвестны количество жителей в государстве и площадь его территории. \nОпределить плотность населения в этом государстве.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputPeople:
                    Console.Write("Введите количество жителей (млн): ");
                    double people = Convert.ToDouble(Console.ReadLine());
                    double peopleInMil = people * 1000000;
                    if (peopleInMil > 0)
                    {
                    imputSquare:
                        Console.Write("Введите площадь территории (млн.км^2): ");
                        double square = Convert.ToDouble(Console.ReadLine());
                        double squareInMil = square * 1000000;
                        if (square > 0)
                        {
                            double P = peopleInMil / squareInMil;
                            Console.WriteLine("Плотность населения равна: " + P.ToString("#.##"));
                            return;
                        }
                        else
                            Console.WriteLine("Введено неверное значение");
                        goto imputSquare;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputPeople;
                    }
                }
            task_2_10:
                {
                    //2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
                    Console.WriteLine("Условие задачи:\nСоставить программу решения линейного уравнения ax+b=0 (a != 0).");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                readA:
                    Console.Write("Введите коэффициент \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a != 0)
                    {
                    readB:
                        Console.Write("Введите коэффициент \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b != 0)
                        {
                            double x = -b / a;
                            Console.WriteLine("Переменная X = " + x.ToString());
                            return;
                        }
                        else
                            Console.WriteLine("Недопустимое значение. Введите значение отличное от 0");
                        goto readB;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение. Введите значение отличное от 0");
                        goto readA;
                    }
                }
            task_2_11:
                {
                    //2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.
                    Console.WriteLine("Условие задачи:\nДаны катеты прямоугольного треугольника. Найти его гипотенузу.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputOne:
                    Console.Write("Введите катет \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputTwo:
                        Console.Write("Введите катет \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > 0)
                        {
                            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                            Console.WriteLine("Гипотенуза прямоугольного треугольника \"c\" равна: " + c.ToString("#.##"));
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое значение");
                            goto imputTwo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение");
                        goto imputOne;
                    }
                }
            task_2_12:
                {
                    //2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.
                    Console.WriteLine("Условие задачи:\nНайти площадь кольца по заданным внешнему и внутреннему радиусам.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputOne:
                    Console.Write("Введите внешний радиус \"R\": ");
                    double R = Convert.ToDouble(Console.ReadLine());
                    if (R > 0)
                    {
                    imputTwo:
                        Console.Write("Введите внутренний радиус \"r\": ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        if ((r > 0) && (r < R))
                        {
                            double S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
                            Console.WriteLine("Площадь кольца равна: " + S.ToString("#.##"));
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Введено недопустимое значение");
                            goto imputTwo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введено недопустимое значение");
                        goto imputOne;
                    }
                }
            task_2_13:
                {
                    //2.13. Даны катеты прямоугольного треугольника. Найти его периметр.
                    Console.WriteLine("Условие задачи:\nДаны катеты прямоугольного треугольника. Найти его периметр.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputOne:
                    Console.Write("Введите катет \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputTwo:
                        Console.Write("Введите катет \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > 0)
                        {
                            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                            double P = a + b + c;
                            Console.WriteLine("Гипотенуза прямоугольного треугольника \"c\" равна: " + P.ToString("#.##"));
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое значение");
                            goto imputTwo;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое значение");
                        goto imputOne;
                    }
                }
            task_2_14:
                {
                    //2.14. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
                    Console.WriteLine("Условие задачи:\nДаны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите первое число: ");
                    double X = Convert.ToDouble(Console.ReadLine());
                    double modX = Math.Abs(X);
                    Console.Write("Введите второе число: ");
                    double Y = Convert.ToDouble(Console.ReadLine());
                    double modY = Math.Abs(Y);
                    double A = (modX + modY) / 2;
                    double G = Math.Sqrt(modX * modY);
                    Console.WriteLine($"Модули чисел |{X}| и |{Y}| = {modX} и {modY} соответственно\nСреднее арифметическое по модулям = {A.ToString("#.##")}" +
                        $"\nСреднее геометрическое по модулям = {G.ToString("#.##")}"); return;
                }
            task_2_15:
                {
                    //2.15. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
                    Console.WriteLine("Условие задачи:\nДаны основания и высота равнобедренной трапеции. Найти ее периметр.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputA:
                    Console.Write("Введите основание \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputB:
                        Console.Write("Введите основание \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > 0)
                        {
                        imputH:
                            Console.Write("Введите высоту \"h\": ");
                            double h = Convert.ToDouble(Console.ReadLine());
                            if (h > 0)
                            {
                                double P = a + b + 2 * Math.Sqrt(Math.Pow(h, 2) + Math.Pow((a - b), 2) / 4);
                                Console.WriteLine("Периметр равнобедренной трапеции павен: " + P.ToString("#.##"));
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Введено неверное значение.");
                                goto imputH;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введено неверное значение.");
                            goto imputB;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение.");
                        goto imputA;
                    }
                }
            task_2_16:
                {
                    //2.16. Даны стороны прямоугольника. Найти его периметр и длину диагонали.
                    Console.WriteLine("Условие задачи:\nДаны стороны прямоугольника. Найти его периметр и длину диагонали.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputA:
                    Console.Write("Введите сторону \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputB:
                        Console.Write("Введите сторону \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > 0)
                        {
                            double P = (a + b) * 2;
                            double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                            Console.WriteLine($"Периметр прямоугольника равен: {P.ToString("#.##")}\nДиагональ прямоугольника равна: {d.ToString("#.##")}");
                            return;
                        }
                        Console.WriteLine("Введено неверное значение");
                        goto imputB;
                    }
                    Console.WriteLine("Введено неверное значение");
                    goto imputA;
                }
            task_2_17:
                {
                    //2.17. Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.
                    Console.WriteLine("Условие задачи:\nДаны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите первое число: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    double sum = x + y;
                    double raz = x - y;
                    double pro = x * y;
                    double chas = x / y;
                    Console.WriteLine($"Сумма {x} и {y} равна {sum}\nРазность {x} и {y} равна {raz}\nПроизведение {x} и {y} равно {pro}\nЧастное от деления {x} на {y} равно {chas}"); return;
                }
            task_2_18:
                {
                    //2.18. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.
                    Console.WriteLine("Условие задачи:\nДаны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputA:
                    Console.Write("Введите длину стороны \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputB:
                        Console.Write("Введите длину стороны \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > 0)
                        {
                        imputH:
                            Console.Write("Введите длину стороны \"h\": ");
                            double h = Convert.ToDouble(Console.ReadLine());
                            if (h > 0)
                            {
                                double V = a * b * h;
                                double S = 2 * h * (a + b);
                                Console.WriteLine($"Объём прямоугольного параллелепипеда равен: {V}\nПлощадь боковой поверхности прямоугольного параллелепипеда равна: {S}");
                                return;
                            }
                            Console.WriteLine("Введено неверное значение");
                            goto imputH;
                        }
                        Console.WriteLine("Введено неверное значение");
                        goto imputB;
                    }
                    Console.WriteLine("Введено неверное значение");
                    goto imputA;
                }
            task_2_19:
                {
                    //2.17. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
                    Console.WriteLine("Условие задачи:\nИзвестны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите координаты абсцисс (х) точки A: ");
                    double xA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) точки A: ");
                    double yA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты абсцисс (х) точки B: ");
                    double xB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) точки B: ");
                    double yB = Convert.ToDouble(Console.ReadLine());
                    double d = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
                    Console.WriteLine($"Расстояние между точками A ({xA}, {yA}) и B ({xB}, {yB}) равняется: {d.ToString("#.##")}"); return;
                }
            task_2_20:
                {
                    //2.20. Даны основания и высота равнобедренной трапеции. Найти периметр трапеции.
                    Console.WriteLine("Условие задачи:\nДаны основания и высота равнобедренной трапеции. Найти периметр трапеции.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputA:
                    Console.Write("Введите основание \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputB:
                        Console.Write("Введите основание \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > 0)
                        {
                        imputH:
                            Console.Write("Введите высоту \"h\": ");
                            double h = Convert.ToDouble(Console.ReadLine());
                            if (h > 0)
                            {
                                double P = a + b + 2 * Math.Sqrt(Math.Pow(h, 2) + Math.Pow((a - b), 2) / 4);
                                Console.WriteLine("Периметр равнобедренной трапеции равен: " + P.ToString("#.##"));
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Введено неверное значение.");
                                goto imputH;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введено неверное значение.");
                            goto imputB;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение.");
                        goto imputA;
                    }
                }
            task_2_21:
                {
                    //2.21. Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.
                    Console.WriteLine("Условие задачи:\nДаны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputA:
                    Console.Write("Введите меньшее основание \"a\": ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a > 0)
                    {
                    imputB:
                        Console.Write("Введите большее основание \"b\": ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b > a)
                        {
                        imputTG:
                            Console.Write("Введите угол \"tg\": ");
                            double tgInGradus = Convert.ToDouble(Console.ReadLine());
                            double tgInRadians = tgInGradus * (Math.PI / 180); //Переводим градусы в радианы
                            if (tgInRadians > 0)
                            {
                                double S = ((Math.Pow(b, 2) - Math.Pow(a, 2)) * Math.Tan(tgInRadians)) / 4;
                                Console.WriteLine("Площадь равнобедренной трапеции равена: " + S.ToString("#.##"));
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Введено неверное значение.");
                                goto imputTG;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введено неверное значение.");
                            goto imputB;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение.");
                        goto imputA;
                    }
                }
            task_2_22:
                {
                    //2.22. Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
                    Console.WriteLine("Условие задачи:\nТреугольник задан координатами своих вершин. Найти периметр и площадь треугольника.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.WriteLine("1)Определение координат вершины A.");
                    Console.Write("Введите координаты абсцисс (х) вершины A: ");
                    double xA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины A: ");
                    double yA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2)Определение координат вершины B.");
                    Console.Write("Введите координаты абсцисс (х) вершины B: ");
                    double xB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины B: ");
                    double yB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("3)Определение координат вершины С.");
                    Console.Write("Введите координаты абсцисс (х) вершины С: ");
                    double xC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины С: ");
                    double yC = Convert.ToDouble(Console.ReadLine());
                    //Считаем длину
                    double AB = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
                    double BC = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));
                    double CA = Math.Sqrt(Math.Pow((xA - xC), 2) + Math.Pow((yA - yC), 2));
                    //Считаем площадь и периметр
                    double P = AB + BC + CA;
                    double p = P / 2;
                    double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
                    Console.WriteLine($"Задан треугольник ABC по координатам A({xA}; {yA}) B({xB}; {yB}) C({xC}; {yC})\n" +
                    $"Периметр треугольника ABC равен: {P.ToString("#.##")}\nПлощадь треугольника ABC равна: {S.ToString("#.##")}"); return;
                }
            task_2_23:
                {
                    //2.23. Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.
                    Console.WriteLine("Условие задачи:\nВыпуклый четырехугольник задан координатами своих вершин.\nНайти площадь этого четырехугольника как сумму площадей треугольников.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.WriteLine("1)Определение координат вершины A.");
                    Console.Write("Введите координаты абсцисс (х) вершины A: ");
                    double xA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины A: ");
                    double yA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("2)Определение координат вершины B.");
                    Console.Write("Введите координаты абсцисс (х) вершины B: ");
                    double xB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины B: ");
                    double yB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("3)Определение координат вершины С.");
                    Console.Write("Введите координаты абсцисс (х) вершины С: ");
                    double xC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины С: ");
                    double yC = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("4)Определение координат вершины D.");
                    Console.Write("Введите координаты абсцисс (х) вершины D: ");
                    double xD = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координаты ординат (y) вершины D: ");
                    double yD = Convert.ToDouble(Console.ReadLine());
                    //Считаем длину отрезков
                    double AB = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
                    double BC = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));
                    double CD = Math.Sqrt(Math.Pow((xD - xC), 2) + Math.Pow((yD - yC), 2));
                    double DA = Math.Sqrt(Math.Pow((xA - xD), 2) + Math.Pow((yA - yD), 2));
                    //Считаем длины диагоналей
                    double AC = Math.Sqrt(Math.Pow((xC - xA), 2) + Math.Pow((yC - yA), 2));
                    double BD = Math.Sqrt(Math.Pow((xD - xB), 2) + Math.Pow((yD - yB), 2));
                    //Проверяем выпуклость прямоугольника, сумма длин диагоналей должна быть больше суммы длин противоположных сторон.
                    if (((AC + BD) > (AB + CD)) && ((AC + BD) > (BC + DA)))
                    {
                        //Считаем площадь треугольников
                        double abcP = AB + BC + AC;
                        double p1 = abcP / 2;
                        double abcS = Math.Sqrt(p1 * (p1 - AB) * (p1 - BC) * (p1 - AC));
                        double acdP = AC + CD + DA;
                        double p2 = acdP / 2;
                        double acdS = Math.Sqrt(p2 * (p2 - AC) * (p2 - CD) * (p2 - DA));
                        double abcdS = abcS + acdS;
                        Console.WriteLine($"Задан выпуклый четырехугольник ABCD по координатам A({xA}; {yA}) B({xB}; {yB}) C({xC}; {yC}) D({xD}; {yD})\n" +
                        $"Площадь четырехугольник ABCD равена: {abcdS.ToString("#.##")}");
                    }
                    else
                    {
                        Console.WriteLine($"Задан четырехугольник ABCD по координатам A({xA}; {yA}) B({xB}; {yB}) C({xC}; {yC}) D({xD}; {yD})\n" +
                        $"Данный четырехугольник не является выпуклым");
                    }
                }
            task_2_24:
                {
                    //2.24. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
                    Console.WriteLine("Условие задачи:\nИзвестна стоимость 1 кг конфет, печенья и яблок.\nНайти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputCostCandies:
                    Console.Write("Введите стоимость 1 кг конфет, руб: ");
                    double costCandies = Convert.ToDouble(Console.ReadLine());
                    while (!(costCandies >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputCostCandies;
                    }
                imputMassCandies:
                    Console.Write("Введите вес конфет, кг: ");
                    double massCandies = Convert.ToDouble(Console.ReadLine());
                    while (!(massCandies >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputMassCandies;
                    }
                imputCostСookies:
                    Console.Write("Введите стоимость 1 кг печенья, руб: ");
                    double costСookies = Convert.ToDouble(Console.ReadLine());
                    while (!(costСookies >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputCostСookies;
                    }
                imputMassСookies:
                    Console.Write("Введите вес печенья, кг: ");
                    double massСookies = Convert.ToDouble(Console.ReadLine());
                    while (!(massСookies >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputMassСookies;
                    }
                imputCostApples:
                    Console.Write("Введите стоимость 1 кг яблок, руб: ");
                    double costApples = Convert.ToDouble(Console.ReadLine());
                    while (!(costApples >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputCostApples;
                    }
                imputMassApples:
                    Console.Write("Введите вес яблок, кг: ");
                    double massApples = Convert.ToDouble(Console.ReadLine());
                    while (!(massApples >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputMassApples;
                    }
                    double Cost = massCandies * costCandies + costСookies * massСookies + massApples * costApples;
                    Console.WriteLine("Стоимость всей покупки равна: " + Cost.ToString("#.##") + " руб.");
                    return;
                }
            task_2_25:
                {
                    //2.25. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
                    Console.WriteLine("Условие задачи:\nИзвестна стоимость монитора, системного блока, клавиатуры и мыши.\nСколько будут стоить 3 компьютера из этих элементов? N компьютеров?");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                imputMonitorCost:
                    Console.Write("Введите стоимость монитора, руб: ");
                    double monitorCost = Convert.ToDouble(Console.ReadLine());
                    while (!(monitorCost >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputMonitorCost;
                    }
                imputSystemUnit:
                    Console.Write("Введите стоимость системного блока, руб: ");
                    double systemUnitCost = Convert.ToDouble(Console.ReadLine());
                    while (!(systemUnitCost >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputSystemUnit;
                    }
                imputKeyboardCost:
                    Console.Write("Введите стоимость клавиатуры, руб: ");
                    double keyboardCost = Convert.ToDouble(Console.ReadLine());
                    while (!(keyboardCost >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputKeyboardCost;
                    }
                imputMouseCost:
                    Console.Write("Введите стоимость компьютерной мыши, руб: ");
                    double mouseCost = Convert.ToDouble(Console.ReadLine());
                    while (!(mouseCost >= 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputMouseCost;
                    }
                    double computerCost = monitorCost + systemUnitCost + keyboardCost + mouseCost;
                imputComputerValue:
                    Console.WriteLine("Сколько компьютеров нужно купить?");
                    int computerValue = Convert.ToInt32(Console.ReadLine());
                    while (!(computerValue > 0))
                    {
                        Console.WriteLine("Введено неверное значение");
                        goto imputComputerValue;
                    }
                    double totalCost = computerCost * computerValue;
                    Console.WriteLine($"Стоимость компьютеров равна {totalCost.ToString("#.##")} руб.");
                    return;
                }
            task_2_26:
                {
                    //2.26. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.
                    Console.WriteLine("Условие задачи:\nВозраст Тани — X лет, а возраст Мити — Y лет.\nНайти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите имя первого человека: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Введите возраст первого человека: ");
                    uint age1 = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Введите имя второго человека: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Введите возраст второго человека: ");
                    uint age2 = Convert.ToUInt32(Console.ReadLine());
                    double middleAge = (age1 + age2) / 2;
                    Console.WriteLine($"Средний возраст людей {middleAge} лет.");
                    double differenceAge1 = middleAge - age1;
                    double differenceAge2 = middleAge - age2;
                    if (differenceAge1.ToString()[0] == '-')
                    {
                        string yearsOld1 = differenceAge1.ToString().Substring(1) + " лет " + "старше";
                        Console.WriteLine($"{name1} на {yearsOld1} среднего возраста.");
                    }
                    else
                    {
                        string yearsOld1 = differenceAge1.ToString() + " лет " + "младше";
                        Console.WriteLine($"{name1} на {yearsOld1} среднего возраста.");
                    }
                    if (differenceAge2.ToString()[0] == '-')
                    {
                        string yearsOld2 = differenceAge2.ToString().Substring(1) + " лет " + "старше";
                        Console.WriteLine($"{name2} на {yearsOld2} среднего возраста.");
                    }
                    else
                    {
                        string yearsOld2 = differenceAge2.ToString() + " лет " + "младше";
                        Console.WriteLine($"{name2} на {yearsOld2} среднего возраста.");
                    }
                    return;
                }
            task_2_27:
                {
                    //2.27. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и V2 км/час.
                    //Определить, через какое время автомобили встретятся, если расстояние между ними было S км.
                    Console.WriteLine("Условие задачи:\nДва автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час.\nОпределить, через какое время автомобили встретятся, если расстояние между ними было S км.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите скорость первого автомобиля (V1 км/час): ");
                V1:
                    double V1 = Convert.ToDouble(Console.ReadLine());
                    while (!(V1 >= 0))
                    {
                        Console.WriteLine("Введено неверное значение. Автомодиль движется навстречу другому.");
                        goto V1;
                    }
                V2:
                    Console.Write("Введите скорость второго автомобиля (V2 км/час): ");
                    double V2 = Convert.ToDouble(Console.ReadLine());
                    while (!(V2 >= 0))
                    {
                        Console.WriteLine("Введено неверное значение. Автомодиль движется навстречу другому.");
                        goto V2;
                    }
                S:
                    Console.Write("Введите расстояние между автомобилями (S км): ");
                    double S = Convert.ToDouble(Console.ReadLine());
                    while (!(S >= 0))
                    {
                        Console.WriteLine("Введено неверное расстояние");
                        goto S;
                    }
                    double T = S / (V1 + V2);
                    int Hours = (int)T;
                    string intro = $"При скорости первой машивы {V1} км/ч и второй машины {V2} км/ч, при начальном расстоянии {S} между ними, они встретятся через ";
                    double Minutes = (T - Hours) * 60;
                    if (Hours == 0)
                    {
                        string Time = $"{(int)Minutes} мин.";
                        Console.WriteLine(intro + Time);
                    }
                    else
                    {
                        string Time = $"{Hours} ч. {(int)Minutes} мин.";
                        Console.WriteLine(intro + Time);
                    }
                    return;
                }
            task_2_28:
                {
                    //2.28. Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2).
                    //Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.
                    Console.WriteLine("Условие задачи:\nДва автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2).\nКакое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                inputV:
                    Console.Write("Скорость первого автомобиля, км/ч: ");
                    double V1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Скорость второго автомобиля, км/ч: ");
                    double V2 = Convert.ToDouble(Console.ReadLine());
                    while (!(V1 > V2))
                    {
                        Console.WriteLine("Введено неправильное значение. Скорость первого автомобиля должна быть больше второго");
                        goto inputV;
                    }
                    double V = V1 - V2;
                    double S = V * 0.5;
                    Console.WriteLine($"Через 30 минут расстояние между машинами будет {S} км");
                }
            task_2_29:
                {
                    //2.29. Известно значение температуры по шкале Цельсия.
                    //Найти соответствующее  значение температуры по шкале: а) Фаренгейта; б) Кельвина.
                    //Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32,
                    //а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.
                    Console.WriteLine("Условие задачи:\nИзвестно значение температуры по шкале Цельсия. Найти соответствующее значение температуры по шкале:\nа) Фаренгейта;\nб) Кельвина.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите значерие температуры по шкале Цельсия: ");
                    double cT = Convert.ToDouble(Console.ReadLine());
                    double fT = cT * 1.8 + 32;
                    double kT = cT + 273.15;
                    Console.WriteLine($"{cT} градусов по шкале Цельсия соответствуют:\nа) {fT} градусам по шкале Фаренгейта\nб) {kT} по шкале Кельвина.");
                }
            task_2_30:
                {
                    //2.30. У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов  по Фаренгейту».
                    //Какой температуре по шкале Цельсия соответствует указанное в названии значение?
                    Console.WriteLine("Условие задачи:\nУ американского писателя-фантаста Рэя Бредбери есть роман \"450 градусов  по Фаренгейту\".\nКакой температуре по шкале Цельсия соответствует указанное в названии значение?");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    double cF = 450;
                    double cT = (cF - 32) / 1.8;
                    Console.WriteLine($"Ответ: 450 градусов  по Фаренгейту соответствуют {(int)cT} градусам по шкале Цельсия.");
                }
            }
        paragraph_3:
            {
                Console.WriteLine("Часто используемые эффективные алгоритмы (5 задач)" +
                    "\n" +
                    "\n1) Составить программу обмена значениями двух переменных величин." +
                    "\n2) Cоставить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:" +
                    "\n а) b присвоить значение c, а присвоить значение b, с присвоить значение а;" +
                    "\n б) b присвоить значение а, с присвоить значение b, а присвоить значение с." +
                    "\n3) Дано вещественное число а. Пользуясь только операцией умножения, получить:" +
                    "\n а) a^4 за две операции;\n б) a^6 за три операции;\n в) a^7 за четыре операции;\n г) a^8 за три операции;\n д) a^9 за четыре операции;\n е) a^10 за четыре операции." +
                    "\n4) Дано вещественное число a. Пользуясь только операцией умножения, получить:" +
                    "\n а) a^3 и a^10 за четыре операции;\n б) a^4 и a^20 за пять операций;\n в) a^5 и a^13 за пять операций;\n г) a^5 и a^19 за пять операций;\n д) a^2, a^5 и a^17 за шесть операций;\n е) a^4, a^12 и a^28 за шесть операций." +
                    "\n5) Чему будет равно 10^10 по Вашему алгоритму?" +
                    "\n" + new string('*', Console.WindowWidth) +
                    "\nВведите номер задачи (1-5): ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (taskNumber)
                {
                    case 1: goto task_3_1;
                    case 2: goto task_3_2;
                    case 3: goto task_3_3;
                    case 4: goto task_3_4;
                    case 5: goto task_3_5;
                }
            task_3_1:
                {
                    //3.1 Составить программу обмена значениями двух переменных величин.
                    Console.WriteLine("Условие задачи:\nСоставить программу обмена значениями двух переменных величин.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите величину a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите величину b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    double temp = a;
                    a = b;
                    b = temp;
                    Console.WriteLine($"Первое число {a}, второе {b}."); return;
                }
            task_3_2:
                {
                    //3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам.
                    //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
                    //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
                    Console.WriteLine("Условие задачи:\nCоставить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:\n а) b присвоить значение c, а присвоить значение b, с присвоить значение а;\n б) b присвоить значение а, с присвоить значение b, а присвоить значение с.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите величину a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите величину b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите величину c: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double copyA = a; double copyB = b; double copyC = c;
                    {
                        double temp = a;
                        a = b;
                        b = c;
                        c = temp;
                        Console.WriteLine($"а) Первое значение B: {b}, второе значение A {a}, третье значение С {c}:");
                    }
                    a = copyA; b = copyB; c = copyC;
                    {
                        double temp = a;
                        a = c;
                        c = b;
                        b = temp;
                        Console.WriteLine($"б) Первое значение B: {b}, второе значение C: {c}, третье значение A: {a}");
                    }
                    return;
                }
            task_3_3:
                {
                    //3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
                    //а) a4 за две операции;
                    //б) a6  за три операции;
                    //в) a7 за четыре операции;
                    //г) a8  за три операции;
                    //д) a9 за четыре операции;
                    //е) a10  за четыре операции.            
                    Console.WriteLine("Условие задачи:\nДано вещественное число а. Пользуясь только операцией умножения, получить:" +
                        "\n а) a^4 за две операции;\n б) a^6 за три операции;\n в) a^7 за четыре операции;\n г) a^8 за три операции;\n д) a^9 за четыре операции;\n е) a^10 за четыре операции.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double a2 = a * a;
                    double a4 = a2 * a2;
                    Console.WriteLine($"Ответ: a^4 = {a4}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    double a6 = a4 * a2;
                    Console.WriteLine($"Ответ: a^6 = {a6}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a6 = a4 * a2;
                    double a7 = a6 * a;
                    Console.WriteLine($"Ответ: a^7 = {a7}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    double a8 = a4 * a4;
                    Console.WriteLine($"Ответ: a^8 = {a8}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a8 = a4 * a4;
                    double a9 = a8 * a;
                    Console.WriteLine($"Ответ: a^9 = {a9}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a8 = a4 * a4;
                    double a10 = a8 * a2;
                    Console.WriteLine($"Ответ: a^10 = {a10}");
                    return;
                }
            task_3_4:
                {
                    //3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:
                    //а) a3 и a10 за четыре операции;
                    //б) a4 и a20 за пять операций;
                    //в) a5 и a13 за пять операций;
                    //г) a5 и a19 за пять операций;
                    //д) a2, a5 и a17 за шесть операций;
                    //е) a4, a12 и a28 за шесть операций.
                    Console.WriteLine("Условие задачи:\nДано вещественное число a. Пользуясь только операцией умножения, получить:" +
                        "\n а) a^3 и a^10 за четыре операции;\n б) a^4 и a^20 за пять операций;\n в) a^5 и a^13 за пять операций;\n г) a^5 и a^19 за пять операций;\n д) a^2, a^5 и a^17 за шесть операций;\n е) a^4, a^12 и a^28 за шесть операций.");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    Console.Write("Введите число a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double a2 = a * a;
                    double a3 = a2 * a;
                    double a5 = a3 * a2;
                    double a10 = a5 * a5;
                    Console.WriteLine($"Ответ: a^3 = {a3}, a^10 = {a10}");
                    //double a2 = a * a;
                    double a4 = a2 * a2;
                    double a8 = a4 * a4;
                    double a16 = a8 * a8;
                    double a20 = a16 * a4;
                    Console.WriteLine($"Ответ: a^4 = {a4}, a^20 = {a20}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a5 = a4 * a;
                    double a9 = a5 * a4;
                    double a13 = a9 * a4;
                    Console.WriteLine($"Ответ: a^5 = {a5}, a^13 = {a13}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a5 = a4 * a;
                    //double a10 = a5 * a5;
                    double a15 = a10 * a5;
                    double a19 = a15 * a4;
                    Console.WriteLine($"Ответ: a^5 = {a5}, a^19 = {a19} (Невозможно получить за 5 операций)");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a5 = a4 * a;
                    //double a10 = a5 * a5;
                    //double a15 = a10 * a5;
                    double a17 = a15 * a2;
                    Console.WriteLine($"Ответ: a^2 = {a2}, a^5 = {a5}, a^17 ={a17}");
                    //double a2 = a * a;
                    //double a4 = a2 * a2;
                    //double a8 = a4 * a4;
                    double a12 = a8 * a4;
                    double a24 = a12 * a12;
                    double a28 = a24 * a4;
                    Console.WriteLine($"Ответ: a^4 = {a4}, a^12 = {a12}, a^28 ={a28}");
                    return;
                }
            task_3_5:
                {
                    Console.WriteLine("Условие задачи:\nЧему будет равно 10^10 по Вашему алгоритму?");
                    Console.WriteLine(new string('*', Console.WindowWidth));
                    long a = 10;
                    long a5 = a * a * a * a * a;
                    long a10 = a5 * a5;
                    Console.WriteLine($"10^10 = {a10}"); return;
                }
            }
        }
    }
}





