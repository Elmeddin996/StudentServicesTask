
using StudentServiceTask.Models;
using StudentServiceTask.Services.Implimentation;
using StudentServiceTask.Services.Interfaces;

IStudentServices studentServices = new StudentServices();

int secim;

try
{
do
{
		Console.Clear();	
		Console.WriteLine("Yeni telebe melumatlari daxil etmek ucun 1-e basin");
		Console.WriteLine("Telebe melumatlarini silmek ucun 2-e basin");
		Console.WriteLine("Telebe melumatlarini deyismek etmek ucun 3-e basin");
		Console.WriteLine("Butun telebe melumatlarina baxmaq ucun 4-e basin");
		Console.WriteLine("Her hansi telebe melumatina baxmaq ucun 5-e basin");
		Console.WriteLine("Emeliyyati dayandirmaq ucun 0-a basin");

        secim= int.Parse(Console.ReadLine());

switch (secim)
{ 
	case 1:
		Console.WriteLine("Zehmet olmasa Ad,Soyad ve Ortalama balinizi daxil edin");
		studentServices.Create(Console.ReadLine(),Console.ReadLine(),int.Parse(Console.ReadLine()));
		break;
	case 2:
		Console.WriteLine("Zehmet olmasa silmek istediyiniz telebenin Id-ni daxil edin");
		studentServices.Delete(int.Parse(Console.ReadLine()));
		break;
    case 3:
		Console.WriteLine("Zehmet olmasa Id, Ad, Soyad ve Ortalama bal daxil edin");
		studentServices.Edit(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),int.Parse(Console.ReadLine()));
		break; 
	case 4:
        Student[] Students = studentServices.GetAll();
        foreach (var item in Students)
        {
        Console.WriteLine(item);
        }
		break;
	case 5:
		Console.WriteLine("Zehmet olmasa Id daxil edin");
		studentServices.GetById(int.Parse(Console.ReadLine()));
		break;
	case 0:
		Console.WriteLine("Emeliyyat dayandirildi!!!");
		return;
    default:
		Console.WriteLine("Duzgun Secim Daxil Edin!!!");
		break;
}
} while (secim!=0);
}
catch 
{
	Console.WriteLine("Xeta Bash Verdi!!!");
}


