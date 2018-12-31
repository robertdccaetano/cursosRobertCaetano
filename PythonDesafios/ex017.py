import math
catoposto = float(input('Digite o valor do cateto oposto: '))
catadjacente = float(input('Digite o valor do cateto adjacente: '))
hipo = ((catoposto ** 2) + (catadjacente ** 2))
print('O quadrado da hipotenusa é {:.2f}'.format(math.sqrt(hipo)))
