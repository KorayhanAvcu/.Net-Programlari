using System.Data;

Dictionary<string, string> phoneBook = new Dictionary<string, string>();
phoneBook.Add("Korayhan Avcu", "5332145226");
phoneBook.Add("Hasan Ali", "5552142320");
phoneBook.Add("Ilayda Tosun", "5321458556");
phoneBook.Add("Hakan Su", "5302216684");
phoneBook.Add("Selin Mercan", "5074158931");
while(true){
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncelleme");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");
Console.Write("Lutfen Yapmak Istediginiz İslemi Seciniz: ");
int select = int.Parse(Console.ReadLine());

    

switch(select){
    case 1:
        AddContact(phoneBook);
        break;
    case 2:
        DeletePerson(phoneBook);
        break;
    case 3:
        UpdatePerson(phoneBook);
        break;
    case 4:
        Console.WriteLine("(1) A-Z ye siralama");
        Console.WriteLine("(2) Z-A ya siralama");
        select=int.Parse(Console.ReadLine());
        if(select==1){
            //A-Z'ye siralamak icin asagidaki gibi yapiyoruz.
        ListPhoneBook(phoneBook.OrderBy(entry => entry.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value));
        }
        else if(select==2){
             //Z-A'ya siralamak icin asagidaki gibi yapiyoruz.
        ListPhoneBook(phoneBook.OrderByDescending(entry => entry.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value));
        }
       
        
        break;
    case 5:
        Console.WriteLine("(1) Telefon numarasına göre arama yapmak için");
        Console.WriteLine("(2) Isim veya soyisime göre arama yapmak için");
        Console.Write("Arama yapmak istediğiniz tipi seçiniz : ");
        select=int.Parse(Console.ReadLine());
        Search(phoneBook,select);
        break;
}

}

static void AddContact(Dictionary<string,string> phoneBook){
    Console.WriteLine("Isim Giriniz : ");
    string ad=Console.ReadLine();
    Console.WriteLine("Soyisim Giriniz : ");
    string soyad=Console.ReadLine();
    Console.WriteLine("Telefon Numarasi Giriniz : ");
    string telefon=Console.ReadLine();
    string fullname= ad + " " + soyad;
    phoneBook.Add(fullname,telefon);
}
static void DeletePerson(Dictionary<string,string> phoneBook){
    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
    string kisi = Console.ReadLine();
    var matchingContacts = phoneBook.Keys.Where(name => name.Contains(kisi)).ToList();

    if (matchingContacts.Count > 0)
    {
        Console.WriteLine("Arama sonuçları:");
        foreach (var contact in matchingContacts)
        {
            string[] name = contact.Split(' ');
            Console.WriteLine("İsim : {0} Soyisim : {1} Telefon Numarasi : {2}",name[0],name[1],phoneBook[contact]);
        }
        Console.WriteLine(matchingContacts[0] + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
        string select = Console.ReadLine();
        if(select.Equals("y")){
            phoneBook.Remove(matchingContacts[0]);
        }
       
    }
    else{
        Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("Yeniden denemek için : (2)");
        int select = int.Parse(Console.ReadLine());
        if(select == 2)
            DeletePerson(phoneBook);
        else if(select==1)
            Console.WriteLine("Isleminiz sonlanmistir");
    }
}
static void UpdatePerson(Dictionary<string,string> phoneBook){
    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
    string kisi = Console.ReadLine();
    var matchingContacts = phoneBook.Keys.Where(name => name.Contains(kisi)).ToList();

    if (matchingContacts.Count > 0)
    {
        Console.WriteLine("Arama sonuçları:");
        foreach (var contact in matchingContacts)
        {
            string[] name = contact.Split(' ');
            Console.WriteLine("İsim : {0} Soyisim : {1} Telefon Numarasi : {2}",name[0],name[1],phoneBook[contact]);
        }
        string selectedContact = matchingContacts[0];
        Console.WriteLine($"{selectedContact} adlı kişinin telefon numarasi güncellenecektir, onaylıyor musunuz ?(y/n)");
        string select = Console.ReadLine();
        if(select.Equals("y")){
            Console.Write("Yeni Numarayi Giriniz: ");
            string newPhone = Console.ReadLine();
            phoneBook[selectedContact] = newPhone;
        }
        
    }
    else{
        Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("Güncellemeyi sonlandırmak için  : (1)");
        Console.WriteLine("Yeniden denemek için : (2)");
        int select = int.Parse(Console.ReadLine());
        if(select == 2)
            UpdatePerson(phoneBook);
        else if(select==1)
            Console.WriteLine("Isleminiz sonlanmistir");
    }
}
static void ListPhoneBook(Dictionary<string,string> phoneBook){
    foreach(var item in phoneBook)
    {
        string[] name = item.Key.Split(' ');
        Console.WriteLine("İsim : {0} Soyisim : {1} Telefon Numarasi : {2}",name[0],name[1],item.Value);
    }
}
static void Search(Dictionary<string,string> phoneBook, int select){
    if(select == 1){
        string telefonNumarasi=Console.ReadLine();
        var matchingContacts = phoneBook.Where(name => name.Value==telefonNumarasi).ToList();

        if (matchingContacts.Count > 0)
        {
            Console.WriteLine("Arama sonuçları:");
            foreach (var contact in matchingContacts)
            {
                string[] name = contact.Key.Split(' ');
                Console.WriteLine("İsim : {0} Soyisim : {1} Telefon Numarasi : {2}",name[0],name[1],contact.Value);
            }
            
        }
        else{
            Console.WriteLine("Sonuc bulunamadi");
        }
    }
    else if(select == 2){
        string kisi = Console.ReadLine();
        var matchingContacts2 = phoneBook.Keys.Where(name => name.Contains(kisi)).ToList();

        if (matchingContacts2.Count > 0)
        {
            Console.WriteLine("Arama sonuçları:");
            foreach (var contact in matchingContacts2)
            {
                string[] name = contact.Split(' ');
                Console.WriteLine("İsim : {0} Soyisim : {1} Telefon Numarasi : {2}",name[0],name[1],phoneBook[contact]);
            }
            
        }
        else{
            Console.WriteLine("Sonuc bulunamadi");
        }
    }

    
}