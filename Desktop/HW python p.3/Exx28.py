def SumNumber (a,b):
    summa = a
    if b !=0 :
        summa = SumNumber(summa + 1, b -1)
        return summa 
    else : return summa

a = int(input("Введите число : "))        
b = int(input("Введите число : ")) 

print(f"Сумма чисел равна {SumNumber(a,b)}")