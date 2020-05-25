﻿using System;

namespace CSharp_Advanced_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(book);

            // MS
            //System.Collections.Generic

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());
            
            //System.Nullable
            var number = new Nullable<int>();
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
