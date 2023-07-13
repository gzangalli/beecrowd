n = int(input())

for _ in range(n):
    sobrenome = input()

    countConsoantesConsecutivas = 0
    ehFacil = True

    for i in range(len(sobrenome)-2):
        if sobrenome[i].lower() not in "aeiou" and sobrenome[i+1].lower() not in "aeiou" and sobrenome[i+2].lower() not in "aeiou":
            ehFacil = False
            break

    if ehFacil:
        print(f"{sobrenome} eh facil")
    else:
        print(f"{sobrenome} nao eh facil")
