using System;
public class Aula {
string s1 = "raphael";

string s2 = "phael";

int cont = 0;

for (int i = 0; i < s1.Length; i++) {

​	if (s2[cont] == s1[i]) {

​		cont++

​		var++

​		if 

​	} else {

​		var = 0;

}

}
}

bool BuscarString (string s1, string s2) {
	int i, j, aux, tam1, tam2;
	tam1 = s1.Length;
	tam2 = s2.Length;
	for (i = 0; i < tam1; i++) { // i passa pela string s1
		aux = 1;
		for (j = 0; j < tam2 && aux < tam1; j++) { // j passa pela string s2
		    if (s2[j] != s1[aux]) break;
		    aux++;
		}
		    if (j == tam2) return true; // significa que passou por tudo e não achou um caractere diferente
		}
		return false;
		}
	}