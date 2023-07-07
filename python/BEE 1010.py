cod1, quant1, valor1 = input().split()
cod2, quant2, valor2 = input().split()

cod1 = int(cod1)
quant1 = int(quant1)
valor1 = float(valor1)

cod2 = int(cod2)
quant2 = int(quant2)
valor2 = float(valor2)

valorTotal = (quant1 * valor1) + (quant2 * valor2)

print(f'VALOR A PAGAR: R$ {valorTotal:.{2}f}')