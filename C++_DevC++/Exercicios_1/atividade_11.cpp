#include <iostream>
#include<iomanip>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int opcao;
	double num1,num2;
	
	cout<<"Digite o 1º número: ";
	cin>>num1;
	cout<<"Digite o 2º número: ";
	cin>>num2;
	system("cls");
	
	cout<<"Escolha uma operação matemática básica\n[1]Soma\n[2]Subtração\n[3]Multiplicação\n[4]Divisão";
	cout<<"\nOpção: ";
	cin>>opcao;
	system("cls");
	cout<<"======Operação Matemática======";
	cout<<"\n\nNúmero 1: "<<num1;
	cout<<"\nNúmero 2: "<<num2;
	
	if(opcao >= 5){
		cout<<"Operação inválida! Escolha outra.";
	} else if(opcao == 1){
		cout<<"\nA soma é: "<<(num1+num2);
	} else if(opcao==2){
		cout<<"\nA subtração é: "<<(num1-num2);
	} else if(opcao==3){
		cout<<"\nA multiplicação é: "<<(num1*num2);
	} else {
		cout<<"\nA divisão é: "<<(num1/num2)<<setprecision(4);
	}	      
}