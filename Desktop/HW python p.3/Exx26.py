
n = int(input("Введите число,факториал которого необходимо найти :"))
k = int(input("Введите число,треугольное число которого необходимо найти :"))
def FactorialNumber (n) :
    if n==1 : return 1 
    return FactorialNumber(n-1) * n
        

def TrioNumber (k):
    if k == 1: return 1
    else:
        k =(k + 1) * k / 2
    print (f"Треугольное число равно : {k}")    


rezult = FactorialNumber(n)
print(f"Факториал числа равен : {rezult}")
TrioNumber(k)

   
