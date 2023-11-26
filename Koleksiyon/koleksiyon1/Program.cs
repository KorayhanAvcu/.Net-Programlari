using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList asal = new ArrayList();
        ArrayList asalOlmayan = new ArrayList();
        string sayi = "";
        int gelenSayi = 0;
        int i = 0;
        while (i < 20)
        {
            Console.Write("Sayi Giriniz: ");
            sayi = Console.ReadLine();
            if (int.TryParse(sayi, out int number))
            {
               
                if (number > 0)
                {
                    if (AsalMi(number))
                    {
                        asal.Add(number);
                    }
                    else
                    {
                        asalOlmayan.Add(number);
                    }
                    i++;
                }
                else
                    Console.WriteLine("Yanlis bir giris yaptiniz!");
            }
            else
                Console.WriteLine("Yanlis bir giris yaptiniz!");
        }
        Console.WriteLine("****Asal Sayilar****");
        asal.Sort();
        int asalToplam = 0;
        foreach (var item in asal)
        {
            Console.Write(item + " ");
            asalToplam += (int) item;
        }

        Console.WriteLine();
        Console.WriteLine("****Asal Olmayan Sayilar****");
        asalOlmayan.Sort();
        int asalOlmayanToplam = 0;
        foreach (var item in asalOlmayan)
        {
            Console.Write(item + " ");
            asalOlmayanToplam += (int)item;
        }

        Console.WriteLine("\nAsal Ortalama: " + ((double)asalToplam/asal.Count)  + " Eleman Sayisi : " + asal.Count) ;
         Console.WriteLine("\nAsalOlmayan Ortalama: " + ((double)asalOlmayanToplam/asalOlmayan.Count)  + " Eleman Sayisi : " + asalOlmayan.Count) ;
    }

    public static bool AsalMi(int sayi)
    {
        if (sayi < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}