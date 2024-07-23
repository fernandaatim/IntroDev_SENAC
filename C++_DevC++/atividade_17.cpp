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
	
	media = ((nota1*2)+(nota2*3)+(nota3*5))/10;
	
	cout<<"\nMedia final: "<<media;
}