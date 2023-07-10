N = int(input())

pares = []
impares = []

for _ in range(N):
    valor = int(input())
    if valor % 2 == 0:
        pares.append(valor)
    else:
        impares.append(valor)

pares.sort()
impares.sort(reverse=True)

final = pares + impares

for valor in final:
    print (valor)