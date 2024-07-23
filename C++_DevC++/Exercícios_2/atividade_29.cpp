#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int vetor[15];
	for (int i = 0; i<15; i++){
		vetor[i] = rand() % 200;
		cout<<vetor[i]<<"\n";
	}
}