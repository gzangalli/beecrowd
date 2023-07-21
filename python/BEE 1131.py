interWins = 0
gremioWins = 0
draws = 0
totalGames = 0

while True:
    interGoals, gremioGoals = map(int, input().split())

    totalGames += 1

    if interGoals > gremioGoals:
        interWins += 1
    elif gremioGoals > interGoals:
        gremioWins += 1
    else:
        draws += 1

    print("Novo grenal (1-sim 2-nao)")
    repeat = int(input())

    if repeat != 1:
        break

print(f"{totalGames} grenais")
print(f"Inter:{interWins}")
print(f"Gremio:{gremioWins}")
print(f"Empates:{draws}")

if interWins > gremioWins:
    print("Inter venceu mais")
elif gremioWins > interWins:
    print("Gremio venceu mais")
else:
    print("Nao houve vencedor")
