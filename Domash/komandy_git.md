### �������� ������� ��� ������ � GIT 
����� ������� ������� Git ����� ���������� ���������

 ��������� ��� ��� ������ ������������

������ <����_���> ����� ������, ��������, Petr Perviy

������� ���������
    
    git config --global user.name "<����_���>"

������ ��������� email. ������� ��� ��.

    git config --global user.email "<�����_�����@email.com>"

### ����� ������� ������ �����������

��� ����� ������� ����� ����� � ����� ����� � ��� �������� �������

    git init 

 ��������� .

 ������� � ����� ����� ���� txt 

 ����� ������ ������� 

     git status

� ����� ��� � ��� ���� ����,�� �������� � ��� ���� �� ��������������.

��� ����� ���� ������ �������

     git add <name fail> 

![������ ���������� ������� add!](gitadd.jpg )[������ ���������� �������]  

��� �������� ��������� ������������� �������
git commit -m [*�������� ����� ����������*]

��� �������� ��������� ������������� ������� 

     git commit -m [�������� ����� ����������]

��� ��������� ���� ������� ������������ �������

     git log

������ ���������� ������� git log[������ ���������� �������]

![������ ���������� ������� git log](gitlog.jpg)[������ ���������� �������]

    git reflog - ���������� ������ ���������� ��������� 

![������ ���������� ������� gif reflog!](gitreflog.jpg)

    git diif- ����������� �������� ����� ����� ������������

![������ ���������� ������� gif diff](gitdiff.jpg)[������ ���������� �������]

### ������ � ���������� ������������� 

����� ������ ����������� � ������� ����� �������� 

*������* ![���������!](1.png) 

������ Fork ������� � ���� �����������

������![������ Fork ������� � ���� �����������!](2.png )

������ ���� ����������� � VS 

    git clon <https://github.com/.......>

*������* ![ git clo](3.png)

��������� � �������������� (����� ���������� � �����������) � ��� ��������� �� ��������

������� ��� ����� ����� � ��������� ����

    git barnch <name_branch> 

����� ����� ������� � ������� � ����� ����� ��� ��� ���������� ��� 

    git checkout -b <newbranchname>

������ ![git barnch <*�������� �����*>!](4.png)

��������� ���� ��� ������������

    git add <name_fail> 

������ ![it add <*��� �����*>!](5.png)

������ ��������� � ���� � ������� ����� ���� ���������

    git commit <name_comit>

������ ![it commit�!](5.png)

������ ���������� ��� ��������� � ���� github �� ����� � ������� ������������� ���������

     git push origin <name branch>

������ ![git push origin <��� �����>](6.png)

���� � ������ � ������ ��� pull recvest � �������� �����������

������ ![pull recvest!](7.png)

����� ��� ��������� ���������� � ��������� ��� ,��� ��� ����� ������������� � ���� ����������� ����� ������

������ ![����� ���������� � ����������!](8.png)

����� ������� ������ create pull request ���� � ����������� ������������ � �������� ������ ������ �� ��� � �����. ��� �������� ����� ���������� ��������� � �������� ��� ��� �������. ������ merge � ����� ��� ����������. 
��� ���� ��� ���������� � ������. ���� �� ���� �������� ��������� ��� �� ��� � ������ ������� � ��������� �����������.

��� ���� ��� �� �� ������ ������ ����� , �������������� ������� ���� , ������� ����� �� ������������.

���� ������ ��������� *.gitignore*