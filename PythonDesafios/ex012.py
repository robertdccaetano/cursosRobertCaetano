pr = int(input("Digite o valor do produto: R$"))
pr = pr - pr * (15/100)
print("O preço deste produto com desconto de 15% é R${:.2f}".format(pr))
