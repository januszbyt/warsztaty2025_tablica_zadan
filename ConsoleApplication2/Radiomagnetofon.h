#pragma once
#include "Radio.h"

// Klasa radiomagnetofon dziedziczy po klasie radio
class radiomagnetofon : public radio {
private:
    int kaseta; // Sk³adnik klasy - numer kasety

public:
    // Konstruktor z parametrami
    radiomagnetofon(int a = 0, int b = 0, int c = 0, string napis = "");
    // Destruktor
    virtual ~radiomagnetofon();
    // Konstruktor kopiuj¹cy
    radiomagnetofon(const radiomagnetofon& wzor);
    // Operator przypisania
    radiomagnetofon& operator=(const radiomagnetofon& wzor);

    // Nadpisana funkcja inna()
    void inna() override;
};