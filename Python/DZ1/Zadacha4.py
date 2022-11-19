n = int(input("Razmer shokoladki po vertikali: "))
m = int(input("Razmer shokoladki po gorizontali: "))
k = int(input("skolko dolek otlomit: "))
if k < n * m and ((k % n == 0) or (k % m == 0)):
    print('YES')
else:
    print('NO')