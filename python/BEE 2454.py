posicoes = input().split()

P = int(posicoes[0])
R = int(posicoes[1])

if P == 1 and R == 1:
    print('A')
elif P == 1 and R == 0:
    print('B')
else:
    print('C')
