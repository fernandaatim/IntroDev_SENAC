#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	int max;
	double altura,calculo;
	
	cout<<"Digite a quantia de pessoas: ";
	cin>>max;
	
	for(int i = 1; i <= max; i++){
	cout<<"Digite a "<<i<<"ª altura em metros: ";
	cin>>altura;
	calculo = calculo + altura;
	}
	calculo = calculo/max;
	cout<<"\nMédia final: "<<calculo<<" metros";
}