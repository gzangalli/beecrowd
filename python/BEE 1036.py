import math


def calcularRaizes(a, b, c):
    delta = b**2 - 4*a*c

    if delta < 0 or a == 0:
        return None

    raiz1 = (-b + math.sqrt(delta)) / (2*a)
    raiz2 = (-b - math.sqrt(delta)) / (2*a)
    return raiz1, raiz2


a, b, c = map(float, input().split())

raizes = calcularRaizes(a, b, c)


if raizes is None:
    print("Impossivel calcular")
else:
    raiz1, raiz2 = raizes
    print(f"R1 = {raiz1:.5f}")
    print(f"R2 = {raiz2:.5f}")
