from os import system
from math import fabs
system('cls' if system == 'nt' else 'clear')
l1 =  float(input('Valor primeiro  lado: '))
l2 =  float(input('Valor segundo   lado: '))
l3 =  float(input('Valor terceiro  lado: '))
#OUTRA FORMA DE FAZER A CONDICIONAL, MAIS SIMPLIFICADA PARA ATENDER A CRIAÇÃO DE TRIANGULOS MATEMÁTICA
#if l1 < l2 + l3 and l2 < l1 + l3 and l3 < l1 + l2:
if  l1 + l2 > l3 > fabs(l1 - l2):
    if fabs(l2 - l3) < l1 < l2 + l3:
        if fabs(l3 - l1) < l2 < l3 + l1:
            print('Os segmentos acima formam um TRIÂNGULO ', end='')
            # O PYTHON ACEITA L1 == L2 == L3
            if l1 == l2 and l2 == l3:
                print('EQUILÁTERO!')
            #O PYTHON ACEITA L1 != L2 != L3 != L1
            elif l1 != l2 and l2 != l3 and l3 != l1:
                print('ESCALENO!')
            #elif l1 == l2 or l1 == l3 or l2 == l3:
            else:
                print('ISÓSCELES!')
else:
    print('Não é POSSÍVEL formar um triângulo!')
