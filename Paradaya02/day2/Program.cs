// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int nillai = 80; // tipe data: integer
bool isNilai = false; // tipe data: boolean
double desimal = 30.54; // tipe data: double
string nama = "Budi"; // tipe data: string
char karakter = 'A'; // tipe data: char

var a = 10; // tipe data defaultnya mengikuti nilai yang diberikan
// a = 5.5; (ini terlarang karena a sudah di set sebagai integer)

int b = 20;
int c = a + b;
Console.WriteLine(c);

// Conditional Statement
// Cara 1
if (nillai > 75)
{
		Console.WriteLine("Selamat " + nama + ", Anda Lulus!");
}
else
{
		Console.WriteLine("Maaf " + nama + ", Anda Tidak Lulus!");
}

// Cara 2
string day = "Mon";
switch (day)
{
	case "Mon": Console.WriteLine("Start!"); break;
	case "Fri": Console.WriteLine("End!"); break;
	default: Console.WriteLine("Keep Going!"); break;
}

// Looping
// Cara 1
for (int i =1; i <= 5; i++)
{
		Console.WriteLine("Perulangan ke-" + i);
}

// Cara 2
int j = 1;
while (j <= 5)
{
		Console.WriteLine("While Perulangan ke-" + j);
		j++;
}

// Cara 3
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (var name in fruits)
{
	Console.WriteLine(name);
}