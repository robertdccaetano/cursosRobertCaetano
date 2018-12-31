import math

ang = float(input('Entre com o valor do ângulo: '))
print('O valor do cosseno do ângulo é {:.2f}'.format(math.cos(math.radians(ang))))
print('O valor do seno desse ângulo é {:.2f}'.format(math.sin(math.radians(math.ceil(ang)))))
print('O valor da tangente desse ângulo é {:.2f}'.format(math.tan(math.radians(ang))))
