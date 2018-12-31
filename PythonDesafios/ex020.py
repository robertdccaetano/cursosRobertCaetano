import random

aluno1 = input('Digite o nome do primeiro aluno 1º ')
aluno2 = input('Digite o nome do segundo  aluno 2º ')
aluno3 = input('Digite o nome do terceiro aluno 3º ')
aluno4 = input('Digite o nome do quarto   aluno 4º ')

print('A ordem de sorteados para apresentação  é  {} '.format(random.sample([aluno1, aluno2, aluno3, aluno4], k=4)))