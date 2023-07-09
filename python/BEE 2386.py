Telescopio = int(input())
numEstrelas = int(input())

estrelasVisiveis = 0

for i in range(numEstrelas):
    fotons = int(input())
    if fotons * Telescopio >= 40000000:
        estrelasVisiveis += 1

print(estrelasVisiveis)
