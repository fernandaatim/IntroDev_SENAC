#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double qtd_milhas,qtd_km;
	
	cout<<"Digite a quantidade em milhas: ";
	cin>>qtd_milhas;
	
	qtd_km=(qtd_milhas*1.60934);
	
	cout<<"A quantidade é: "<<qtd_km<<"km";
}