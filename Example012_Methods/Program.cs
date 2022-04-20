﻿// Разбираем методы

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
