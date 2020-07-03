import os
os.system('cls' if os.system == 'nt' else 'clear')
print('-|-' * 6, 'SISTEMA DE NOTAS', '-|-' * 6)
n1 =  float(input('Digite a 1ª nota: '))
n2 =  float(input('Digite a 2ª nota: '))
media = (n1 + n2) / 2
print('Tirando {:.1f} e {:.1f}, a média do aluno é {:.1f} então...'.format(n1, n2, media))
if media < 5.0:
    print('Você foi reprovado!')
#elif 6.9 > media >= 5: <- Esse é o modo que o Python aceita exclusivamente!
elif media >= 5 and media <= 6.9:
    print('Você está de recuperação!')
elif media >= 7:
    print('Voce foi APROVADO!')
