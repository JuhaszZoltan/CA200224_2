using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CA200224_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Chi>();
            var sr = new StreamReader(@"..\..\res\chi.txt");
            while (!sr.EndOfStream)
                list.Add(new Chi(sr.ReadLine()));
            sr.Close();

            //2.f
            Console.WriteLine(list.Count);

            //3.f
            Console.WriteLine(
                list.Count(c => c.Simi == true) 
                / (float)list.Count * 100);
            
            //4.f
            var ch = list
                .Where(c => c.Suly < 360 && c.Kor >= 8)
                .SingleOrDefault();
            Console.WriteLine(
                ch is null 
                ? "nincs" 
                : $"Név: {ch.Nev}, kor: {ch.Kor}, súly: {ch.Suly}");
            
            //5.f
            list.OrderByDescending(c => c.Suly)
                .Take(5)
                .ToList()
                .ForEach(y => Console.WriteLine(
                    "{0, -13} {1} gramm",
                    y.Nev + ":", y.Suly));
            //6.f
            var t = list
                .GroupBy(y => y.Szul.Year, y => y.Nev);
            foreach (var e in t)
                Console.WriteLine($"{e.Key} {e.Count()}");

            Console.ReadKey();
        }
    }
}
