from turtle import Turtle
import time
timey=str(input("please enter a season:"))#get the input
grassColor="green"
skyColor="blue"
leafColor="lightgreen"
if timey == "fall":	#change the colors
		grassColor="darkgreen"
		skyColor="blue"
		leafColor="orange"
if timey == "spring":
		grassColor="green"
		skyColor="lightblue"
		leafColor="pink"
if timey == "winter":
		grassColor="white"
		skyColor="darkblue"
		leafColor="white"
if timey =="summer":
		grassColor="lightgreen"
		skyColor="blue"
		leafColor="darkgreen"
turtle=Turtle()
def tree(color,size):# tree funtion
	turtle.color(color,color)#draw the leaves
	turtle.begin_fill()
	turtle.circle(50*size,360)
	turtle.left(90)
	turtle.fd(100*size)
	turtle.circle(50*size,360)
	turtle.left(90)
	turtle.forward(100*size)
	turtle.circle(50*size,360)
	turtle.end_fill()
	turtle.left(180)
	turtle.fd(50*size)
	turtle.color("tan","tan")#draw the trunk
	turtle.begin_fill()
	turtle.fd(10*size)
	turtle.right(90)
	turtle.fd(250*size)
	turtle.right(90)
	turtle.fd(30*size)
	turtle.right(90)
	turtle.fd(250*size)	
	turtle.end_fill()
	turtle.right(90)
def Background(grassColor,skyColor): #background function
	turtle.begin_fill()
	turtle.color(grassColor,grassColor)#grass
	turtle.fd(350)
	turtle.right(90)
	turtle.fd(350)
	turtle.right(90)
	turtle.fd(700)
	turtle.right(90)
	turtle.fd(350)
	turtle.right(90)
	turtle.fd(700)
	turtle.end_fill()
	turtle.begin_fill()
	turtle.color(skyColor,skyColor)#sky
	turtle.left(90)
	turtle.fd(400)
	turtle.left(90)
	turtle.fd(800)
	turtle.left(90)
	turtle.fd(400)
	turtle.end_fill()
turtle.speed(2)
turtle.home()
Background(grassColor,skyColor)#bg
def treeLoop(x,y,size):#loop to draw a tree at a given location and size
	turtle.penup()
	turtle.home()
	turtle.goto(x,y)
	turtle.pendown()
	tree(leafColor,size)
treeLoop(0,20,1)
treeLoop(90,25,.7)
treeLoop(300,120,1.7)
treeLoop(350,20,.5)
treeLoop(-100,150,1.7)
treeLoop(150,10,1)
treeLoop(-250,80,1.5)
time.sleep(10)
