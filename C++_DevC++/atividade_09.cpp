#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double nota1,nota2,nota3,media;
	
	cout<<"Digite a 1ª nota: ";
	cin>>nota1;
	cout<<"Digite a 2ª nota: ";
	cin>>nota2;
	cout<<"Digite a 3ª nota: ";
	cin>>nota3;
	
	media = (nota1+nota2+nota3)/3;
	
	if (media>=7){
	} else if (media>=5){
		cout<<"\nRecuperação!";
	}else{
		cout<<"\nReprovado!";	
	}
	
	cout<<"\n\nSua média final é: "<<media;
}