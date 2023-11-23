﻿
Console.WriteLine("Calisan Sayisi : {0}",Calisan.CalisanSayisi);

Calisan calisan1=new Calisan("Ayse","Yilmaz","IK");

Console.WriteLine("Calisan Sayisi : {0}",Calisan.CalisanSayisi);
Calisan calisan2=new Calisan("Deniz","Arda","IT");
Calisan calisan3=new Calisan("Koray","Avcu","IK");
Console.WriteLine("Calisan Sayisi : {0}",Calisan.CalisanSayisi);

Console.WriteLine("Toplama Islemi Sonucu:{0} " ,Islemler.Topla(100,200));
Console.WriteLine("Cikarma Islemi Sonucu:{0} " ,Islemler.Cikar(300,200));

class Calisan{
	private static int calisanSayisi;
 	
	public static int CalisanSayisi{get=>calisanSayisi;}
	
	private string isim;
	private string soyisim;
	private string departman;

	static Calisan(){
		calisanSayisi=0;
	}
	public Calisan(string isim, string soyisim, string departman){
		this.isim=isim;
		this.soyisim=soyisim;
		this.departman=departman;
		calisanSayisi++;

	}
}

static class Islemler{
	public static long Topla(int sayi1, int sayi2){
		return sayi1+sayi2;
	}
	public static long Cikar(int sayi1, int sayi2){
		return sayi1-sayi2;
	}
}

