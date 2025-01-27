﻿using System;

namespace CustomDoublyLinkedList
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            DoublyLinkedList<string> listString = new();

            listString.AddFirst("some");
            listString.AddFirst("random");
            listString.AddFirst("string");

            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
        }
    }
}