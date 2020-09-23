/*1- Fazer um algoritmo que imprima todos os números pares no intervalo de 1 a 100;*/

using System;
public class Ex01 {
public static void Main(String[] args) {
	for (int n = 1; n <= 100; n++) {
		if (n % 2 == 0) {
			Console.WriteLine(n);
		}
	}
}} // funciona