/* 
SORU 1
Console.Write("Pozitif Bir Tam Sayi Giriniz : ");
int sayi=int.Parse(Console.ReadLine());
int girilenSayi=0;
int toplam=0;
if(sayi>0){
	for(int i=0; i<sayi;i++){
		Console.Write("Pozitif Bir Tam Sayi Giriniz : ");
		girilenSayi=int.Parse(Console.ReadLine());
		if(girilenSayi%2==0)
			toplam+=girilenSayi;	
	}
	Console.WriteLine("Sonuc : " + toplam);

}

else{
Console.WriteLine("Pozitif Bir Tam Sayi girmediniz.");
} */
/*
SORU 2
Console.Write("Pozitif Iki Tam Sayi Giriniz : ");
int sayi=int.Parse(Console.ReadLine());
int sayi2=int.Parse(Console.ReadLine());
int girilenSayi=0;
	for(int i=0; i<sayi;i++){
		Console.Write("Pozitif Bir Tam Sayi Giriniz : ");
		girilenSayi=int.Parse(Console.ReadLine());
		if(girilenSayi%sayi2==0 || girilenSayi==sayi2)
			Console.WriteLine(girilenSayi);
	}
*/	
/* 
SORU 3
Console.Write("Pozitif Bir Tam Sayi Giriniz : ");
int sayi=int.Parse(Console.ReadLine());
string[] kelime= new string[sayi];
string girilenKelime="";
	for(int i=0; i<sayi;i++){
		Console.Write("Bir Kelime Giriniz : ");
		kelime[i]=Console.ReadLine();
		
	}
	Array.Reverse(kelime);
	foreach(var item in kelime)
		Console.WriteLine(item); */
/* 
SORU 4
Console.Write("Bir Cumle Giriniz: ");
string cumle=Console.ReadLine();
int harfSayisi = 0;

foreach (char karakter in cumle)
{
    if (Char.IsLetter(karakter))
    {
        harfSayisi++;
    }
}
string[] kelimeler = cumle.Split(" ");
Console.WriteLine("Kelime Sayisi : " + kelimeler.Length  + " Harf Sayisi : " + harfSayisi);
 */