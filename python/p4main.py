#set up variables
month=1
totPair=1
adult=0
tempAdult=0
parent=1
baby=0
tempBaby=0
write=open("rabbits.csv", "a")#open file
print ("# table of rabbit pairs")#start the table
print ("Month  Adults  Babies  Total")
print (month,"	",parent,"	",baby,"	",totPair)
write.write("# table of rabbit pairs")#start the table in the other file
write.write("Month  Adults  Babies  Total")
write.write (str(month))
write.write(str(parent))
write.write(str(baby))
write.write(str(totPair))
while totPair<int(500):#repeat until total bunnies<500
	month+=1
	#Age everyone up one group (if they are parents then keep them there)
	tempAdult=adult #hold adult number
	adult+=baby	#age up babies
	baby=0	#babies have aged up
	adult-=tempAdult #they aged up and became adults
	baby+=parent#add more babies
	parent+=tempAdult#only the adults from last monnth become parents
	totPair+=baby+parent+adult#Update the total
	print (month,"	",parent,"	",baby,"	",totPair)
	#Write to other file.
	write.write (str(month))
	write.write(str(parent))
	write.write(str(baby))
	write.write(str(totPair))
print ("cages run out in month",month)
write.close()
