frase = 'Curso em Vídeo Python'
# Aqui da erro pois string é imutável só e possível 'mutar' com replace -> frase[0] = 'J'
#print(frase.upper().count('O'))
print(len(frase.strip()))
#print(frase.replace('Python', 'Android'))
#frase = frase.replace('Python', 'Android')
#print(frase)
#print('Curso' in frase)
#print(frase.lower().find('vídeo'))

dividido = frase.split()
print(dividido[0])

#print('''O amor é paciente, o amor é bondoso.
#Não inveja, não se vangloria, não se orgulha.
#Não maltrata, não procura seus interesses, não se ira facilmente, não guarda rancor.
#O amor não se alegra com a injustiça, mas se alegra com a verdade.
#Tudo sofre, tudo crê, tudo espera, tudo suporta.''')

