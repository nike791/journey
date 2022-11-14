// Программа, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символам.

//запрос размерности и элементов массива у пользователя
string[] InitArray(int demension)
{
    string[] arr = new string[demension];
    for (int i = 0; i < demension; i++)
    {
        Console.WriteLine("Введите элемент массива");
        arr[i] = Console.ReadLine() ?? "";
    }
    return arr;
}

string[] ResultArray(int n, string[] array)
{
    string[] arr = new string[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            arr = arr.Concat(new string[] { array[i] }).ToArray();
    }
    return arr;
}


Console.WriteLine("Введите размерность массива");
int demension = int.Parse(Console.ReadLine() ?? "");
string[] arr = InitArray(demension);

var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

int n = 0;
string[] newArr = ResultArray(n, arr);

var newResult = string.Join(", ", newArr);
Console.WriteLine($"[{newResult}]");
