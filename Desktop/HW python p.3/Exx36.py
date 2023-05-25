
#Вводим исходный стих Пуха
line = input("Введите стих Пуха : ")
lines = line.split()
 
print(lines)
#Проверяем на количество гласных в каждом из элементов массива 
lst = [sum(x in 'уеыаоэяию' for x in lin)
 for lin in lines]
 
if len(set(lst)) == 1 :
    res = "Парам пам-пам"  
else: res = "Пам парам"
 
print(res)
