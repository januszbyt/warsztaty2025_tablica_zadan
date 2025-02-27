#include "Radiomagnetofon.h"

// Konstruktor klasy radiomagnetofon
radiomagnetofon::radiomagnetofon(int a, int b, int c, string napis)
    : radio(a, b, napis), kaseta(c) {
    cout << "Konstruktor radiomagnetofon: kaseta = " << kaseta << endl;
}

// Destruktor klasy radiomagnetofon
radiomagnetofon::~radiomagnetofon() {
    cout << "Usuwam obiekt radiomagnetofon" << endl;
}

// Konstruktor kopiujący dla radiomagnetofon
radiomagnetofon::radiomagnetofon(const radiomagnetofon& wzor)
    : radio(wzor), kaseta(wzor.kaseta) {
    cout << "Konstruktor kopiujący radiomagnetofon" << endl;
}

// Operator przypisania dla radiomagnetofon
radiomagnetofon& radiomagnetofon::operator=(const radiomagnetofon& wzor) {
    if (this != &wzor) {
        radio::operator=(wzor); // Wywołanie operatora przypisania z klasy bazowej
        kaseta = wzor.kaseta;
        cout << "Operator przypisania radiomagnetofon" << endl;
    }
    return *this;
}

// Nadpisana funkcja inna() wyświetlająca informacje o obiekcie
void radiomagnetofon::inna() {
    cout << "Obiekt radio-magnetofon" << endl;
    radio::inna();  // Wywołanie funkcji inna() z klasy podstawowej
    cout << "Kaseta: " << kaseta << endl;
}