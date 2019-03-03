from math import fabs
r1 = float(input('Entre com o valor da 1 reta: '))
r2 = float(input('Entre com o valor da 2 reta: '))
r3 = float(input('Entre com o valor da 3 reta: '))

if fabs(r2 - r3) < r1 < r2 + r3:
    if fabs(r1 - r3) < r2 < r1 + r3:
        if fabs(r1 - r2) < r3 < r1 + r2:
            print('É possível formar um triangulo através desses valores!')
else:
    print('Não é possível formar um triângulo!')

'''result = 8 - 10
print('Resultado é {:.0f}'.format(fabs(result)))'''
