#include <iostream>
#include<iomanip>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double valor_hora,horas_trabalhadas,valor_final;
	
	cout<<"Digite o valor da hora: ";
	cin>>valor_hora;
	cout<<"Digite a quantidade de horas trabalhadas: ";
	cin>>horas_trabalhadas;
	valor_final=valor_hora*horas_trabalhadas;
	
	system("cls");
	cout<<"O seu salário bruto é: R$"<<valor_final<<setprecision(4);
}