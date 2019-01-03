from random import shuffle

aluno1 = input('Digite o nome do primeiro aluno 1º ')
aluno2 = input('Digite o nome do segundo  aluno 2º ')
aluno3 = input('Digite o nome do terceiro aluno 3º ')
aluno4 = input('Digite o nome do quarto   aluno 4º ')

# Aqui foi a maneira que eu fiz
# print('A ordem de sorteados para apresentação  é  {} '.format(random.sample([aluno1, aluno2, aluno3, aluno4], k=4)))

lista = [aluno1, aluno2, aluno3, aluno4]
print('A ordem de sorteados para apresentação é')
shuffle(lista)
print(lista)
