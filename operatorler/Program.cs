﻿// Atama Ve işlemli Atama
int x = 3;
int y = 3;
y = y+2;
Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x *=2;
Console.WriteLine(x);
//Mantıksal Operatörler
// ||, && !
bool isSuccess = true;
bool isCompleted = false;
if(isSuccess && isCompleted)
Console.WriteLine("Perfect!");
if(isSuccess || isCompleted)
Console.WriteLine("Great!");
if(isSuccess && !isCompleted)
Console.WriteLine("Fine!");
//Ilişkisel Operatörler
// <, >, <= >=, ==,!=
int a = 3;
int b = 4;
bool sonuc = a<b;
Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);

// /, *,+,-
int sayil = 10;
int sayi2 = 5;
int sonuc1= sayil/sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayil*sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayil+sayi2;
Console.WriteLine(sonuc1);
sonuc1 =sayil++;
Console.WriteLine(sayil);
// %: mod alir
int sonuc2= 20%3;
Console.WriteLine(sonuc2);