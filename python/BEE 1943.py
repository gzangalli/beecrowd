categorias = [1, 3, 5, 10, 25, 50, 100]

k = int(input())

for categoria in categorias:
    if k <= categoria:
        print(f"Top {categoria}")
        break
