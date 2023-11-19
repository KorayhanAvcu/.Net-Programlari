string[] renkler= new string[5];
string[] hayvanlar={"Kedi","Kopek","Kus"};
int[] dizi;
dizi = new int[5];

//Deger atama ve erisim
renkler[0]="Mavi";
Console.WriteLine(hayvanlar[0]);
dizi[3]=10;
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);


Console.Write("Lutfen dizinin eleman sayisini giriniz:");
int diziUzunlugu=int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];
for(int i=0; i<diziUzunlugu; i++){
	Console.Write("Lutfen " + i + ". sayiyi giriniz: ");
	sayiDizisi[i]=int.Parse(Console.ReadLine());
}
int toplam=0;
foreach(var item in sayiDizisi){
	toplam+=item;
}
Console.WriteLine("Ortalama : " + (toplam/diziUzunlugu));