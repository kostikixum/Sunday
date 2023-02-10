input("vvedide razmer: ")
lst = map(int, (input("vvedide massiv: ").split()))
n = int(input("vvedide element: "))
k = 0
min=n;
for i in lst:        
   y=n-i
   if y<0:
       y=y*-1
   if y<min:
       min=y
       s=i
print(s)