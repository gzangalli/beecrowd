""" Diferença
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada
O arquivo de entrada contém 4 valores inteiros.

Saída
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
Exemplos de Entrada	
5
6
7
8
Exemplos de Saída
DIFERENCA = -26 """

a = int(input())
b = int(input())
c = int(input())
d = int(input())

produto = (a * b - c * d)

print(f'DIFERENCA = {produto}')