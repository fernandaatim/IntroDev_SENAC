#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	double peso,soma;
	
	for(int i=1; i<=5; i++){
		cout<<"Digite o peso da "<<i<<"ª pessoa: ";
		cin>>peso;
		soma = soma + peso;
	}
	cout<<"\nA média de peso é: "<<soma/5;	
}