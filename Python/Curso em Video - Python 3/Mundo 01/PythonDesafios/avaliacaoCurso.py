from datetime import date
from random import randint,choice

'''
frase = 'Curso em Vídeo de Python'
separado = frase.split()
palavra = separado[2]
letra = palavra[3]
print(letra.upper())

texto = 'Tres Pratos de Trigo para Tigres Tristes'
total = texto.upper().count(texto[0])
print(total)

len(texto)

n1 = 5

preco = 20

preco += preco * 35 / 100
print(preco)

n1 = 5
n2 = 2
res = n1 / n2 // 1
res1 = 5 * 3 ** 2
print(res1)


nome = 'Joao dos Anjos Moura'
print(nome[1:10:2].upper())

ano = date.today().month
print(ano)

n = [2, 5, 9, 1, 4]
sobra = choice(n) % n[0]
print(sobra)'''

texto = 'Tres Pratos de Trigo para Tigres Tristes'
total = texto.upper().count(texto[0])
print(total)

preco = 1000
novo = preco + 50 if preco <= 1000 else preco - 35
print(preco)

num = '7'
res = int(num) / 2
print(type(res))

name = 'Gustavo Guanabara'
print(name.split())

num = randint(1, 6)
res = num // 2
print(res)

print('''Curso em video''')
