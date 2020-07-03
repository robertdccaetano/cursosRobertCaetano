larg = float(input("Digite a largura: "))
alt = float(input("Digite a altura : "))
area = larg * alt
tinta = area / 2
print('Sua parede é de dimensões {} x {} possuindo área de {}m². '.format(larg, alt, area))
print('Para pintar sua parede você precisará de {}l de tinta.'.format(tinta))
