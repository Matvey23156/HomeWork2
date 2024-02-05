// Написать программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите любое натуральное число N: "); 
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
Console.Write($"{arr[i]} ");
i = i + 1;
}