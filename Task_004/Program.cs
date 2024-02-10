// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isFirstDigit = true;
string result_string = "";

if (number <= 0)
{
    Console.WriteLine("Натуральные числа не могут быть отрицательными и начинаются с 1!");
}
else
{
    // Если у числа один разряд
    if (number < 10)
    {
        result_string = $"{number}";
    }
    else 
    {
        while (number > 0)
        {
            // Если у числа более 1-го разряда и это первый остаток от деления
            if (number / 10 != 0 && isFirstDigit)
            {
                result_string = $"{number % 10}";
                isFirstDigit = false;
            }
            else
            {
                result_string = $"{number % 10}, " + result_string;
            }
            number /= 10;
        }
    }

    Console.WriteLine(result_string);
}





