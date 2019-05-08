velocidade = int(input('Qual a velocidade atual do carro? '))
if velocidade > 80:
    multa = (velocidade - 80) * 7
    print('MULTADO! Você excedeu o limite permitido que é de 80Km/h!')
    print('Voce deve pagar uma multa de R${:.2f}!'.format(multa))
print('Dirija com segurança!')
