//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] a;
Console.WriteLine("Введите массив строк через пробел");
string array = Console.ReadLine();
a = array.Split(' ');

void GetArray(string[] a)
{
    var res = new string[a.Length];
    var rSize = 0;
    foreach (var elements in a)
    {
        if (elements.Length <= 3)
        {
            res[rSize] = elements;
            rSize++;
        }
    }
    Console.WriteLine();
    Console.WriteLine(string.Join(Environment.NewLine, res, 0, rSize));
}

GetArray(a);