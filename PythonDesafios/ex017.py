import math
catoposto = float(input('Digite o valor do cateto oposto: '))
catadcente = float(input('Digite o valor do cateto adjacente: '))
hipo = ((catoposto ** 2) + (catadcente ** 2))
print('O quadrado da hipotenusa é {:.2f}'.format(math.sqrt(hipo)))
