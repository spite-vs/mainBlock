/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


int n = 0;
Console.WriteLine("Введите количество проверяемых строк");
int.TryParse(Console.ReadLine(), out n);
string[] array = new string[n];
List<string> newArray = new List<string>();
if (n > 0)
{
    FillArray(array);
    PrintArray(array);
    NewMass(array, newArray);

    Console.Write("[ ");
    foreach (var i in newArray)
        Console.Write($"{i} ");
    Console.Write("]");
}
else
    Console.WriteLine("Некорректно введено");


void FillArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку:");
        a[i] = Console.ReadLine();
    }
}
void NewMass(string[] a1, List<string> a2)
{
    int m;
    Console.WriteLine("С Каким максимальным количеством символов вывести строки?");
    int.TryParse(Console.ReadLine(), out m);
    for (int i = 0; i < a1.Length; i++)
    {
        if (a1[i].Length <= m)
        {
            a2.Add(a1[i]);
        }
    }

}
void PrintArray(string[] a)
{
    Console.Write("[ ");
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.Write("]");
    Console.WriteLine();
}