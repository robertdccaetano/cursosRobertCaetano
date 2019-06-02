n1 = int(input('Digite o primeiro valor: '))
n2 = int(input('Digite o segundo  valor: '))
if n1 > n2:
    print('\033[31mO 1º valor {} é maior que o 2º valor {}!'.format(n1, n2))
elif n2 > n1:
    print('\033[32mO 2º valor {} é maior que o 1º valor {}!'.format(n2, n1))
else:
    print('O primeiro valor {} é igual ao segundo {}!'.format(n1,n2))
