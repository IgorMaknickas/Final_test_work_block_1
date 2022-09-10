Итоговая проверочная работа

# Задание

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Решение

+ <Блок схема>
   ![Блок схема](https://downloader.disk.yandex.ru/preview/6b8970d63f352da401f90e1c6bb23d07a4f1ed94fe7fa1bd20e3e7359a881b2f/631ccf2e/oF3zRwEvOxCodm0qeL8cE8ciMZFnfxLLGftTKGzpKtl20gOyU4XjJrwxa8tdsIegbCNVKlYF24HskqIN9eRQUg%3D%3D?uid=0&filename=2022-09-10_16-52-56.png&disposition=inline&hash=&limit=0&content_type=image%2Fpng&owner_uid=0&tknv=v2&size=2048x2048)

+ Решение задачи<br/>
Для решения щадачи использовал оператор foreach
```C#
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
```
