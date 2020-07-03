from math import sin, cos, tan, radians

ang = float(input('Entre com o valor do ângulo: '))
print('O valor do cosseno do ângulo é {:.2f}'.format(cos(radians(ang))))
print('O valor do seno desse ângulo é {:.2f}'.format(sin(radians(ang))))
print('O valor da tangente desse ângulo é {:.2f}'.format(tan(radians(ang))))
