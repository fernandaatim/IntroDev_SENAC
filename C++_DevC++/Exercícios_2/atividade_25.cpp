#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	int qtdPessoas, altura, soma = 0;
	
	cout<<"Digite a quantidade de pessoas: ";
	cin>>qtdPessoas;
	
	for(int i=1; i<=qtdPessoas; i++){
		cout<<"Digite a "<<i<<"ª altura:";
		cin>>altura;
		soma = soma + altura;
	}
	cout<<"A média de altura é: "<<soma/qtdPessoas;
}