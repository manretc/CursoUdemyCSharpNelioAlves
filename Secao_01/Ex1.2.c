#include <stdio.h>
#include <math.h>


int main(){
	
	float raio;
	float pi = atan(1)*4;
	

	printf("\nDigite o raio: \n");
	scanf("%f", &raio);
	
	printf("\nO valor da area e: %.4f\n", (pi*pow(raio,2)));
	
		
	return 0;
}
