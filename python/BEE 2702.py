""" frangoDisponivel = int(input())
bifeDisponivel = int(input())
massaDisponivel = int(input())

frangoRequisitado = int(input())
bifeRequisitado = int(input())
massaRequisitado = int(input()) """

frangoDisponivel, bifeDisponivel, massaDisponivel = input().split()
frangoRequisitado, bifeRequisitado, massaRequisitado = input().split()

frangoDisponivel = int(frangoDisponivel)
bifeDisponivel = int(bifeDisponivel)
massaDisponivel = int(massaDisponivel)

frangoRequisitado = int(frangoRequisitado)
bifeRequisitado = int(bifeRequisitado)
massaRequisitado = int(massaRequisitado)

faltante = 0

if frangoRequisitado > frangoDisponivel:
    faltante += frangoRequisitado - frangoDisponivel

if bifeRequisitado > bifeDisponivel:
    faltante += bifeRequisitado - bifeDisponivel

if massaRequisitado > massaDisponivel:
    faltante += massaRequisitado - massaDisponivel

print(faltante)
