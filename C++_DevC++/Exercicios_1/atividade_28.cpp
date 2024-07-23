#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int num,qtd_negativo=0,j;
	int numeros[10];
	
	for(int i=1; i<=10; i++){
		cout<<"Digite o "<<i<<"º número: ";
		cin>>num;
		numeros[i] = num;
		
		if(num < 0){
			qtd_negativo++;
		}
	}	
		system("cls");
		cout<<"Números negativos: \n";
		for(int i=1; i<=10; i++){
			if(numeros[i]<0){
					cout<<numeros[i]<<"\n";			
			}		
		}
		cout<<"\nQuantidade de números negativos: "<<qtd_negativo;	
	}