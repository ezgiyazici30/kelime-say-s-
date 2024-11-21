using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Bir cümle girin:");
        string cumle = Console.ReadLine();

       
        string[] kelimeler = cumle.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        
        Console.WriteLine(string.Format("Cümledeki kelime sayısı: {0}", kelimeler.Length));
    }
}

