#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double temperatura_celsius,temperatura_convertida;
	
	cout<<"Digite a temperatura em Cº: ";
	cin>>temperatura_celsius;
	
	temperatura_convertida=(9*temperatura_celsius+160)/5;
	
	cout<<"A temperatura convertida em Fahrenheit é: "<<temperatura_convertida<<"ºF";	
}