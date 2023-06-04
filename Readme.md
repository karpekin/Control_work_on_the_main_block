## Комментарий к коду

Сначала мы задаем одномерный фирсированный массив

    string[] array = new string[] {"Hello", "2-", "world", ":-)"};

Затем считаем количество строк внутри него с длинной <= 3

    array[i].Length <= 3

Дальше мы объявляем новый массив array2 и заполняем его короткими строчками из первого array

    array2[j] = array[i];

И в конце, используя метод **string.Join**, мы передаем массив array2 в массив array3 и распечатываем его.

    string array3 = "[" + string.Join(", ", array2) + "]";
    Console.WriteLine(array3);