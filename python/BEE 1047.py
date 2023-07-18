horaInicial, minutoInicial, horaFinal, minutoFinal = map(int, input().split())

duracaoHoras = horaFinal - horaInicial
duracaoMinutos = minutoFinal - minutoInicial

if duracaoMinutos < 0:
    duracaoMinutos += 60
    duracaoHoras -= 1
elif duracaoMinutos == 0 and duracaoHoras == 0:
    duracaoHoras += 24

if duracaoHoras < 0:
    duracaoHoras += 24

print(f"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)")
