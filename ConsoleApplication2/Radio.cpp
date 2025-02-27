#include "Radio.h"
#include <conio.h>
#include <windows.h>

// Konstruktor klasy radio
radio::radio(int a, int b, string napis) {
    program = a;
    godzina = b;
    Nazwa = new string; // Dynamiczne alokowanie pamiêci dla nazwy
    *Nazwa = napis;
    cout << "A teraz konstruktor: " << *Nazwa << endl;
}

// Destruktor, który usuwa alokowan¹ pamiêæ dla Nazwa
radio::~radio() {
    cout << "Usuwam obiekt radio: " << *Nazwa << endl;
    delete Nazwa;
}

// Funkcja zapamietaj zapisuje nazwê radia
void radio::zapamietaj(string napis) {
    *Nazwa = napis;
}


// Funkcja zmien_program pozwala na zmianê programu radiowego
void radio::zmien_program() {
    int numer;
    cout << "Wybierz program radiowy (1 - RMFFM, 2 - ZET, 3 - METAL): ";
    cin >> numer;
    switch (numer) {
    case 1:
        graj("RMFFM");
        program = 1;
        break;
    case 2:
        graj("ZET");
        program = 2;
        break;
    case 3:
        graj("METAL");
        program = 3;
        break;
    default:
        cout << "Nie znam takiego programu!" << endl;
        break;
    }
}

// Funkcja graj odtwarza dany program przez 1,5 sekundy
void radio::graj(string z) {
    while (!_kbhit()) { // Czeka na naciœniêcie klawisza
        cout << z << endl;
        Sleep(1500); // Odtwarzanie co 1.5 sekundy
    }
    godzina = 30; // Ustawiamy godzinê
}


//Koanstruktor kopij¹cy kalsy radio zadeklarowany w Radio.h
radio::radio(const radio& wzor)
{
    cout << "Konstruktor kopiuj¹cy radio " << endl;
    program = wzor.program;
    godzina = wzor.godzina;
    Nazwa = new string;
    *Nazwa = *(wzor.Nazwa);
}



//Operator przypisania operator dla klasy radio
radio& radio::operator=(const radio & wzor)
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


// Funkcja inna() wyœwietla informacje o obiekcie
void radio::inna() {
    cout << "Obiekt radio" << endl;
    cout << "Nazwa: " << getNazwa() << endl;
    cout << "Program: " << getprogram() << endl;
    cout << "Godzina: " << getgodzina() << endl;
}

//  do odczytu prywatnych sk³adników
string radio::getNazwa() const {
    return *Nazwa;
}

int radio::getprogram() const {
    return program;
}

int radio::getgodzina() const {
    return godzina;
}

// Funkcja zaprzyjaŸniona, która wywo³uje funkcjê inna() obiektu radio
void fun(radio& a) {
    a.inna();
}