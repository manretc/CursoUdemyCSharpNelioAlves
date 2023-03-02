#include <stdio.h>
#include <math.h>


int main(){
	
	float preco[6];
	int cod, num;
	
	preco[0]=0.0;
	preco[1]=4.0;
	preco[2]=4.5;
	preco[3]=5.0;
	preco[4]=2.0;
	preco[5]=1.5;



	printf("\nDigite o codigo do item:\n");
	scanf("%d", &cod);
	
	printf("\nDigite quantidade de itens %d:\n", cod);
	scanf("%d", &num);
	
	printf("\nO valor a ser pago e: %.2f\n", num*preco[cod]);
	
		
	return 0;
}
