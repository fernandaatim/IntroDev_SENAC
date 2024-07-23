#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int contador=0,opcao;
	
	cout<<"==== INTERROGATÓRIO CRIMINAL ====";
	cout<<"\n\nDigite 1 para Sim e 2 para Não";
	
	cout<<"\n\nTrocou mensagem com a vítima? [1]Sim [2]Não\n";
	cin>>opcao;
	if(opcao==1){
		contador++;	
	}else{}
	
	cout<<"\nEsteve no local do crime? [1]Sim [2]Não\n";
	cin>>opcao;
	if(opcao==1){
		contador++;	
	}else{}
	
	cout<<"\nÉ parente ou reside perto da vítima? [1]Sim [2]Não\n";
	cin>>opcao;
	
	if(opcao==1){
		contador++;	
	}else{}
	
	cout<<"\nDevia algum valor para a vítima? [1]Sim [2]Não\n";
	cin>>opcao;
	
	if(opcao==1){
		contador++;	
	}else{}
	
	cout<<"\nTrabalha ou trabalhou com a vítima? [1]Sim [2]Não\n";
	cin>>opcao;
	
	if(opcao==1){
		contador++;	
	}else{}
	cout<<"\nPossui algum tipo de relacionamento amoroso com a vítima? [1]Sim [2]Não\n";
	cin>>opcao;
	if(opcao==1){
		contador++;	
	}else{}
	cout<<"\nFicou feliz pelo destino fatídico da vítima? [1]Sim [2]Não\n";
	cin>>opcao;
	if(opcao==1){
		contador++;	
	}else{}
	cout<<"\nPossui algum tipo de arma de fogo? [1]Sim [2]Não\n";
	cin>>opcao;
	if(opcao==1){
		contador++;	
	}else{}
	sleep(0.5);
	system("cls");
	
	if(contador == 4){
		cout<<"Suspeito do crime!";
	}else if(contador >= 5 && contador <= 7){
		cout<<"Possivel criminoso!";
	}else if(contador >=8){
		cout<<"Assasino!!!";
	}else{
		cout<<"Inocente.";
	}
}