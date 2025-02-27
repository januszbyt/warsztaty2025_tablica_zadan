#include"Radio.h"
#include<conio.h>
using namespace std;

void radio::graj(string z)
{
	while (!_kbhit())
	{
		cout << z << endl;
		Sleep(1500);
	}
	godzina = 30;
}
void radio::zapamietaj(string napis)
{
	*Nazwa = napis;
}
void radio::zmien_program()
{
	int numer;
	cout << "wybierz numer stacji " << endl;
	cin >> numer;
	switch (numer)
	{
	case 1:
		*Nazwa = "RMFFM";
		break;
	case 2:
		*Nazwa = "ZET";
		break;
	case 3:
		*Nazwa = "ESKA";
		break;
	case 4:
		*Nazwa = "inna nazwa";
		break;
	default:
		cout << "Nie znam takiego programu"; break;
	}
}
radio::radio(int a, int b, string napis)
{
	program = a;
	godzina = b;
	Nazwa = new string;
	*Nazwa = napis;
}

radio::radio(const radio& wzor)
{
	cout << "Konstruktor kopiuj¹cy radio " << endl;
	program = wzor.program;
	godzina = wzor.godzina;
	Nazwa = new string;
	*Nazwa = *(wzor.Nazwa);
}
radio::~radio()
{
	cout << " usuwam obiekt radio" << *Nazwa << endl;
	delete Nazwa;
}

radio& radio::operator=(const radio & -wzor)
{
	if (this != &wzor)
	{
		cout << "Operator radio =\n";
		program = wzor.program;
		godzina = wzor.godzina;

		Nazwa = new string(*(wzor.Nazwa));
	}
	return *this;
}
string radio::getNazwa()
{
	return *Nazwa;
}
int radio::getprogram()
{
	return program;
}
int radio::getgodzina()
{
	return godzina;
}
void radio::inna() {
	cout << "Obiekt radio" << endl;
	cout << "Nazwa: " << *Nazwa << endl;
	cout << "Godzina: " << godzina << endl;