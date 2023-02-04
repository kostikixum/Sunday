import math
s = int(input("Summa: "))
p = int(input("Proizvedenie: "))
a=1
b=-s
c=p
dis=b*b-4*a*c
if dis < 0.000001:
    x=(-b // 2*a)
else:
    x=((-b + math.sqrt(dis)) // (2*a))
 
y=s-x
print(x)
print(y)