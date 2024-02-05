// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.Write("Введите число и нажмите клавишу Enter  ");
string firstString = Console.ReadLine();
int firstArg = Convert.ToInt32(firstString);

if (firstArg%7 == 0 && firstArg%23 == 0)
{
    System.Console.WriteLine($"число {firstArg} кратное числу 7 и 23");
}
else
{
    System.Console.WriteLine($"число {firstArg} НЕ КРАТНОЕ числу 7 и 23");
}
