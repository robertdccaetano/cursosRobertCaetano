from random import randint
from time import sleep

print('\033[1;33m' '-=-' * 20)
print('\033[1;34m' 'Vou pensar em um número de 0 a 5. Tente adivinhar...')
print('\033[1;33m' '-=-' * 20)
computador = randint(0, 5)
jogador = int(input('\033[0;0m' 'Em que número eu pensei? '))
print('\033[1;95m' 'PROCESSANDO...')
sleep(3)
if jogador == computador:
    print('\033[1;33m' 'Parabéns você acertou, realmente pensei no número {}!'.format(computador))
else:
    print('\033[1;31m' 'Você ERROU! Pensei no número {}, humanos sem chances para vocês...!'.format(computador))
