import math

catoposto = float(input('Digite o valor do cateto oposto: '))
catadjacente = float(input('Digite o valor do cateto adjacente: '))

'''hipo = (catoposto ** 2 + catadjacente ** 2) ** 0.5
print('O quadrado da hipotenusa é {:.2f}'.format(hipo))'''

hi = math.hypot(catoposto, catadjacente)
print('A hipotenusa vai medir {:.2f}'.format(hi))
