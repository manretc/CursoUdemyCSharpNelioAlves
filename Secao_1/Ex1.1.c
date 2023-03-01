#include <stdio.h>

int main(){
	
	int cod_p[2], num_p[2];
	float val_un_p[2], valor_total = 0;
	int n = 2, i;
	
	for(i=1; i<=n; i++){
		printf("\nDigite o codigo da peca %d:\n", i);
		scanf("%d", &cod_p[i-1]);
		
		printf("\nDigite o numero de pecas do codigo %d:\n", cod_p[i-1]);
		scanf("%d", &num_p[i-1]);
		
		printf("\nDigite o valor unitario da peca do codigo %d:\n", cod_p[i-1]);
		scanf("%f", &val_un_p[i-1]);
		
		valor_total+= num_p[i-1]*val_un_p[i-1];
	}
	
	printf("\nO valor total a ser pago e: %.2f\n", valor_total);
	
		
	return 0;
}
