// Контрольная работа: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[] {"Hello", "2-", "world", ":-)"};

int l = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        l = l + 1;
    }
}

string[] array2 = new string[l];

FillArray(array);
PrintArray();

string[] FillArray(string[] array)
{
int j = 0;
for (int i = 0; i < array.Length; i++)
{
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j = j + 1;
        }
}
return array2;
}

void PrintArray()
{
    string array3 = "[" + string.Join(", ", array2) + "]";
Console.WriteLine(array3);

}
