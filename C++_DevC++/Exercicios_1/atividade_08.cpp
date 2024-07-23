#include <iostream>
using namespace std;

main(){
	system("chcp 65001");
	system("cls");
	
	int num;
	
	cout<<"Digite um número: ";
	cin>>num;
	
	for(int i = 0; i<=10; i++){
		cout<<num<<"x"<<i<<" = "<<num*i<<"\n";
	}
}