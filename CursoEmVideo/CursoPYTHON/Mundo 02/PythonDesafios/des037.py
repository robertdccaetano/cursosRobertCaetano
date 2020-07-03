valor = int(input('Digite um número inteiro: '))
print('\nEscolha uma das bases para conversão:')
opc = int(input('[ 1 ] converter para BINÁRIO\n'
      '[ 2 ] converter para OCTAL\n'
      '[ 3 ] converter para HEXADECIMAL\n'
      'Sua opção:'))
if opc == 1:
    print('O número {} em binário é "{}"'.format(valor, bin(valor) [2:]))
elif opc == 2:
    print('O número {} em octal é "{}"'.format(valor, oct(valor)[2:]))
elif opc == 3 :
    print('O número {} em hexadecimal é "{}"'.format(valor, hex(valor)[2:]))
else:
    print('Opção inválida!')
