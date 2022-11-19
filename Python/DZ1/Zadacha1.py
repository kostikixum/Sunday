
n = input("vvedite trehznachnoe chislo: ")

n = int(n)
 
num1 = n % 10 

n = n // 10 

num2 = n % 10 

n = n // 10
 
print("summa chifr chisla:", n + num1+num2)