print('\033[4;30;45m Olá, mundo! \033[m')
print('\033[30m Olá, mundo! \033[m')
a = 3
b = 5
print('Os valore são \033[32m{} \033[me \033[31m{} \033[m!!!'.format(a,b))
nome = 'Robert'
cores = {'limpa': '\033[m',
         'azul': '\033[34m',
         'amarelo': '\033[1;33m',
         'pretoebranco': '\033[7;30m'}
print('Olá! Você vai conseguir ser o melhor programador {}{}{} !'.format(cores['amarelo'], nome, cores['limpa']))
print('Olá! Muito prazer em te conhecer, {}{}{}!!!'.format('\033[4;34m', nome, '\033[m'))
