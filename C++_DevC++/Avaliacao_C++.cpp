#include <iostream>
#include <cstdlib>
#include <string>

//FERNANDA FIGUEREDO BERWALD - 3 16 21 27 26
//Questão 6 - APRESENTE 9 ASTERÍSCOS - segue um padrão (1-2 , 1-2-3, 2-3-4, 3...?) quando printa 1 a +, exibe o anterior??
//+ que 1 e - que 5 for!
//não consegui pensar nessa 6 ai sor, foi mal, estoy cansada de quebrar cabeça com django no trabaio :(

using namespace std;

main() {
    int op,op_investigacao=0;
    double calculo,peso_ex1=0,peso_ex2=0;
    int i;
    system("chcp 65001");
    
    do{
    	system("cls");
        cout<<"\n \t=== MENU DE OPÇÕES === \n";
        cout<<"\n [1] Exercício 3 - Media de 5 pesos";
        cout<<"\n [2] Exercício 16 - Cálculo de Imposto";
        cout<<"\n [3] Exercício 21 - Investigação Criminal";
        cout<<"\n [4] Exercício 27 - Limite de Peso Elevador";
        cout<<"\n [5] Exercício 26 - Melhoria Media 5 pesos";
        cout<<"\n [6] Apresentar padrão da tela";
        cout<<"\n [7] Encerrar \n\n";
        cout<<"Digite uma opção: ";
        cin>>op;
        system("cls");		
        switch(op) {
            case 1: {
				calculo=0;
				for(i=1; i<=5;i++){
            		cout<<"Digite o peso da "<<i<<" ª pessoa: ";
                	cin>>peso_ex1;
                	calculo = calculo+peso_ex1;
				}
                cout<<"\nA média final das 5 pessoas é: "<<calculo/5<<"\n\n";
                system("pause");
                break;
            };
            case 2: {
            	double renda_mensal=0,taxa,imposto;
            	int num_dependentes,cpf;
        
                cout<<"==== CÁLCULO IMPOSTO DE RENDA ====";
				cout<<"\n\nDigite o CPF (apenas números): ";
				cin>>cpf;
				cout<<"\nDigite o número de dependentes: ";
				cin>>num_dependentes;
				cout<<"\nDigite sua renda mensal: R$";
				cin>>renda_mensal;
				
				if(renda_mensal <= 2824){
					cout<<"Isento da declaração de imposto!\n\n";
				}else if(renda_mensal >2824 and renda_mensal<= 4236){
					taxa = num_dependentes * 0.05;
					cout<<"Imposto final: R$"<<(renda_mensal*0.05)+(renda_mensal*taxa)<<"\n\n";
				}else if(renda_mensal>4236 and renda_mensal <=7060){
					taxa = num_dependentes * 0.05;
					cout<<"Imposto final: R$"<<(renda_mensal*0.1)+(renda_mensal*taxa)<<"\n\n";
				}else if(renda_mensal >7060 and renda_mensal<= 9884){
					taxa = num_dependentes * 0.05;
					cout<<"Imposto final: R$"<<(renda_mensal*0.15)+(renda_mensal*taxa)<<"\n\n";
				}else{
					taxa = num_dependentes * 0.05;
					cout<<"Imposto final: R$"<<(renda_mensal*0.2)+(renda_mensal*taxa)<<"\n\n";
				}
            	system("pause");
                break;
            };
            case 3: {
            	int pontuacao = 0;
            	
                string perguntas[8] = {
				"1- Trocou mensagens com a vítima?",
				"2- Esteve no local do crime?",
				"3- É parente ou reside perto da vítima?",
				"4- Devia algum valor para a vítima?",
				"5- Trabalha ou trabalhou com a vítima?",
				"6- Possui algum tipo de relacionamento amoroso com a vítima?",
				"7- Ficou feliz pelo destino fatídico na vítima?",
				"8- Possui algum tipo de arma de fogo?"};
				
				for(i=0;i<8; i++){
				cout<<perguntas[i]<<"\nDigite:";
				cin>>op_investigacao;
					if(op_investigacao == 1){
						pontuacao++;
					}
				}
				if(pontuacao == 4){
					cout<<"\nSuspeito!\n\n";
				}else if(pontuacao >=5 and pontuacao<=7){
					cout<<"\nPossível Criminoso!\n\n";
				}else if(pontuacao >7){
					cout<<"\nCulpado!!!\n\n";
				}else{
					cout<<"\nInocente!\n\n";
				}
				system("pause");
                break;
            };
            case 4: {
            	double peso_total=0;
                do{
				cout<<"\nDigite o peso: ";
				cin>>peso_ex2;
					if (peso_total + peso_ex2 > 180){
						cout<<"Excederá o peso!"<<"\nPeso do momento: "<<peso_total<<"\n";
					}else if(peso_total >= 180){
						cout<<"Peso total atingido!";
					}else{
						peso_total = peso_total + peso_ex2;
					}
				} while(peso_total < 180);
				cout<<"Limite atingido!\n\n";
                system("pause");
                break;
            };
            case 5: {
            	double pesos[5];
                calculo=0;
            	for(i=1; i<=5; i++){
                cout<<"Digite o peso da "<<i<<"ª pessoa: ";
                cin>>pesos[i];
                calculo = calculo + pesos[i];
				}
				cout<<"\nA média de peso das 5 pessoas é: "<<calculo/5<<"\n\n";
                system("pause");
                break;
            };
            case 6: {
				const int MAX = 1;
            	string teste = "*";
            	
            	for(int i=0; i<=MAX; i++){
			    	for(int i=0; i<=MAX; i++){
			    		cout<<"\n"+teste;
			    		teste += "*";
					}		    	
			    	for(int i=0; i<=MAX; i++){	
			    		cout<<"\n"+teste;
			    		teste = "*";
					}teste += "*";
				}
				system("pause");
                break;
            };
            case 7: {
                cout<<"Finalizando";
                sleep(1);
                system("cls");
                break;
            };
            default:
                cout<<"\nOpção inválida. Escolha outro número!";
                sleep(1);
                break;
        }
    }while(op != 7);
    cout<<"\n\n\n\n\n - Até mais \n\n\n\n\n";
}

