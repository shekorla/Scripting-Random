import numpy, requests, random

urlBase="https://www.cia.gov/library/publications/resources/the-world-factbook/graphics/flags/large/"
urlEnd="-lgflag.gif"
urlChange="us"
urlFull=urlBase+urlChange+urlEnd
Gname=urlChange+".gif"
totalBytes=0
flag=[]
i=0
txt=open('flags.txt','r')
for row in txt:
	row=row.strip('\n')
	flag.append(row)
while i <10:
	new=random.randrange(0,(len(flag)-1))
	urlChange=flag[new]
	urlFull=urlBase+urlChange+urlEnd
	Gname=urlChange+".gif"
	p = requests.get(urlFull)
	with open(Gname,'wb') as f:
		f.write(p.content)
		totalBytes=totalBytes+len(p.content)
	i=i+1

print("Total bytes downloaded: "+ str(totalBytes))
