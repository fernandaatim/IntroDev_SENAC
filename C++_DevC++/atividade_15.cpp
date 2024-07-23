#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	int valor_a,valor_b,valor_c,soma,divisao;
	
	cout<<"Digite um número inteiro e positivo: ";
	cin>>valor_a;
	cout<<"Digite um número inteiro e positivo: ";
	cin>>valor_b;
	cout<<"Digite um número inteiro e positivo: ";
	cin>>valor_c;
	
	soma=(valor_a*valor_b*valor_c);
	divisao=(valor_a+valor_b+valor_c)/3;
	
	if(valor_c>valor_a+valor_b or valor_c==valor_a+valor_b){
		cout<<"\nNão formou um triângulo";
		cout<<"\nValores informados: \n1º: "<<valor_a<<"\n2º: "<<valor_b<<"\n3º: "<<valor_c;
	}else if(valor_b>valor_a+valor_c or valor_b==valor_a+valor_c){
		cout<<"\nNão formou um triângulo";
		cout<<"\nValores informados: \n1º: "<<valor_a<<"\n2º: "<<valor_b<<"\n3º: "<<valor_c;
	}else if(valor_a>valor_b+valor_c or valor_a==valor_b+valor_c){
		cout<<"\nNão formou um triângulo";
		cout<<"\nValores informados: \n1º: "<<valor_a<<"\n2º: "<<valor_b<<"\n3º: "<<valor_c;
	}else if(divisao==valor_a or divisao==valor_b or divisao==valor_c){
		cout<<"\nNão formou um triângulo";
		cout<<"\nValores informados: \n1º: "<<valor_a<<"\n2º: "<<valor_b<<"\n3º: "<<valor_c;
	}else{
		cout<<"\nFormou um triângulo!";
		cout<<"\nÁrea:"<<soma;
	}
}