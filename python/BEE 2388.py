N = int(input())

distanciaTotal = 0

for i in range(N):
    intervalo = input().split()
    T = int(intervalo[0])
    V = int(intervalo[1])
    distanciaTotal += T * V

print(distanciaTotal)
