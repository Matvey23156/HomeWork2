// Напишите программу, которая принимает на вход координаты (X и Y),
// причем X Y не равны 0 и выдает номер координатной четверти плоскости, 
// в которой находится эта точка


Console.Write("Введите координату X и нажмите клавишу Enter: ");
string firstString = Console.ReadLine();
int X = Convert.ToInt32(firstString);
Console.Write("Введите координату Y и нажмите клавишу Enter: ");
string secondString = Console.ReadLine();
int Y = Convert.ToInt32(secondString);

if (X > 0 && Y > 0)
{
    System.Console.WriteLine("1 четверть координатной плоскости");
}
else if (X < 0 && Y > 0)
{
    System.Console.WriteLine("2 четверть координатной плоскости");
}
else if (X < 0 && Y < 0)
{
    System.Console.WriteLine("3 четверть координатной плоскости");
}
else  if (X > 0 && Y < 0)
{
    System.Console.WriteLine("4 четверть координатной плоскости");
}