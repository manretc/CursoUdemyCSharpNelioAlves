#include <stdio.h>
#include <stdbool.h>


int main(){
	
	int senha=2002, tentativa=0;
	bool senha_valida = false;
	
	while(!senha_valida){
		printf("Digite a senha: \n");
		scanf("%d", &tentativa);
		senha_valida = (senha==tentativa);
		if (senha_valida) {
			printf("\nAcesso Permitido.\n");
		} else printf("\nSenha Invalida.\n");
	}
	
	
	return 0;
}
