from os import system
system('cls' if system == 'nt' else 'clear')
#print('-|' * 4, 'LOJAS TECSTORE', '|-' * 4, '\n')
print('{:-^40}'.format(' LOJAS TECSTORE '))
valProduto = float(input('Valor das compras: R$'))
#print('\n','---' * 10)
print('{:-^35}'.format('-'))
print('     FORMAS DE PAGAMENTO')
#print('---' * 10)
print('{:-^35}'.format('-'))
#OUTRA FORMA DE PRINTAR O MENO
#print('''FORMAS DE PAGAMENTO
#[ 1 ] à vista dinheiro/cheque
#[ 2 ] à vista cartão
#[ 3 ] 2x no cartão
#[ 4 ] 3x ou mais no cartão''')
print('[ 1 ] à vista dinheiro/cheque\n'
      '[ 2 ] à vista cartão\n'
      '[ 3 ] 2x no cartão\n'
      '[ 4 ] 3x ou mais no cartão')
opcao = int(input('Qual é a opção? '))
if opcao == 1:
    valNovo = valProduto - valProduto * 10 / 100
    print('\nOpção 1 - à vista dinheiro/cheque recebendo 10% de desconto.')
elif opcao == 2:
    valNovo = valProduto - valProduto * 5 / 100
    print('\nOpção 2 - à vista cartão recebendo 5% de desconto.')
elif opcao == 3:
    valNovo = valProduto
    parcelas = valNovo / 2
    print('\nOpção 3 - 2x no cartão selecionada.')
    print('Sua compra será parcelada em 2x de R${:.1f} SEM JUROS.'.format(parcelas))
elif opcao == 4:
    valNovo = valProduto + valProduto * 20 / 100
    parcelas = int(input('\nQuantas parcelas? '))
    valorParcelado = valNovo / parcelas
    print('Sua compra será parcelada em {}x de R${:.1f} COM JUROS'.format(parcelas, valorParcelado))
else:
    valNovo = valProduto
    print('Opção inválida de PAGAMENTO. Tente novamente!')
print('Sua compra de R${:.2f} vai custar R${:.2f} no final.\n'.format(valProduto, valNovo),'\n')
#print('Atualizando novo valor da compra... [ R${:.1f} ]\n'.format(valNovo))
