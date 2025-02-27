#pragma once
#include "Radio.h"

// Klasa radiocd dziedziczy po klasie radio
class radiocd : public radio {
private:
    int cd; // Sk�adnik klasy - numer p�yty CD

public:
    // Konstruktor z parametrami
    radiocd(int a = 0, int b = 0, int c = 0, string napis = "");
    // Destruktor
    virtual ~radiocd();
    // Konstruktor kopiuj�cy
    radiocd(const radiocd& wzor);
    // Operator przypisania
    radiocd& operator=(const radiocd& wzor);

    // Nadpisana funkcja inna()
    void inna() override;
};