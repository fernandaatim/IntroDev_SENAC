#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int numero;
	
	cout<<"Digite um número: ";
	cin>>numero;
	cout<<"\nTabuada de "<<numero;
	
	for(int i = 0; i<=10; i++){
		cout<<"\n"<<i<<"x"<<numero<<" = "<<numero*i;
	}
}