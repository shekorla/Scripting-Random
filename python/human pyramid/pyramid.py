import time
global r,c,times, cacheHit
start_time=time.perf_counter()
cache={"0,0":0.00}
times=0
cacheHit=0
def pyra(rows):
	r=0
	c=0
	rowei=""
	while r <= rows:
		while c<=r:
			name=str(c)+","+str(r)
			#the first row
			if r==0:
				cache[name]=0.00
				c=c+1
			#the second row
			elif r==1:
				cache[name]=100.00
				c=c+1
			#on the end
			elif c==0 or c==r:	
				cache[name]=wei(c,r,True)
				c=c+1
			#in middle
			else:
				cache[name]=wei(c,r,False)
				c=c+1
			rowei=rowei+str(cache[name])+"  "
		print(rowei)
		r=r+1
		c=0
		rowei=""
	return cache	
def wei(c,r, end=False):
	hold=0
	global times, cacheHit
	a=0
	b=0
	if (str(c)+","+str(r)) in cache:
		hold=cache[str(c)+","+str(r)]
		cacheHit=cacheHit+1
	else:
		#if its in the middle of a row
		if end==False:
			a=cache[str(c)+","+str(r-1)]
			b=cache[str(c-1)+","+str(r-1)]
			hold=((a+b)/2+200)
		else:# it is on the end of a row
			a=cache[str(0)+","+str(r-1)]
			hold=float("{:.2f}".format((a/2)+100))
	times=times+1
	return hold
many=int(input("how many rows? "))
pyra(many)

print(time.perf_counter()-start_time,"seconds run time.")
print("function called",times,"times.")
print("cache called",cacheHit,"times.")
