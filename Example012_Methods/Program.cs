// Разбираем методы

// 1. Метод, который ничего не принимает и ничего не возвращает
    
    //void Method1()
    //{
    //    Console.WriteLine("Author Dmitriy Lushchik");
    //}
    //Method1();

//2. Метод, который ничего не возвращает, но принимает аргументы

    //void Method2(string msg)
    //{
    //    Console.WriteLine(msg);
    //}
    //Method2(msg: "Текст сообщения");

    //void Method21(string msg, int count)
    //{
    //    int i = 0;
    //    while(i < count)
    //    {
    //        Console.WriteLine(msg);
    //        i++;   
    //    }
    //}
    //Method21(msg: "Текст", count: 4);

//3. Метод, который что то возвращает, но ничего не принимает. Обязательно нужно указывать тип возвращаемого

    //int Method3()
    //{
    //    return DateTime.Now.Year;
    //}
    //int year = Method3();
    //Console.WriteLine(year);

//4. Метод, который что то принимает и что то возвращает. Обязательно нужно указывать тип возвращаемого

//    string Method4(int count, string text)
//    {
//        int i = 0;
//        string result = String.Empty;
//        while(i < count)
//        {
//            result = result + text;
//            i++;
//        }
//        return result;
//    }
//    string res = Method4(10, "z");
//    Console.WriteLine(res);

// Цикл For
    
//    string Method4(int count, string text)
//    {
//        string result = String.Empty;
//        for(int i = 0; i < count; i++)
//        {
//            result = result + text;
//        }
//        return result;
//    }
//    string res = Method4(10, "z");
//    Console.WriteLine(res);

// Цикл в цикле на примере таблицы умножения

//    for(int i = 2; i <= 10; i++)
//    {
//        for(int j = 2; j <= 10; j++)
//        {
//            Console.WriteLine($"{i} x {j} = {i*j}");
//        }
//        Console.WriteLine();
//    }

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить четрочками, маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

//string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//            + "ежели вас послали вместо нашего милого Винцингероде,"
//            + "вы бы взяли приступом согласие прусского короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";

//// string s = "qwerty"
//// s[3] // r

//string Replace(string text, char oldValue, char newValue)
//{
//    string result = String.Empty;
//    int length = text.Length;
//    for(int i = 0; i < length; i++)
//    {
//        if(text[i] == oldValue)
//        result = result + $"{newValue}";
//        else result = result + $"{text[i]}";
//
//    }
//    return result;
//}
//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'С', 'с');
//Console.WriteLine(newText);

//Метод сортировки массива Минмакс

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSortMinMax(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minposition = i;
            for(int j = i +1; j < array.Length; j++)
            {
                if(array[j] < array[minposition])  minposition = j;
            }
        int temporary = array[i];
        array[i] = array[minposition];
        array[minposition] = temporary;

    }
}
SelectionSortMinMax(arr);
PrintArray(arr);

void SelectionSortMaxMin(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxposition = i;
            for(int j = i +1; j < array.Length; j++)
            {
                if(array[j] > array[maxposition])  maxposition = j;
            }
        int temporary = array[i];
        array[i] = array[maxposition];
        array[maxposition] = temporary;

    }
}
SelectionSortMaxMin(arr);
PrintArray(arr);
