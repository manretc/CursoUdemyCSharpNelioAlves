#include <stdio.h>
#include <stdbool.h>


int main(){
	
	int n=0, x=0, in=0, out=0;
	printf("\nDigite a quantidade de valores n: ");
	scanf("%d", &n);
	
	while(n>0){
		printf("\nDigite o valor de x%d: ", n);
		scanf("%d", &x);
		if(x<10 || x>20) out++;
		else in++;
		
		n--;
	}
	
	printf("\nValores in: %d\nValores out: %d\n", in, out);
	
	
	
	
	return 0;
}
