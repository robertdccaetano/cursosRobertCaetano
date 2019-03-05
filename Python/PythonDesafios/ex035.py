from math import fabs
from time import sleep
print('-=-' * 10)
print('Analisador de Triângulos')
print('-=-' * 10)
r1 = float(input('Primeiro segmento: '))
r2 = float(input('Segundo segmento: '))
r3 = float(input('Terceiro segmento: '))

if fabs(r2 - r3) < r1 < r2 + r3:
    if fabs(r1 - r3) < r2 < r1 + r3:
        if fabs(r1 - r2) < r3 < r1 + r2:
            print('Processando possibilidade...')
            sleep(3)
            print('É POSSÍVEL formar um triângulo através desses valores!')
else:
    print('\033[31mNÃO É POSSÍVEL formar um triângulo!\033[m')

#Solução do vídeo de correção do curso em vídeo
#if r1 < r2 + r3 and r2 < r1 + r3 and r3 < r1 + r2
