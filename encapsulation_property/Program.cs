Ogrenci ogrenci1=new Ogrenci();
ogrenci1.Isim="koray";
ogrenci1.Soyisim="avcu";
ogrenci1.OgrenciNo=12312;
ogrenci1.Sinif=3;
ogrenci1.OgrenciBilgileriniGetir();

ogrenci1.SinifAtlat();
ogrenci1.OgrenciBilgileriniGetir();
Ogrenci ogrenci2=new Ogrenci("Deniz","Kara",123,1);
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileriniGetir();
class Ogrenci{
	private string isim;
	private string soyisim;
	private int ogrenciNo;
	private int sinif;
	public string Isim
	{
		get{return isim;} 
		set{isim=value;}
	}
	public string Soyisim{get=>soyisim;set=>soyisim=value;}
	public int OgrenciNo{get=>ogrenciNo;set=>ogrenciNo=value;}
	public int Sinif{
		get=>sinif;
		set{
			if(value<=1){
				Console.WriteLine("Sinif En Az Bir Olabilir.");
				sinif=1;
			}
			else
				sinif=value;
		}
	}
	public Ogrenci(string isim, string soyisim, int ogrenciNo,int sinif){
		Isim=isim;
		Soyisim=soyisim;
		OgrenciNo=ogrenciNo;
		Sinif=sinif;
	}
	public Ogrenci(){
		
	}
	public void OgrenciBilgileriniGetir(){
		Console.WriteLine("*****Ogrenci Bilgileri*********");
		Console.WriteLine("Ogrencinin Adi:{0}", this.Isim);
		Console.WriteLine("Ogrencinin Soyadi:{0}", this.Soyisim);
		Console.WriteLine("Ogrencinin No:{0}", this.OgrenciNo);
		Console.WriteLine("Ogrencinin Sinifi:{0}", this.Sinif);
	}
	public void SinifAtlat(){
		this.Sinif=this.Sinif+1; 
	}
	public void SinifDusur(){
		this.Sinif=this.Sinif-1;
	}
}