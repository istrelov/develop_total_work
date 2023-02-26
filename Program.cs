//Из имеющегося массива строк сформировать массив из строк, длина которых меньше, либо равна 3 символа
//Первоначальынйй массив вводится с клавиатуры. При решении использовать только массивы

// --------------Начало программы ----------------------

string[] UserArray = GetUserArray("Введите нужные слова. Для завершения ввода нажмите Enter не вводя текст (строка должна быть пустой): ");
Console.WriteLine($"{String.Join(", ", UserArray)}");

//-----------------Описание методов --------------------

string[] GetUserArray(string Mess)
{
 
    Console.WriteLine(Mess);
    string[] resarray = new string[5];  
    int i = 1;

    while(true)
    {
        Console.Write($"{i} е слово:");
        string userres = Console.ReadLine();

        if(userres == String.Empty) return resarray;

        if(resarray.Length == i)
        {
            Array.Resize(ref resarray, resarray.Length + 1);
        }

        resarray[i-1] = userres;
        i++;
    }

}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i, j, k]}({i},{j},{k}) "); 
            
    }

}