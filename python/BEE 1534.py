while True:
    try:
        n = int(input())
        
        matrix = [[3] * n for _ in range(n)]
        
        for i in range(n):
            for j in range(n):
                if i == j:
                    matrix[i][j] = 1
                elif i == n - j - 1:
                    matrix[i][j] = 2
        
        for row in matrix:
            print(''.join(map(str, row)))
        
        print()
    except EOFError:
        break
