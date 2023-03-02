#include <stdio.h>
#include <math.h>


int main(){
	
	float a, b, c, delta, x1, x2;
	printf("\nDigite o valor de a: ");
	scanf("%f", &a);
	printf("\nDigite o valor de b: ");
	scanf("%f", &b);
	printf("\nDigite o valor de c: ");
	scanf("%f", &c);
	
	delta=pow(b,2)-4*a*c;
	
	if(a!=0 && delta>=0){
		x1=(-b+sqrt(delta))/(2*a);
		x2=(-b-sqrt(delta))/(2*a);
		printf("\nx1 = %.5f\n", x1);
		printf("\nx2 = %.5f\n", x2);

	} else printf("\nImpossivel calcular.\n");
	
	
	return 0;
}
