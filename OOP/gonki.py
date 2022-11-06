from turtle import *
from random import randint
from time import *

finish=400 # Дистанция гонки
colormode(255)

t1=Turtle() # Создали объект класса черепашка
t1.shape('turtle') # Поменяли форму объекта

t1.color('red', 'green') # Поменяли цвет объекта
t1.color((randint(0,255),randint(0,255),randint(0,255))) # Поменяли цвет объекта
t1.penup() # Поднимаем, чтоб не рисовала
t1.goto(-400,20) # Перемещаем
t1.pendown() # опускаем, чтоб рисовала
t1.speed(10)

t2=Turtle() # Создали объект класса черепашка
t2.shape('turtle') # Поменяли форму объекта
t2.color((randint(0,255),randint(0,255),randint(0,255))) # Поменяли цвет объекта
t2.penup() # Поднимаем, чтоб не рисовала
t2.goto(-400,-20) # Перемещаем
t2.pendown() # опускаем, чтоб рисовала
t2.speed(0)

t3=Turtle() # Создали объект класса черепашка
t3.shape('turtle') # Поменяли форму объекта
t3.color((randint(0,255),randint(0,255),randint(0,255))) # Поменяли цвет объекта
t3.penup() # Поднимаем, чтоб не рисовала
t3.goto(-400,-60) # Перемещаем
t3.pendown() # опускаем, чтоб рисовала
t3.speed(5)

def razmetka(): # Функция рисования разметки поля
    t=Turtle() # Создали объект класса черепашка
    t.speed()
    for i in range(1,41):
        t.penup() # Поднимаем, чтоб не рисовала
        t.goto(-400+i*20,50) # Перемещаем
        t.pendown() # опускаем, чтоб рисовала
        t.goto(-400+i*20,-100) # Перемещаем
        t.hideturtle()

def catch1(x,y): # Обработка события нажатия
    t1.write('Ouch', font=('Arial', 14, 'normal'))
    t1.fd(randint(10,15)) # делает случайный шаг

def catch2(x,y): # Обработка события нажатия
    t2.write('Мне больно', font=('Arial', 14, 'normal'))
    t2.fd(randint(10,15)) # делает случайный шаг

    t1.onclick(catch1) # прикрепление к событию нажатия на черепашку 1 обработчика cath1
    t2.onclick(catch2) # прикрепление к событию нажатия на черепашку 2 обработчика cath2

razmetka()
while t1.xcor()<finish and t2.xcor()<finish and t3.xcor()<finish:
    t1.forward(randint(2,7))
    t2.forward(randint(2,7))
    t3.forward(randint(1,8))
sleep(0.05)

input()