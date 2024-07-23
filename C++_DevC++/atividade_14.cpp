#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	double num1,num2;
	
	cout<<"Digite um número: ";
	cin>>num1;
	cout<<"Digite outro número: ";
	cin>>num2;
	
	if(num1>num2){
		cout<<"\nO maior número é: "<<num1;
	}else{
		cout<<"\nO maior número é: "<<num2;
	}
}