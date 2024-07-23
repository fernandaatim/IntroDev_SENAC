#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double peso,i=1,calculo;
	
	do{
		cout<<"Digite o "<<i<< "º peso:";
		cin>>peso;
		i++;
		calculo = calculo + peso;
	}while(i<6);
		cout<<"Media final: "<<(calculo/5)<<"Kg";
}