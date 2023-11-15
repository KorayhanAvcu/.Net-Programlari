//while
//1 den başlayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp console a yazdiran program
Console.WriteLine("Bir sayi giriniz : ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam =0;
while (sayac<=sayi){
    toplam+=sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);

// a'dan z'ye kadar tüm harfleri console a yazdir
char character='a';
while (character<'z'){
    Console.WriteLine(character);
    character++;
}

//foreach
string[] arabalar={"BMW","AUDI","HONDA","TOYOTA"};
foreach (var item in arabalar)
{
    Console.WriteLine(item);
}