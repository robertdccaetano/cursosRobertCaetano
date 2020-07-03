km = float(input('Entre com os KMs percorrido: KM'))
dia = int(input('Quantos dias o carro ficou alugado? '))
preco = ((60 * dia) + (0.15 * km))
print('O preço do aluguel do carro baseado em dias utilizados e Km rodados é de R${:.2f}'.format(preco))
