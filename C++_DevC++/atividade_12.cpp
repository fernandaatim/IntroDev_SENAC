#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double numero;
	
	cout<<"Digite um número real: ";
	cin>>numero;
	
	if(numero>=0){
		cout<<"\nSeu número é positivo!!";
	} else {
		cout<<"\nSeu número é negativo!!";
	}
}