point = {
        1:'AEIOULNSTRÀÂÅÈÍÎĞÑÒ',
      	2:'DGÄÊËÌÏÓ',
      	3:'BCMPÁÃ¨Üß',
      	4:'FHVWYÉÛ',
      	5:'KÆÇÕÖ×',
      	8:'JZØİŞ' ,
      	10:'QZÔÙÚ',}
text = input("vvedide slovo: ").upper()
print(sum([x for i in text for x, y in point.items() if i in y]))