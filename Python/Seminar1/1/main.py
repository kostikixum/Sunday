#������� ������� 
#1. �� ���� ������ ��������� n ����������. ������� ���� �����, 
#����� �������� ������� ������ m ����������? 
#��� ������� ���� ������ ������ ������������ �������� ����������� if � �������.

#**Input:**
#n = 700
#m = 750

#**Output:**

n = int(input('n = '))
m = int(input('m = '))
s = n/24
##print(round((m/s),2))
h=(m//s) # ������� ����� ����
d=h//24
m=h-(m/s)
print(h,d,m)