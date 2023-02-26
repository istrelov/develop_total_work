//Из имеющегося массива строк сформировать массив из строк, длина которых меньше, либо равна 3 символа
//Первоначальынйй массив вводится с клавиатуры. При решении использовать только массивы

// --------------Начало программы ----------------------

string[] UserArray = GetUserArray("Введите нужные слова. Для завершения ввода нажмите Enter не вводя текст (строка должна быть пустой): ");

string[] ResArray = FindElementMoreLength(UserArray, 3);

PrintArray(UserArray);
Console.Write(" -> ");
PrintArray(ResArray);

//-----------------Описание методов --------------------

string[] GetUserArray(string Mess)
{

    Console.WriteLine(Mess);
    string[] resarray = new string[0];
    int i = 1;

    while (true)
    {
       
        Console.Write($"{i}е слово:");
        string userres = Convert.ToString(Console.ReadLine()!);

        if (userres == String.Empty) return resarray;
        
        Array.Resize(ref resarray, resarray.Length + 1);
        resarray[i - 1] = userres;
        i++;

    }

}

string[] FindElementMoreLength(string[] UserArray, int FindLength)
{

    string[] resarray = new string[0];
    int ResLength = 0;

    for (int i = 0; i < UserArray.Length; i++)
    {
        if(UserArray[i].Length <= FindLength)
        {
            Array.Resize(ref resarray, ResLength + 1);
            resarray[ResLength] = UserArray[i];
            ResLength++;
        }
    }  

    return resarray;

}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
     Console.Write("]");

}