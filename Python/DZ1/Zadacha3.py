n = input("Vvedite nomer bileta(6 cifr): ")
n = int(n)
 
num6 = n%10
n=n//10
num5 = n%10
n=n//10
num4 = n%10
n=n//10
num3 = n%10
n=n//10
num2 = n%10
n=n//10
num1 = n%10
n=n//10
sum1=num1+num2+num3
sum2=num4+num5+num6
if sum1 == sum2:
    print("YES")
else:
    print("NO")