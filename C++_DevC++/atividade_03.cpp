#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double peso1,peso2,peso3,peso4,peso5,media;
	
	cout<<"Digite o peso da 1ª pessoa: ";
	cin>>peso1;
	cout<<"Digite o peso da 2ª pessoa: ";
	cin>>peso2;	
	cout<<"Digite o peso da 3ª pessoa: ";
	cin>>peso3;	
	cout<<"Digite o peso da 4ª pessoa: ";
	cin>>peso4;	
	cout<<"Digite o peso da 5ª pessoa: ";
	cin>>peso5;		
	
	media = (peso1+peso2+peso3+peso4+peso5)/5;
	
	cout<<"\nA média final é: "<<media<<"Kg";
}
