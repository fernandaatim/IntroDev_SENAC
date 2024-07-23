#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	double valor1,valor2,valor3;
	
	cout<<"Digite o 1º número: ";
	cin>>valor1;
	cout<<"Digite o 2º número: ";
	cin>>valor2;
	cout<<"Digite o 3º número: ";
	cin>>valor3;
	
	if(valor1==valor2 and valor1==valor3 and valor2==valor3){
		cout<<"\nOs valores são iguais!";
	}else if(valor1>valor2 and valor1>valor3){
		cout<<"\nO maior número é "<<valor1;
	}else if(valor3>valor1 and valor3>valor2){
		cout<<"\nO maior número é "<<valor3;	
	}else{
		cout<<"\nO maior número é "<<valor2;
	}
}