while True:
    n = int(input())
    if n == 0:
        break

    resultados = list(map(int, input().split()))

    maryWins = resultados.count(0)
    johnWins = resultados.count(1)

    print(f"Mary won {maryWins} times and John won {johnWins} times")
