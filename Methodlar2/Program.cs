﻿//out parametrelerei

string sayi="999";
int outSayi;
bool sonuc = int.TryParse(sayi,out outSayi); 
if(sonuc){
	Console.WriteLine("Basarili");
	Console.WriteLine(outSayi);
}
else{
	Console.WriteLine("Basarisiz");
}
Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);


//Metot Aşırı Yükleme
int ifade = 999;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Koray","Avcu");
class Metotlar{
	public void Topla(int a,int b, out int toplam){
		toplam=a+b;
	}
	public void EkranaYazdir(string veri){
		Console.WriteLine(veri);
	}
	public void EkranaYazdir(int veri){
		Console.WriteLine(veri);
	}
	public void EkranaYazdir(string veri1, string veri2){
		Console.WriteLine(veri1 + veri2);
	}
}