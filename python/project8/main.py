#put all my variables up here so i can find them
bList=[] #list of jobs in a certain year each row is a nested list of all of the items in the row
presList=[] #list of presidents #0 years served,1 name,2 party
jobs=[]# total jobs that year #0 year, 1 number of jobs
newjobs=[]#how many NEW jobs happend that year # 0 year, 1 jobs
credListD=[] #jobs data chuncked into presidents for democrats#0 president, 1 num jobs
credListR=[] #jobs data chuncked into presidents for republicans#0 president, 1 num jobs

#in pres file i have obama as ending in 2012, he was in office until 2017, but the code is cleaner with this small error
#imput the presidents text file into a nested list
with open('presidents.txt', "r") as data:
	things=(line.split(",") for line in data)
	next(things)
	presList=[[stuff[0],str(stuff[1]),str(stuff[2])]for stuff in things]
	
#bls data first line is titles so i skipped importing it list[x] is the row
#bls data has the year as the first item so list[0][0] will be the year
with open('BLS_private.csv', "r") as data:
	things=(line.split(",") for line in data)
	next(things)
	bList=[[int(item)for item in stuff]for stuff in things]
	
#define a function to find how many jobs were created that year
def jobsYear():
	z=0
	for row in bList:
		jobsMath=0
		#how many jobs happend this year
		for x in range(1,13):
			jobsMath+=int(row[x])
		#make a nested list first item is year, second is jobs that year
		jobs.append([row[0],jobsMath])
		#how many of those jobs are new aka have been produced in that year
	for x in jobs:
		y=jobs.index(x)
		#1960 is not in my list, but there were 549948 jobs so i need to account for this	
		if y==0:
			now=x[1]#two variables one for this years nested list, and one for last years
			then=549948
			newjobs.append([x[0],(int(now)-int(then))])
		else:
			now=x[1]
			then=jobs[y-1][1]
			newjobs.append([x[0],(int(now)-int(then))])	
jobsYear()

#sort the data into presidents
def dataSort():
	#place holder number so i reference the correct year that they entered office
	pHold=0
	for row in presList:
		yearMath=0
		#find out how many jobs in those years they served
		for x in newjobs[pHold:(pHold+int(row[0]))]:
			yearMath+=int(x[1])
		#sort them to where they go
		if "emo" in row[2]:
			credListD.append([row[1],yearMath])
		if "pub"in row[2]:
			credListR.append([row[1],yearMath])
		pHold+=int(row[0])
dataSort()

#how many jobs go to each party
def partyJobs(listt):
	math=0
	for x in listt:
		math+=int(x[1])
	return math		
	
#print all the results
print ("Number of democratic jobs", partyJobs(credListD),"thousand.")
print ("Number of republican jobs", partyJobs(credListR),"thousand.")
print ("Clinton was correct in his sentiment, even if his numbers were off.")	
print(" ")

print ("Number of jobs created under each president")
for x in credListD:
	print (x[0],x[1],"thousand." )
for x in credListR:
	print (x[0],x[1],"thousand." )
print(" ")
	
#user imput function for president
def user():
	query=str(input("Please choose a president from 1961-2012:"))
	for row in credListD:
		if query in row[0]:
			print(row[1],"thousand jobs created in their presidency.")
	for row in credListR:
		if query in row[0]:
			print(row[1],"thousand jobs created in their presidency.")
user()
#user input function for year
def userY():
	query=str(input("Please choose a year from 1961-2012:"))
	for row in newjobs:
		if query in str(row[0]):
			print(row[1],"thousand jobs difference from the year before.")
			y=newjobs.index(row)
			print(jobs[y][1],"thousand jobs total for this year.")
userY()
	
	
	
	
