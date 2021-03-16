import random
random.seed(20190101)
import math

#list of (x) of where they end
pa1x=[];pa10x=[];ma1x=[];ma10x=[];reg1x=[];reg10x=[]
#list of (y) of where they end
pa1y=[];pa10y=[];ma1y=[];ma10y=[];reg1y=[];reg10y=[]

#list of (x) of where they end random test
rpa1x=[];rma1x=[];rreg1x=[];
#list of (y) of where they end random test
rpa1y=[];rma1y=[];rreg1y=[];

#For all the walkers use a x,y grid to show where they go. 
#North is +y, east is+x, south is-y, west is -x.
	
def pa1(steps):
	x=0
	y=0
	for i in range(steps):
		#choose a random direction to face (choose a random number (1,2,3,4) if one north etc.)
		f=random.randrange(4)
		#move forward once
		if f is (0):
			y+=1
		elif f is (1):
			x+=1
		elif f is (2):
			y-=1
		elif f is (3):
			x-=1
	pa1x.append(x)
	pa1y.append(y)
def pa10(steps):
	x=0
	y=0
	for i in range(steps):
		#choose a random direction to face (choose a random number (1,2,3,4) if one north etc.)
		f=random.randrange(4)
		#move forward once
		if f is (0):
			y+=1
		elif f is (1):
			x+=1
		elif f is (2):
			y-=1
		elif f is (3):
			x-=1
	pa10x.append(x)
	pa10y.append(y)
def par(steps):
	x=0
	y=0
	for i in range(steps):
		#choose a random direction to face (choose a random number (1,2,3,4) if one north etc.)
		f=random.randrange(4)
		#move forward once
		if f is (0):
			y+=1
		elif f is (1):
			x+=1
		elif f is (2):
			y-=1
		elif f is (3):
			x-=1
	rpa1x.append(x)
	rpa1y.append(y)	
def ma1(steps):
	x=0
	y=0
	for i in range(steps):
		# #choose a random direction to face (choose a random number (1,2,3,4,5) if one north etc., five is also south)
		f=random.randrange(5)
		#move forward once
		if f is (0):
			y+=1
		elif f is (1):
			x+=1
		elif f is (2):
			y-=1
		elif f is (3):
			x-=1
		elif f is (4):
			y-=1
	ma1x.append(x)
	ma1y.append(y)
def mar(steps):
	x=0
	y=0
	for i in range(steps):
		# #choose a random direction to face (choose a random number (1,2,3,4,5) if one north etc., five is also south)
		f=random.randrange(5)
		#move forward once
		if f is (0):
			y+=1
		elif f is (1):
			x+=1
		elif f is (2):
			y-=1
		elif f is (3):
			x-=1
		elif f is (4):
			y-=1
	rma1x.append(x)
	rma1y.append(y)
def ma10(steps):
	x=0
	y=0
	for i in range(steps):
		# #choose a random direction to face (choose a random number (1,2,3,4,5) if one north etc., five is also south)
		f=random.randrange(5)
		#move forward once
		if f is (0):
			y+=1
		elif f is (1):
			x+=1
		elif f is (2):
			y-=1
		elif f is (3):
			x-=1
		elif f is (4):
			y-=1
	ma10x.append(x)
	ma10y.append(y)
	
def reg1(steps):
	x=0
	y=0
	for i in range(steps):
		#choose a random direction (choose a random number (1,2) if one forward, two back)
		f=random.randrange(2)
		#move forward once
		if f is (0):
			x+=1
		elif f is (1):
			x-=1
	reg1x.append(x)
	reg1y.append(y)	
	
def reg10(steps):
	x=0
	y=0
	for i in range(steps):
		#choose a random direction (choose a random number (1,2) if one forward, two back)
		f=random.randrange(2)
		#move forward once
		if f is (0):
			x+=1
		elif f is (1):
			x-=1
	reg10x.append(x)
	reg10y.append(y)
def regr(steps):
	x=0
	y=0
	for i in range(steps):
		#choose a random direction (choose a random number (1,2) if one forward, two back)
		f=random.randrange(2)
		#move forward once
		if f is (0):
			x+=1
		elif f is (1):
			x-=1
	rreg1x.append(x)
	rreg1y.append(y)
	
def findEnds():
	for x in range(50):
		pa1(100)
		pa10(1000)
		ma1(100)
		ma10(1000)
		reg1(100)
		reg10(1000)
findEnds()

def teacher():
	steps=int(input("please enter the steps:"))
	trials=int(input("please enter the trials:"))
	for x in range(trials):
		par(steps)
		mar(steps)
		regr(steps)
	print ("Pa random walk of your value")	
	doMatht(rpa1x,rpa1y,trials)
	print ("ma random walk of your value")	
	doMatht(rma1x,rma1y,trials)
	print ("reg random walk of your value")	
	doMatht(rreg1x,rreg1y,trials)
def doMatht(x,y,tr):
	maxx=0
	minn=0
	dWalk=[]
	total=0
	for i in range(tr):
		dWalk.append(math.sqrt((x[i]**2)+(y[i]**2)))
	for i in range(tr):
		i=int(i)
		total+=dWalk[i]	
	if dWalk:
		maxx=max(dWalk)
		minn=min(dWalk)
	mean=total/ 50
	vari=findVariance(dWalk, mean,tr)
	print ("mean=",mean,"	cv=", vari)
	print ("max=",maxx,"	min=", minn)
		
def doMath(x,y):
	maxx=0
	minn=0
	dWalk=[]
	total=0
	for i in range(50):
		dWalk.append(math.sqrt((x[i]**2)+(y[i]**2)))
	for i in range(50):
		i=int(i)
		total+=dWalk[i]	
	if dWalk:
		maxx=max(dWalk)
		minn=min(dWalk)
	mean=total/ 50
	vari=findVariance(dWalk, mean)
	print ("mean=",mean,"	cv=", vari)
	print ("max=",maxx,"	min=", minn)
	
def findVariance(dWalk,mean,tr=50):
	total=0
	for i in range(tr):
		i=int(i)
		total+=(dWalk[i]-mean)**2 
	thatBit=total/49
	thisOne=math.sqrt(thatBit)
	return thisOne
	
print ("Pa random walk of 100 steps")
doMath(pa1x,pa1y)
print ("Pa random walk of 1000 steps")
doMath(pa10x,pa10y)
print ("Ma random walk of 100 steps")
doMath(ma1x,ma1y)
print ("Ma random walk of 1000 steps")
doMath(ma10x,ma10y)
print ("Reg random walk of 100 steps")
doMath(reg1x,reg1y)
print ("Reg random walk of 1000 steps")
doMath(reg10x,reg10y)
teacher()

from turtle import Turtle
import time
turtle=Turtle()
turtle.speed(0)
def plot(x,y,newColor):
	for i in range(50):
		turtle.color(newColor,newColor)
		turtle.up()
		turtle.goto(x[i],y[i])
		turtle.down()
		turtle.begin_fill()
		turtle.circle(2)
		turtle.end_fill()		
plot(pa1x,pa1y,"green")
plot(ma1x,ma1y,"red")
plot(reg1x,reg1y,"blue")
time.sleep(10)
