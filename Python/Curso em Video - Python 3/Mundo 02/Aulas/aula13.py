import os
#Estruturas de repetição (FOR)
('cls' if os.system == 'nt' else 'clear')
'''for i in range(0, 7, 2):
    print(i)
print('FIM')'''

''' i = int(input('Inicio: '))
f = int(input('Fim: '))
p = int(input('Passo: '))

for c in range(i, f+1, p):
    print(c)
print('FIM')'''

s = 0 
for c in range(0, 4):
    n = int(input('Digite o valor: '))
    s += n

print('O somatorio de todos os valores foi {}'.format(s))
