import datetime
import os
os.system('cls' if os.name == 'nt' else 'clear')
anoAtual = datetime.date.today().year
print('-+-'*5,'SISTEMA MILITAR','-+-'*5)
sexo = str(input('Digite seu sexo [M/F]: '))
if sexo ==  'm' or sexo == 'M':
    anoNasc = int(input('Digite seu ano de nascimento: '))
    idade =  anoAtual - anoNasc
    print('Quem nasceu em {} tem {} ano(s) em {}.'.format(anoNasc, idade, anoAtual))
    if idade == 18:
        print('Já está na HORA de se ALISTAR!')
    elif idade < 18:
        #idade = 18 - idade
        #anoAtual += idade
        saldo = 18 - idade
        ano = saldo + anoAtual
        print('Ainda faltam {} ano(s) para o alistamento'.format(saldo))
        print('Você irá se alistar em {}.'.format(ano))
    elif idade >  18:
        #idade  -= 18
        #anoAtual -= idade
        saldo  = idade - 18
        ano = anoAtual - saldo
        print('Você deveria ter se alistado há {} ano(s)'.format(saldo))
        print('Seu alistamento foi em {}.'.format(ano))
elif sexo == 'f' or sexo == 'F':
    print('Pessoas do SEXO FEMININO não se encaixam no alistamento obrigatório!')
else:
    print('Valor de gênero incorreto!')