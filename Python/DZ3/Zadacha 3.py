point = {
        1:'AEIOULNSTR���������',
      	2:'DG������',
      	3:'BCMP�è��',
      	4:'FHVWY��',
      	5:'K�����',
      	8:'JZ���' ,
      	10:'QZ���',}
text = input("vvedide slovo: ").upper()
print(sum([x for i in text for x, y in point.items() if i in y]))