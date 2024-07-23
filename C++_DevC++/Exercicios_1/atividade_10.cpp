#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	double peso,imc;
	int genero;
	
	cout<<"Digite a sua altura:";
	cin>>peso;
	cout<<"Digite [1]Homem e [2]mulher:";
	cin>>genero;

	if(genero==1){
		imc = 58-(72,7*peso);
		cout<<"Peso ideal = "<<imc;
	}else{
		imc = 44,7-(62,1*peso);
		cout<<"Peso ideal = "<<imc;
	}
}