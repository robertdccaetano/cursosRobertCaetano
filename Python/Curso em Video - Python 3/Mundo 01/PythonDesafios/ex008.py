m = float(input("Digite o valor em metros: "))
# cm = m/0.010000

print("{} Metro(s) corresponde a {}Km a {}Hm a {:.1f}Dam a {:.0f}dm a {:.0f}cm a {:.0f}mm !"
      .format(m, m * 0.001, m * 0.01, m * 0.1, m * 10, m * 100, m * 1000))
