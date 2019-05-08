distancia = float(input('Qual a distância da viagem em KM? '))
print('Você está prestes a iniciar uma viagem de {:.1f}Km.'.format(distancia))

preco = distancia * 0.50 if distancia <= 200 else  distancia * 0.45

'''if distancia <= 200:
    preco = distancia * 0.50
else:
    preco = distancia * 0.45'''

print('E o preço da sua passagem será de R${:.1f}'.format(preco))
