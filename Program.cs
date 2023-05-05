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
if (n > 0)
{
    FillArray(array);
    PrintArray(array);
    PrintArray(NewMass(array));

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
string[] NewMass(string[] a1)
{
    int j = 0;
    int m;
    Console.WriteLine("С Каким максимальным количеством символов вывести строки?");
    int.TryParse(Console.ReadLine(), out m);
    for (int i = 0; i < a1.Length; i++)
        if (a1[i].Length <= m && a1[i].Length > 0)
        {
            j++;
        }
    string[] a2 = new string[j];
    int temp = 0;
    for (int i = 0; i < a1.Length; i++)

        if (a1[i].Length <= m && a1[i].Length > 0)
        {
            a2[temp] = a1[i];
            temp++;
        }

    return a2;

}
void PrintArray(string[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++)
        Console.Write($"“{a[i]}“, ");
    Console.Write($"“{a[a.Length - 1]}“]");
    Console.WriteLine();
}