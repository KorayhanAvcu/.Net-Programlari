
Calisan calisan1 = new Calisan();
calisan1.Ad = "Ayse";
calisan1.Soyad="Kara";
calisan1.No=234512;
calisan1.Departman="Insan Kaynaklari";

calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad="Arda";
calisan2.No=2145122;
calisan2.Departman="Satin Alma";
calisan2.CalisanBilgileri();




class Calisan
{
	public string Ad;
	public string Soyad;
	public int No;
	public string Departman;


	public void CalisanBilgileri(){
		Console.WriteLine("Calisanin Adi: {0}" ,Ad);
		Console.WriteLine("Calisanin Soyadi: {0}" ,Soyad);
		Console.WriteLine("Calisanin Numarasi: {0}" ,No);
		Console.WriteLine("Calisanin Departmani: {0}" ,Departman);

	}
}