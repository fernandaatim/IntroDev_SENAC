#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");

	int cpf,quantidade_dependentes;
	double renda_mensal,imposto_renda,taxa,aliquota = 0;
	
	cout<<"==== CÁLCULO IMPOSTO DE RENDA ====";
	cout<<"\n\nTaxa de 5% por dependente.\nTaxa de alíquota variável.";
	cout<<"\n\nDigite o CPF (apenas números): ";
	cin>>cpf;
	cout<<"\nDigite o número de dependentes: ";
	cin>>quantidade_dependentes;
	cout<<"\nDigite a sua renda mensal(0000.00): ";
	cin>>renda_mensal;
	system("cls");
	cout<<"==== CÁLCULO IMPOSTO DE RENDA ====";
	cout<<"\n\n"
	cout<<"\nRenda mensal: R$"<<renda_mensal;	
	
	if(renda_mensal<=1412){
		taxa=quantidade_dependentes*0.05;
		imposto_renda=renda_mensal-(renda_mensal*taxa);
		cout<<"\nTaxa de dependentes: "<<taxa;
		cout<<"\nAlíquota: "<<aliquota;
		cout<<"\nValor final: R$"<<imposto_renda;
	}else if(renda_mensal<=4236){
		aliquota=0.05;
		taxa=quantidade_dependentes*0.05;
		imposto_renda=(renda_mensal*taxa)+(renda_mensal*aliquota);
		cout<<"\nTaxa de dependentes: "<<taxa;
		cout<<"\nAlíquota: "<<aliquota;
		cout<<"\nValor final: R$"<<imposto_renda;	
	}else if(renda_mensal<=7060){
		aliquota=0.10;
		taxa=quantidade_dependentes*0.05;
		imposto_renda=(renda_mensal*taxa)+(renda_mensal*aliquota);
		cout<<"\nTaxa de dependentes: "<<taxa;
		cout<<"\nAlíquota: "<<aliquota;
		cout<<"\nValor final: R$"<<imposto_renda;
	}else if(renda_mensal<=9884){
		taxa=quantidade_dependentes*0.05;
		aliquota=0.15;
		imposto_renda=(renda_mensal*taxa)+(renda_mensal*aliquota);
		cout<<"\nTaxa de dependentes: "<<taxa;
		cout<<"\nAlíquota: "<<aliquota;
		cout<<"\nValor final: R$"<<imposto_renda;
	}else{
		taxa=quantidade_dependentes*0.05;
		aliquota=0.2;
		imposto_renda=(renda_mensal*taxa)+(renda_mensal*aliquota);
		cout<<"\nTaxa de dependentes: "<<taxa;
		cout<<"\nAlíquota: "<<aliquota;
		cout<<"\nValor final: R$"<<imposto_renda;
	}
}

