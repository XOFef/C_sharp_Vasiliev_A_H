using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
class Dialog
{
    static void Main()
    {



        // Глава 2

        // Задание 1
        int number;
        number = Int32.Parse(Interaction.InputBox(
              "Введите число: ",
              "Число"
            )
            );
        if (number % 3 == 0 && number % 7 == 0)
        {
            MessageBox.Show(
                "Число делится на 3 и 7!",
                "Проверка"
                );
        }
        else
        {
            MessageBox.Show(
                 "Число не делится на 3 и 7!",
                "Проверка"
                );
        }


        // Задание 2
        int num1, num2;
        for (; ; )
        {
            try
            {
                num1 = Int32.Parse(Interaction.InputBox(
                    "Введите первое число: ",
                    "Число"
                    ));
                num2 = Int32.Parse(Interaction.InputBox(
                   "Введите второе число: ",
                   "Число"
                   ));
                break;
            }
            catch
            {
                MessageBox.Show(
                    "Ошибка! Вы ввели не число",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        if (num1 > num2)
            MessageBox.Show("Первое число больше второго!", "Сравнение");
        else if (num1 == num2)
            MessageBox.Show("Первое число равно второму!", "Сравнение");
        else
            MessageBox.Show("Первое число меньше второго!", "Сравнение");


        // Задание 3
        int num1, num2, res = 0;
        for (; ; )
        {
            try
            {
                num1 = Int32.Parse(Interaction.InputBox(
                    "Введите число: ",
                    "Число"
                    ));
                if (num1 == 0) break;
                num2 = Int32.Parse(Interaction.InputBox(
                   "Введите число: ",
                   "Число"
                   ));
                if (num2 == 0) break;
                res += num1 + num2;
                MessageBox.Show($"Сумма равна: {res}", "Сумма");
            }
            catch
            {
                MessageBox.Show(
                    "Ошибка! Вы ввели не число",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }


        // Задание 4
        int num1, num2, res = 0;
        string txt;
        try
        {
            num1 = Int32.Parse(Interaction.InputBox(
                "Введите число: ",
                "Число"
                ));
            switch (num1)
            {
                case 1:
                    txt = "Понедельник";
                    break;
                case 2:
                    txt = "Вторник";
                    break;
                case 3:
                    txt = "Среда";
                    break;
                case 4:
                    txt = "Четверг";
                    break;
                case 5:
                    txt = "Пятница";
                    break;
                case 6:
                    txt = "Суббота";
                    break;
                case 7:
                    txt = "Воскресенье";
                    break;
                default:
                    txt = "Число больше 7";
                    break;
            }
            MessageBox.Show($"Сегодня: {txt}", "День недели");
        }
        catch
        {
            MessageBox.Show(
                "Ошибка! Вы ввели не число",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }


        // Задание 5
        txt = Interaction.InputBox(
                    "Введите число: ",
                    "Число"
                    );

        switch (txt.ToLower())
        {
            case "понедельник":
                txt = "1";
                break;
            case "вторник":
                txt = "2";
                break;
            case "среда":
                txt = "3";
                break;
            case "четверг":
                txt = "4";
                break;
            case "пятница":
                txt = "5";
                break;
            case "суббота":
                txt = "6";
                break;
            case "воскресенье":
                txt = "7";
                break;
            default:
                txt = "Такого дня не существует";
                break;
        }
        MessageBox.Show($"Порядковый номер дня: {txt}", "День недели");


        // Задание 6
        int n, sum = 0, num = 2;
        Console.WriteLine("Введите количество циклов для суммы: ");
        n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            sum += num;
            num += 2;
        }
        Console.WriteLine(sum);


        // Задание 7
        int n, sum = 0, num = 1;
        Console.WriteLine("Введите количество циклов для суммы: ");
        n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            sum += num;
            num += 1;
            num *= num;
        }
        Console.WriteLine(sum);



        // Задание 8
        int res, cyc, num1 = 1, num2 = 1;
        Console.WriteLine("Введите количество выводимых чисел: ");
        cyc = Int32.Parse(Console.ReadLine());
        while (cyc > 0)
        {

            res = num1 + num2;
            Console.WriteLine(res);
            num2++;
            cyc--;
            while (cyc > 0)
            {
                res = num1 + num2;
                Console.WriteLine(res);
                num1 = num2;
                num2 = res;
                cyc--;
            }
        }


        // Задание 9
        int num1, num2, number;
        try
        {
            Console.WriteLine("Введите первое число: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Int32.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                number = num2;
                for (; num2 <= num1; num2++)
                {
                    Console.WriteLine(number);
                    number++;
                }
            }
            else
            {
                number = num1;
                for (; num1 <= num2; num1++)
                {
                    Console.WriteLine(number);
                    number++;
                }
            }
        }
        catch
        {
            Console.WriteLine("Вы ввели не число!");
        }







































    }

}