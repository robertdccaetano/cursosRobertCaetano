valCasa = float(input('Valor da casa: R$'))
salComp = float(input('Qual o salário do comprador: R$'))
anoFina = int(input('Quantos anos de financiamento? '))
presta = valCasa / (anoFina * 12)
print('Para pagar uma casa no valor de R${:0.2f} em '.format(valCasa), end='')
print('{} anos a prestação será de R${:0.2f} '.format(anoFina, presta))
if presta > salComp * 30 / 100:
    print('Empréstimo NEGADO!!')
else:
    print('Empréstimo pode ser CONCEDIDO!')
