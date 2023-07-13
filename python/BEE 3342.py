n = int(input())

totalCasas = n * n
casasBrancas = casasPretas = totalCasas // 2

if totalCasas % 2 != 0:
    casasBrancas += 1

print(f"{casasBrancas} casas brancas e {casasPretas} casas pretas")
