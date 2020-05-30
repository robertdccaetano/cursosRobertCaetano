from os import system
from time import sleep as wait
import random
system('cls' if system == 'nt' else 'clear')
itens = ('Pedra', 'Papel', 'Tesoura')
computador = random.randint(0, 2)
print('''Suas opções:
[ 0 ] PEDRA
[ 1 ] PAPEL
[ 2 ] TESOURA''')
jogada = int(input('Qual é a sua jogada? '))
print('JO')
wait(1)
print('KEN')
wait(1)
print('PO!!!')
print('-=' * 11)
print('Computador jogou {}'.format(itens[computador]))
print('Jogador jogou {}'.format(itens[jogada]))
print('-=' * 11)
if jogada == 0 and computador == 2 or jogada == 1 and computador == 0 or jogada == 2 and computador == 1:
    print('JOGADOR VENCE!\n')
elif jogada == 0 and computador == 0 or jogada == 1 and computador == 1 or jogada == 2 and computador == 2:
    print('TEMOS UM EMPATE!\n')
elif jogada == 0 and computador == 1 or jogada == 1 and computador == 2 or jogada == 2 and computador == 0:
    print('COMPUTADOR VENCE!\n')
else:
    print('JOGADA INVÁLIDA!\n')
