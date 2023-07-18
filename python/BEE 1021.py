valor = float(input())

notas = [100, 50, 20, 10, 5, 2]
moedas = [1, 0.50, 0.25, 0.10, 0.05, 0.01]

print("NOTAS:")
for nota in notas:
    qtdNotas = int(valor / nota)
    print(f"{qtdNotas} nota(s) de R$ {nota:.2f}")
    valor -= qtdNotas * nota

print("MOEDAS:")
for moeda in moedas:
    qtdMoedas = int(valor / moeda)
    print(f"{qtdMoedas} moeda(s) de R$ {moeda:.2f}")
    valor -= qtdMoedas * moeda
