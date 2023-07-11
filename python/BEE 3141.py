from datetime import datetime


def calcularIdade(dataNascimento, dataAtual):
    dataNascimento = datetime.strptime(dataNascimento, "%d/%m/%Y")
    dataAtual = datetime.strptime(dataAtual, "%d/%m/%Y")
    idade = dataAtual.year - dataNascimento.year
    if dataAtual.month < dataNascimento.month or (dataAtual.month == dataNascimento.month and dataAtual.day < dataNascimento.day):
        idade -= 1
    return idade


nome = input()
dataAtual = input()
dataNascimento = input()

# pega apenas o dia e o mes da data atual
dataAtualDiaMes = dataAtual[0:5]
dataNascimentoDiaMes = dataNascimento[0:5]
if dataAtualDiaMes == dataNascimentoDiaMes:
    print("Feliz aniversario!")

idade = calcularIdade(dataNascimento, dataAtual)

print("Voce tem", idade, "anos", nome + ".")
