// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void Print (string[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}   ");
    Console.WriteLine();
}
string[] MassString(int m)
{
    string[] arr = new string[m];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Console.ReadLine()!;
    return arr;
}


string[] Sort(string[] massrow)
{
    int z = 0;  
    int count = massrow.Length;  
    for (int i = 0; i < count; i++)
    {
        if (massrow[i].Length <= 3) z++;
    }

    string[] newmass  = new string [z];

    int m = 0;     
    for (int i = 0; i < count; i++)
    {
        if (massrow[i].Length <= 3 )
        {
            newmass[m] = massrow[i];
            m++;
        }
    }
    return newmass;
}
 
Console.WriteLine("Введите количество строк в массиве: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите данные массива строк: ");
string[] arrayString1 = MassString(num);
Console.WriteLine("Массив строк:  ");
Print(arrayString1);
Console.WriteLine("Массив строк 2:  ");
string[] arrayString2 = Sort(arrayString1);
Print(arrayString2);
