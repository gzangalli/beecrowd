def determinar_vencedor(jogador1, jogador2):
    if jogador1 == "ataque" and jogador2 == "pedra":
        return "Jogador 1 venceu"
    elif jogador1 == 'ataque' and jogador2 == 'papel':
        return "Jogador 1 venceu"
    elif jogador1 == "pedra" and jogador2 == "papel":
        return "Jogador 1 venceu"
    elif jogador1 == "papel" and jogador2 == "ataque":
        return "Jogador 2 venceu"
    elif jogador1 == "papel" and jogador2 == "papel":
        return "Ambos venceram"
    elif jogador1 == "pedra" and jogador2 == "pedra":
        return "Sem ganhador"
    elif jogador1 == "ataque" and jogador2 == "ataque":
        return "Aniquilacao mutua"
    else:
        return "Jogador 2 venceu"


n = int(input())

for _ in range(n):
    jogador1 = input()
    jogador2 = input()

    resultado = determinar_vencedor(jogador1, jogador2)
    print(resultado)
