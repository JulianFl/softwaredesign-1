﻿using System;
using static System.Console;

public class SimplePerson
{
   public string FirstName;
   public string LastName;
   public DateTime DateOfBirth;
}

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person root = Familytree.BuildTree();

            Person found = Familytree.FindPersonByAge(root, 90, 100);

            WriteLine(found);
        }
    }
}