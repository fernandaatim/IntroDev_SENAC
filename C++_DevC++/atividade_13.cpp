#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int numero;
	
	cout<<"Digite um número real: ";
	cin>>numero;
	
	if(numero % 2==0){
		cout<<"\nO seu número é par!";
	} else {
		cout<<"\nO seu número é ímpar!";
	}
}