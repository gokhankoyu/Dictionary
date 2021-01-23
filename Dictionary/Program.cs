using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //IDictionary<int, string> ogrenciler = new Dictionary<int, string>();

            //ogrenciler.Add(2, "Ali");
            //ogrenciler.Add(4, "Zehra");
            //ogrenciler.Add(6, "Sevgi");

            //foreach (KeyValuePair<int, string> ogrenci in ogrenciler)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", ogrenci.Key, ogrenci.Value);
            //}

            //Console.WriteLine(ogrenciler[4]);//ElementAt[] metodu. to get a KeyValuePair from the specified index.

            ////use ContainsKey() to check for an unknown key
            //if (ogrenciler.ContainsKey(8))
            //{
            //    Console.WriteLine(ogrenciler[8]);
            //}
               

            //Console.WriteLine("---------------------------------------------------------");

            //var cities = new Dictionary<string, string>() { {"A","ANK, BZY" }, {"B","BOLU, ÇORUM" } };

            //foreach (var city in cities)
            //    Console.WriteLine("Key:{0}, Value: {1}", city.Key, city.Value);
            
            
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            var sehirler = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
            };

            string result;
            if(sehirler.TryGetValue("France", out result))
                Console.WriteLine(result);

        }


    
    
    
    
    }   
}
