n, m = map(int, input().split())

contadorAbas = n

for _ in range(m):
    acao = input().strip()
    if acao == "fechou":
        contadorAbas += 1
    elif acao == "clicou":
        contadorAbas -= 1

print(contadorAbas)
