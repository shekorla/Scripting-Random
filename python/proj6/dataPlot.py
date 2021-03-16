import numpy, glob
from matplotlib import pyplot as plt

f = open("2_Record2308.out", "w").close()
global plnum
plnum=0
global fig
fig=plt.figure()

def main():
	for fname in glob.glob('*.dat'):
		analyze(fname)
def analyze(fname):
	global plnum, fig
	vt=100
	plAreaList=[]
	pulseSt=0
	data=[]
	smdata=[]
	a=str(plnum)
	data=numpy.loadtxt(fname)
	fig, a=plt.subplots(3,2)
	a[plnum,0].plot(data)
	a[plnum,0].set_title(str(fname)+" R")
	print (a)
	#smooth data
	for item in data:
		smdata.append(item)
	i=1
	while i<int(len(data)-3):
		smdata[i]=((data[int(i-3)]+2*data[int(i-2)]+3*data[int(i-1)]+3*data[i]+3*data[int(i+1)]+2*data[int(i+2)]+data[int(i+3)])//15)
		i=i+1
	a[plnum,1].plot(smdata)
	a[plnum,1].set_title(str(fname)+" S")
	plnum=plnum+1
	#look for pluses
	i=0
	while i <(len(smdata)-3):
		a=smdata[i]
		c=smdata[int(i+2)]
		pulseArea=0
		if (c-a) >vt:
			pulseSt=i
			pulseArea=data[i]
			while (c-a) >-100:
				pulseArea=pulseArea+data[i]
				a=smdata[i]
				c=smdata[int(i+2)]
				i=i+1
			plAreaList.append((pulseSt,pulseArea))
		i=i+1
	z=1
	f = open("2_Record2308.out", "a")
	f.write(fname+":")
	for i in plAreaList:
		f.write("\n")
		f.write("Pulse "+str(z)+": "+str(i[0])+" ("+str(i[1])+")")
		z=z+1
	f.write("\n")
	f.close()
	
main()
plt.get_fignums()
fig.tight_layout()
fig.savefig("plots.pdf")
