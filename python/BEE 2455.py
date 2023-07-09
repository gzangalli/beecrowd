P1, C1, P2, C2 = map(int, input().split())

equilibrio = P1 * C1 - P2 * C2

if equilibrio == 0:
    print(0)
elif equilibrio > 0:
    print(-1)
else:
    print(1)
