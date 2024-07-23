#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double limite_velocidade = 100, velocidade_motorista,calculo;
	
	cout<<"=== CÁLCULO DE MULTAS ===""\n\nA velocidade máxima da via é de 100Km/h!";
	cout<<"\n\nVelocidade registrada do motorista: ";
	cin>>velocidade_motorista;
	
	calculo=limite_velocidade+(limite_velocidade*0.2);

	if(velocidade_motorista <= limite_velocidade){
		cout<<"Sem multa.";
	}else if(velocidade_motorista > limite_velocidade and velocidade_motorista <= calculo){
		cout<<"Multa: R$102,00.";
	}else{
		cout<<"Multa: R$500,00.";
	}	
}