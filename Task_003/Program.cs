// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Write("Введите двузначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    
    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine(secondNumber);
    }
    else
    {
        Console.WriteLine("Первая и вторая цифры числа равны!");
    }
}
else
{
    Console.WriteLine("Вы ввели не двузначное число!");
}

