from random import shuffle

aluno1 = str(input('Digite o nome do primeiro aluno 1º '))
aluno2 = str(input('Digite o nome do segundo  aluno 2º '))
aluno3 = str(input('Digite o nome do terceiro aluno 3º '))
aluno4 = str(input('Digite o nome do quarto   aluno 4º '))

# Aqui foi a maneira que eu fiz
# print('A ordem de sorteados para apresentação  é  {} '.format(random.sample([aluno1, aluno2, aluno3, aluno4], k=4)))

lista = [aluno1, aluno2, aluno3, aluno4]

print('A ordem de sorteados para apresentação será ')

shuffle(lista)

print(lista)
