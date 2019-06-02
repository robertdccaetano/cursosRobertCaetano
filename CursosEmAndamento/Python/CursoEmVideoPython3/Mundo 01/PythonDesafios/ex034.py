sal = float(input('Qual o valor do salário? R$'))
if sal > 1250:
    novo = sal + (sal * 10) / 100
else:
    novo = sal + (sal * 15) / 100
print('Quem ganhava R${:.2f} agora passa a ganhar R${:.2f} '.format(sal, novo))
