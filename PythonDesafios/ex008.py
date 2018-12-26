m = float(input("Digite o valor em metros: "))
#cm = m/0.010000
cm = m*100
mm = cm*10
print("{:.0f} Metro(s) convertido em Centímetros é {:.0f}cm e para Milímetros é {:.0f}mm ".format(m, cm, mm))
