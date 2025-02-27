#pragma once
#include <iostream>
#include <string>
using namespace std;

class radio {
private:
    int program;   // Program radiowy (np. RMFFM, ZET)
    int godzina;   // Czas trwania audycji
    string* Nazwa; // Wska�nik na nazw� radia

public:
    // Konstruktor z parametrami domy�lnymi
    radio(int a = 0, int b = 0, string napis = "");
    
    // Konstruktor kopiuj�cy
    radio(const radio& wzor);  // Deklaracja konstruktora kopiuj�cego

    // Wirtualny destruktor
    virtual ~radio();

    // Operator przypisania kalsy radio
    radio& operator=(const radio& wzor);

    // Funkcja do zapisania nazwy radia
    void zapamietaj(string napis);
    // Funkcja do zmiany programu
    void zmien_program();
    // Funkcja do odtwarzania programu
    void graj(string z);
    // Wirtualna funkcja inna, wywo�ywana na obiekcie
    virtual void inna();

    //  do odczytu prywatnych danych
    string getNazwa() const;
    int getprogram() const;
    int getgodzina() const;

    // Funkcja zaprzyja�niona
    friend void fun(radio& a);
};