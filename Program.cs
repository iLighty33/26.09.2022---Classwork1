using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _26._09._2022___Classwork1
{
    public class SomeClass
    {
        //static private int counter; //static - сущность, которая принадлежит классу
        //public SomeClass()
        //{
        //    counter++;
        //    Console.WriteLine("Присвоен номер {0}", counter);
        //}
        //public void SomeMethod(in string first, string _text = "123", params string []_arr) // params - способ передать кол-во элементов
        //{
        //    int d = 1;
            //first++;
            //Console.WriteLine(_text + first);
            //return d;
        }
}
internal class Program
{
    //static void WhatTheType()
    //{

    //}

    static void Main(string[] args)
    {
        //int a = 0;
        //short b = 0;
        //var c = 3.14;
        //int[] Arr = new int[] {1, 2, 3, 5, 7, 9};
        //for (int i = 0; i < Arr.Length; i++)
        //{
        //    Console.Write(" " + Arr[i]);
        //}
        //Console.WriteLine();
        //Console.WriteLine("Переменная {0} - {1}", c, c.GetType());
        //var _one = new SomeClass();
        //var _two = new SomeClass();
        //_two.SomeMethod();
        //var _three = new SomeClass();
        //_three.SomeMethod("Привет!");
        //Console.ReadKey();

        //try
        //{
        //    Console.WriteLine(args[0]);
        //}
        //catch (Exception e)
        //{

        //    Console.WriteLine("Нет аргументов {0}", e.Message);
        //    //throw;
        //}
        //finally
        //{
        //    Console.WriteLine("Этот код выполнится в любом случае...");
        //}

        //for (int i = 0; i < args.Length; i++)
        //{
        //    Console.WriteLine();
        //}
        //Regex regex = new Regex(@"[-]*\d*");
        //Console.WriteLine("Введите строку с числами");
        //MatchCollection matches = regex.Matches(Console.ReadLine());
        //foreach (var item in matches)
        //{
        //    if (item.ToString().Length != 0)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        string _path = "myFile.txt";
        //Console.WriteLine(Environment.SpecialFolder.MyDocuments);
        _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + _path;
        
        StreamWriter output = new StreamWriter(_path, true);
        output.WriteLine("Путь к файлу - " + _path);
        output.Close();

        var input = new StreamReader(_path);
        string _tmp;
        while((_tmp = input.ReadLine()) != null)
        {
            Console.WriteLine(_tmp);
        }


        input.Close();
        Console.ReadKey();
    }
}


