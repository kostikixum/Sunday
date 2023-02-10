input("vvedide razmer: ")
lst = map(int, (input("vvedide massiv: ").split()))
n = int(input("vvedide element: "))
k = 0
for i in lst:        
    if i == n:
        k += 1
print(k)