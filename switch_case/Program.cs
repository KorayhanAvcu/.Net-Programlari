int month = DateTime.Now.Month;

switch(month){
	case 1:
		Console.WriteLine("Ocak Ayindayiz");
		break;
	case 2:
		Console.WriteLine("Subat Ayindayiz");
		break;
	case 3:
		Console.WriteLine("Mart Ayindayiz");
		break;
	case 4:
		Console.WriteLine("Nisan Ayindayiz");
		break;
	case 5:
		Console.WriteLine("Mayis Ayindayiz");
		break;
	case 6:
		Console.WriteLine("Haziran Ayindayiz");
		break;
	case 7:
		Console.WriteLine("Temmuz Ayindayiz");
		break;
	case 8:
		Console.WriteLine("Agustos Ayindayiz");
		break;
	case 9:
		Console.WriteLine("Eylul Ayindayiz");
		break;
	case 10:
		Console.WriteLine("Ekim Ayindayiz");
		break;
	case 11:
		Console.WriteLine("Kasım Ayindayiz");
		break;
	case 12:
		Console.WriteLine("Aralik Ayindayiz");
		break;
	default:
		break;

}
switch(month){
	case 12:
	case 1:
	case 2:
		Console.WriteLine("Kis Ayindayiz");
		break;
	case 3:
	case 4:
	case 5:
		Console.WriteLine("Ilkbahar Ayindayiz");
		break;
	case 6:
	case 7:
	case 8:
		Console.WriteLine("Yaz Ayindayiz");
		break;
	case 9:
	case 10:
	case 11:
		Console.WriteLine("Sonbahar Ayindayiz");
		break;
	default:
		break;

}