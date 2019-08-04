import os
from datetime import date
os.system('cls' if os.system == 'nt' else 'clear')
anoNasc = int(input('Ano de nascimento: '))
ano = date.today().year
if anoNasc >= ano or anoNasc < 1909:
    print('Data de NASCIMENTO INVÁLIDA!')
else:
    idade = ano - anoNasc
    print('O atleta tem {} anos: '.format(idade))
    if  idade <= 9:
        print('Sua categoria é MIRIN!')
    elif idade <= 14:
        print('Sua categoria é INFANTIL!')
    elif idade <= 19:
        print('Sua categoria é JUNIOR!')
    elif idade <= 25:
        print('Sua categoria é SÊNIOR!')
    elif idade > 25:
        print('Sua categoria é MASTER!')
    else:
        print('Idade INVÁLIDA!')
