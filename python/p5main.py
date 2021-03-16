import statistics
	#input the file data into three lists, one for apple etc
data=open('stocks_data.csv','r')
appList=list()
ibList=list()
msList=list()
for i in data:
	if i.startswith("AAPL"):
		appList.append(i)
	if i.startswith("IBM"):
		ibList.append(i)
	if i.startswith("MSFT"):
		msList.append(i)
appList.sort()
ibList.sort()
msList.sort()
	#list of just the prices
apPrice=[i[15:] for i in appList]
ibPrice=[i[14:] for i in ibList]
msPrice=[i[15:] for i in msList]
	#Create separate txt file
writeTo=open("stock_summary.txt", "w")
	#Find the max prices
print("max")
print(appList[apPrice.index(max(apPrice))])
print(ibList[ibPrice.index(max(ibPrice))])
print(msList[msPrice.index(max(msPrice))])
	#Find the min prices
print("min")
print(appList[apPrice.index(max(apPrice))])
print(ibList[ibPrice.index(min(ibPrice))])
print(msList[msPrice.index(min(msPrice))])
	#Find the average prices
#print("average")
#print("apple", (sum(apPrice)/len(apPrice)))
#print("IB",(sum(ibPrice)/len(ibPrice)))
#print("microsoft", (sum(msPrice)/len(msPrice)))
	#Print them to the other file
print("max", file=writeTo)
print(appList[apPrice.index(max(apPrice))], file=writeTo)
print(ibList[ibPrice.index(max(ibPrice))], file=writeTo)
print(msList[msPrice.index(max(msPrice))], file=writeTo)
print("min", file=writeTo)
print(appList[apPrice.index(min(apPrice))], file=writeTo)
print(ibList[ibPrice.index(min(ibPrice))], file=writeTo)
print(msList[msPrice.index(min(msPrice))], file=writeTo)
	#Find the highest
print("highest")
print(appList[apPrice.index(max(apPrice))])
	#Find the lowest
print("lowest")
print(appList[apPrice.index(max(apPrice))])	
	#Print my top and bottom
print("highest", file=writeTo)
print(appList[apPrice.index(max(apPrice))], file=writeTo)
print("lowest", file=writeTo)
print(appList[apPrice.index(min(apPrice))], file=writeTo)
	#Close the files
data.close()
writeTo.close()
