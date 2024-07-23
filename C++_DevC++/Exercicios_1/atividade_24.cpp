#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int numero;
	
	cout<<"Digite um número: ";
	cin>>numero;
	
	for(int i = 0; i<=10; i++){
		cout<<numero<<" x "<<i<<" = "<<(numero*i)<<"\n";
		sleep(0.2);
	}
	
}