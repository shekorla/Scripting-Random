books=open("booklist.txt","r")
rate=open("ratings.txt","r")
booklist=[]
ratelist={}
x=0
# ~ make a list of all the books
for line in books:
	booklist+=[(line.strip().split(','))]
# ~ make a list of what everyone rated the books
for line in rate:
	name=str(line).lower()
	name=name[:-1]
	line=next(rate)
	ratelist[name]=line
# ~ make a function to find the dot product
def dotprod(x,y):
	tot=0
	z=0
	a=ratelist[x]
	b=ratelist[y]
	while z<len(a) and z<len(b):
		if a[z].isdigit() and b[z].isdigit() is True:
			c=int(a[z])
			d=int(b[z])
			tot+=(c*d)
			z+=1
		else:
			z+=1		
	return tot
# function to find friends
def friends(name):
	alList=[]
	for each in ratelist:
		early=0
		if each!=name:
			if dotprod(name,each)>early:
				early=dotprod(name,each)
				alList.append(each)
	alList.sort(reverse=True)
	return alList[0:2]
# recomend a book
def recomend(name):
	twoFri=friends(name)
	fri1=twoFri[0]
	fri2=twoFri[1]
	fri1Top=(booklist[ratelist[fri1].index(max(ratelist[fri1]))],booklist[ratelist[fri1].index(findTop2(fri1))])
	fri2Top=(booklist[ratelist[fri2].index(max(ratelist[fri2]))],booklist[ratelist[fri2].index(findTop2(fri2))])
	return (fri1Top,fri2Top)
def findTop2 (fri):
	i=0
	secondtop=0
	maxi=int(max(ratelist[fri]))
	lst=ratelist[fri]
	while i < len(lst): 
		if lst[i].isdigit() is True:
			j=int(lst[i])
		else: 
			i+=1
			continue
		if j>maxi:  
			secondtop=maxi 
			maxi=j  
		elif j>secondtop and maxi != j:  
			secondtop=j 
		else: 
			if secondtop == maxi: 
				secondtop = j 
		i+=1
	return str(secondtop)
def ask(what):
	if what =="recomend":
		who=input("Who would you like a recomendation for?  ")
		tryagain=True
		if who in ratelist:
			tryagain=True
			print(recomend(who))
		else:
			tryagain=False
			while tryagain==False:
				if who in ratelist:
					tryagain=True
					print(recomend(who))
				else:
					tryagain=False
					print("not valid")
					print("")
					who=input("Who would you like a recomendation for?  ")
		print("")
	elif what=="friend":
		who=input("who would you like friends for?   ")
		tryagain=True
		if who in ratelist:
			tryagain=True
			print(friends(who))
		else:
			tryagain=False
			while tryagain==False:
				if who in ratelist:
					tryagain=True
					print(recomend(who))
				else:
					tryagain=False
					print("not valid")
					print("")
					who=input("who would you like friends for?   ")
	elif what=="quit" :
		print ("end")
		return None
	else:
		what=input("Didn't catch that. What would you like? recomend, friend, quit: ")
		ask(what)
	what=input("What would you like? recomend, friend, quit: ")
	ask(what)
what=input("What would you like? recomend, friend, quit: ")
ask(what)
