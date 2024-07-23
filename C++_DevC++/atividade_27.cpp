#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double peso_total = 0, peso;
	
	do{
		cout<<"\nQual o peso? ";
		cin>>peso;
	
		if (peso_total + peso > 180){
			cout<<"Excederá o peso!"<<"\nPeso do momento: "<<peso_total<<"\n";
		}else if(peso_total >= 180){
			cout<<"Peso total atingido!";
		}else{
			peso_total = peso_total + peso;
		}
	} while(peso_total < 180);
		cout<<"Limite atingido!";
}