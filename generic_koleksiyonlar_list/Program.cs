//List<T> class
//System.Collection.Generic
//T-> object turundedir.

List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);


List<string> renkListesi = new List<string>();
renkListesi.Add("Kirmizi");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sari");
renkListesi.Add("Yesil");

//Count kaç eleman oldugunu soyler
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

//Foreach ve List.ForEach ile elemanlara erişim
foreach(var item in sayiListesi)
	Console.WriteLine(item);
foreach(var item in renkListesi)
	Console.WriteLine(item);
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//Listeden eleman Çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yesil");
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//indexle cikartmak istersek
sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//List içerisinde arama
if(sayiListesi.Contains(10)){
    Console.WriteLine("10 icerisinde bulundu.");
}
//eleman ile index'e erisme
Console.WriteLine(renkListesi.BinarySearch("Kirmizi"));

//Diziyi listeye çevirme
string[] hayvanlar = {"Kedi", "Kopek", "Kus"};
List<string> hayvanListesi=new List<string>(hayvanlar);

//Listeyi nasil temizleriz?
hayvanListesi.Clear();

//Liste içerisinde nesne tutmak
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Koray";
kullanici1.Soyisim="Avcu";
kullanici1.Yas=25;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "KorayHan";
kullanici2.Soyisim="Avci";
kullanici2.Yas=18;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar(){
    Isim = "Deniz",
    Soyisim="Kar",
    Yas=22
});

foreach(Kullanicilar kullanici in kullaniciListesi){
    Console.WriteLine("Kullanici Adi : " + kullanici.Isim);
    Console.WriteLine("Kullanici Soyadi : " + kullanici.Soyisim);
    Console.WriteLine("Kullanici Yas : " + kullanici.Yas);
}
    
public class Kullanicilar{
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim{get=>isim;set=>isim=value;}
    public string Soyisim{get=>soyisim;set=>soyisim=value;}

    public int Yas{get=>yas;set=>yas=value;}
}
