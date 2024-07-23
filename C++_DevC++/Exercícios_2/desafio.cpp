#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	double soma = 0,menor_nota=0,maior_nota=0;
	int qtd_alunos;
	int vetor[qtd_alunos];
	
	cout<<"Digite a quantidade de alunos: ";
	cin>>qtd_alunos;
	
	for(int i=1; i<=qtd_alunos; i++){
	cout<<"Digite a nota do "<<i<<"º aluno: ";
	cin>>vetor[i];
	
	soma = soma + vetor[i];
	
	if(vetor[i] > maior_nota){
			maior_nota = i;
		}else if(vetor[i] < maior_nota){
			menor_nota = i;
		} 	
	}
	cout<<"\nAluno com maior nota: "<<maior_nota;
	cout<<"\nAluno com menor nota: "<<menor_nota+1;
	cout<<"\nA média final das notas é: "<<(soma)/qtd_alunos;
}