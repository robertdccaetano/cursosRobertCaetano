from os import system
system('cls' if system == 'nt' else 'clear')
peso = float(input('Digite seu peso: (Kg) '))
altura = float(input('Digite sua altura: (m) '))
imc = peso / (altura ** 2)
print('O IMC dessa pessoa é de {:.1f}'.format(imc))
if imc < 18.5:
    print('Você se encontra ABAIXO DO PESO!')
#elif imc >= 18.5 and imc < 25: MODO TRADICIONA DE SER FEITO
#elif 18.5 <= imc < 25: MODO REPRESENTAÇÂO MÀTEMÁTICA DO PYTHON
elif 18.5 <= imc < 25:
    print('Voce se encontra no PESO IDEAL!')
elif 25 <= imc < 30:
    print('Voce está SOBREPESO!')
elif 30 <= imc < 40:
    print('Voce está em OBESIDADE!')
elif imc >= 40:
    print('Seu estado é de OBESIDADE MÓRBIDA, cuidado!!!')
#else:
 #   print('Seu estado é de OBESIDADE MÓRBIDA!')
