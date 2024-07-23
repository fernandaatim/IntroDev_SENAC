#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int duracao,horas,minutos,segundos;
	
	cout<<"Digite a duração do evento em segundos: ";
	cin>>duracao;
	
	horas = duracao/3600;
	minutos = (duracao%3600)/60;
	segundos = (duracao%60);
	
	cout<<"Tempo de duração:"<<horas<<"h"<<minutos<<"m"<<segundos<<"s"; 
		
}
