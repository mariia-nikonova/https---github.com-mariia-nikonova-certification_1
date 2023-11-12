using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

Console.Write("Введите количесво элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] str_array(int s)          //заполнение массива вводом с консоли
{
    int i;
    string[] str1 = new string[s];
    for (i = 0; i < s; i++)
    {
        Console.Write($"Введите элемент массива [{i}]:  ");
        str1[i] = Console.ReadLine();
    }
    return str1;
}

/*void print_array (string[] array)//печать массива
{
    Console.WriteLine();
    int s=array.Length;
    Console.WriteLine("Исходный массив строк:");
    for (int i = 0; i < s; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}*/

List<string> slist(string[] array) //формирование нового массива с элементами нужной длинны
{
    List<string> str1 = new List<string> ();
    int s=array.Length;
    for (int i = 0; i < s; i++)
    {
        if ((array[i].Length)<=3) 
        {
            str1.Add(array[i]); 
        }
   }
    Console.WriteLine();
    int slist=str1.Count;
    for (int i = 0; i < slist; i++)
    {
        Console.Write($"{str1[i]}  ");
    }
    if (str1.Count==0) Console.Write($"Элементы нужной длинны в массиве отсутствуют");
    return str1;
}

string[] str = str_array(size);
//print_array(str);
slist(str);


