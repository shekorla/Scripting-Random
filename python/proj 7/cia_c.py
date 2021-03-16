import numpy, requests, random, time, os, datetime, threading
#download files concurently using threads.
def main():
	start_time=time.perf_counter()
	now=datetime.datetime.now().time()
	saveTo=str(now.second)+' flags'
	os.mkdir(saveTo)
	#set up variables
	urlBase="https://www.cia.gov/library/publications/resources/the-world-factbook/graphics/flags/large/"
	urlEnd="-lgflag.gif"
	urlChange="us"
	urlFull=urlBase+urlChange+urlEnd
	Gname=urlChange+".gif"
	totalBytes=0
	flag=[]
	i=0
	#main code download files
	txt=open('flags.txt','r')
	for row in txt:
		row=row.strip('\n')
		flag.append(row)		
	while i <10:
		new=random.randrange(0,(len(flag)-1))
		urlChange=flag[new]
		urlFull=urlBase+urlChange+urlEnd
		Gname=os.path.join(saveTo,(urlChange+".gif"))
		p = requests.get(urlFull)
		with open(Gname,'wb') as f:
			f.write(p.content)
			totalBytes=totalBytes+len(p.content)
		i=i+1
	#print out results
	print("Total bytes downloaded: "+ str(totalBytes))
	print(time.perf_counter()-start_time,"seconds run time.")
if __name__ == '__main__':
	t=threading.Thread(target=main)
	t.start()
	t.join()
