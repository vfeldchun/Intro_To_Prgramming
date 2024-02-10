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
    while (true)
    {
        // Если у числа один разряд
        if (number / 10 == 0 && isFirstDigit)
        {
            result_string = $"{number % 10}";
            break;
        }
        
        // Если у числа более 1-го разряда и это первый остаток от деления
        if (number / 10 != 0 && isFirstDigit)
        {
            result_string = $"{number % 10}";
            isFirstDigit = false;
            number /= 10;
        }
        // Если у числа более 1-го разряда и это непервый остаток от деления
        else if (number / 10 != 0 && !isFirstDigit)
        {
            result_string = $"{number % 10}, " + result_string;
            number /= 10;
        }
        // если это последний остаток от деления в числе
        else 
        {
            result_string = $"{number % 10}, " + result_string;
            break;
        }
    }

    Console.WriteLine(result_string);
}





