n = int(input())

for _ in range(n):
    eventos = input().split()
    minutos = int(eventos[0])
    half = eventos[1]

    if half == "1T":
        tempo = minutos
        if tempo > 45:
            tempo = f"45+{tempo-45}"
    else:
        tempo = 45 + minutos
        if tempo > 90:
            tempo = f"90+{tempo-90}"

    print(tempo)
