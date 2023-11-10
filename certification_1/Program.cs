Console.Write("Введите количесво элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] str_array(int s)        //заполнение массива вводом с консоли
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

string[] str = str_array(size);
