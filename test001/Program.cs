﻿Console.Clear();
Console.Write("Введите число эллементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
FillingArray(array);




void FillingArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        string letter=Console.ReadLine()??"";

        if(letter!="")
        {
            array[i] = letter;
        }
        else
        {
            Console.WriteLine ("Ошибка! Введите данные!");
            break;
        }
    }
}
