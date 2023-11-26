using System.Collections;

ArrayList sayilarDizisi = new ArrayList();

int i=0;
while(i<20){
    Console.WriteLine("Sayi giriniz : ");
    if(int.TryParse(Console.ReadLine(), out int number)){
        sayilarDizisi.Add(number);
        i++;
    }
}
sayilarDizisi.Sort();
ArrayList enkDizisi = new ArrayList(sayilarDizisi.GetRange(0, 3));
ArrayList enbDizisi = new ArrayList(sayilarDizisi.GetRange(sayilarDizisi.Count-3, 3));

foreach(var item in sayilarDizisi)
    Console.WriteLine(item + " ");

Console.WriteLine();
int enbToplam=0;
foreach(var item in enbDizisi){
    enbToplam+=(int)item;
    Console.WriteLine(item + " ");
}
    

Console.WriteLine();
int enkToplam=0;
foreach(var item in enkDizisi){
    enkToplam+=(int)item;
    Console.WriteLine(item + " ");
}
    

Console.WriteLine();

Console.WriteLine("Enb 3 Sayi Ortalamasi : {0}", ((double)enbToplam/enbDizisi.Count));
Console.WriteLine("Enk 3 Sayi Ortalamasi : {0}", ((double)enkToplam/enkDizisi.Count));