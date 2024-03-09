#include <iostream>


using namespace std;

int main() {
    cout << "Ingresar un numero decimal: ";
    string numero;
    cin >> numero;

    
    string numeroRevertido;
    for (int i = numero.length() - 1; i >= 0; --i) {
        numeroRevertido += numero[i];
    }

    
    cout << "posicion intercambiada: " << numeroRevertido << endl;

    return 0;
}      

