using System;
class HelloWorld {
  static void Main() {
Console.WriteLine("Сколько элементов массива вы собираетесь ввести?");
int n;
n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите элементы массива:");
string [] mas = new string[n];
string [] new_mas = new string[n];
for (int i=0;i<n;i++)
{
    mas[i] = Console.ReadLine();
    
}
int j = 0;
for (int i=0;i<n;i++)
{
    if (mas[i].Length < 4)
    {
        new_mas[j] = mas[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine("Новый сформированный массив");
Console.WriteLine();
for (int i=0;i<j;i++)
Console.WriteLine(new_mas[i]);
  }
}