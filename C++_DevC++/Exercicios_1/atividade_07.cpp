#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int distancia, metros, centimetros;
	
	cout<<"Digite a distância em KM: ";
	cin>>distancia;
	
	metros = distancia * 1000;
	centimetros = distancia * 100000;
	
	cout<<"Distância de "<<distancia<<"km em: \n";
	cout<<"Metros: "<<metros<<"m\n";
	cout<<"Centímetros: "<<centimetros<<"cm\n";
}