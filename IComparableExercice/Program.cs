using System;
using System.IO;
using System.Collections.Generic;

string path = @"C:\Users\lucas\Desktop\C#\Exercices\in.txt";
try {
    using (StreamReader sr = File.OpenText(path)) {
        List<string> list = new List<string>();
        while (!sr.EndOfStream) {
            list.Add(sr.ReadLine());
        }
        list.Sort();
        foreach (string str in list) {
            Console.WriteLine(str);
        }
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}