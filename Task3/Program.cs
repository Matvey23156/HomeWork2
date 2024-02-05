// Напишите программу, которая принимает
// на вход целое число из отрезка [10,99] 
// и показывает наибольшую цифру числа


Console.Write("Введите число из отрезка [10, 99] и нажмите клавишу Enter: "); 
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 10;
int secondNumber = number % 10;
int max = 0;

if (firstNumber > secondNumber)
{
    max = firstNumber;
}
else
{
    max = secondNumber;
}
Console.WriteLine(max);