#include "Radio.h"
#include "Radiomagnetofon.h"
#include "Radiocd.h"

int main() {
    // Tworzymy obiekt klasy radio
    radio* r1 = new radio(1, 10, "RMFFM");
    r1->inna(); // Wywo³anie funkcji inna() z klasy radio

    // Tworzymy obiekt klasy radiomagnetofon
    radiomagnetofon* rm1 = new radiomagnetofon(1, 10, 5, "ZET");
    rm1->inna(); // Wywo³anie funkcji inna() z klasy radiomagnetofon

    // Tworzymy obiekt klasy radiocd
    radiocd* rc1 = new radiocd(2, 15, 3, "METAL");
    rc1->inna(); // Wywo³anie funkcji inna() z klasy radiocd

    // Zwolnienie pamiêci
    delete r1;
    delete rm1;
    delete rc1;

    return 0;
}