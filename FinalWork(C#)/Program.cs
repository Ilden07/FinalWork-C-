/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться 
коллекциями,лучше обойтись исключительно массивами */

const int QUANTITY = 4;


int GetArraySizeFromUser()
{
    int size = 0;
    while(size < 1) 
    {
    try
        {   
            Console.Write("Укажите количество элементов в массиве: ");
            size = Convert.ToInt32(Console.ReadLine());

            if(size < 1) Console.WriteLine("Неверно указана длина массива, введите значение больше 1");
        }
    catch (System.FormatException)
        {
            Console.WriteLine("Введенное Вами значение не является числом, введите число"); 
        }
    }
     return size;
}

string[] CreateArray()
{
    int size = GetArraySizeFromUser();
    string[] newarray = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        string? text_array = Console.ReadLine();

        if(text_array == null) newarray[i] = string.Empty;
        else newarray[i] = text_array;
    }
    return newarray;
}
string[] LessThanFourArray(string[] newarray)
{
    string[] array_two = new string[newarray.Length];
    for(int i = 0; i < newarray.Length; i++)
    {
        if(newarray[i].Length < QUANTITY) array_two[i] = newarray[i];
    }
    return array_two;