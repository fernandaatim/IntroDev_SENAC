#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int ano;
	
	cout<<"=== VERIFIQUE SE O ANO É BISSEXTO! ===";
	cout<<"\n\nDigite um ano: ";
	cin>>ano;
	
	if (ano % 100 != 0 and ano % 4 == 0){
		cout<<"\nAno bissexto";
	} else{
		cout<<"\nO ano não é bissexto";
	}
}