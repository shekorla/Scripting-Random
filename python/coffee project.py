class coffeeMachine:
	totalRec=int
	def totalCash(num):
		coffeeMachine.totalRec=coffeeMachine.totalRec+num
		return coffeeMachine.totalRec
	def one_action(true):
		print("     ")
		print("PRODUCT LIST: all 35 cents, except bouillon(25 cents)\n1=black, 2=white, 3=sweet, 4=white & sweet, 5=bouillon \nSample commands: insert 25, select 1.")
		command=input(">>> your command: ")
		if "insert" in command:
			num=''.join(z for z in command if z.isdigit())
			cashBox.deposit(int(num))
			return True
		elif "cancel" in command:
			cashBox.cashBack(0)
			return True
		elif "select" in command:
			if cashBox.total>24:
				num=''.join(z for z in command if z.isdigit())
				selector.select(int(num))
			else:
				print("Sorry. Not enough money deposited.")
			return True
		elif "quit" in command:
			cashBox.cashBack(0)
			return False
		else:
			print("invalid command")
			return True
	
class cashBox:
	total=0
	def deposit(x):
		valid=True
		if x!=25:
			if x!=50:
				if x!=10:
					if x!=5:
						valid=False
					else:
						valid=True
				else:
					valid=True
			else:
				valid=True
		else:
			valid=True
			
		if valid is True:
			cashBox.total=cashBox.total+x
			print("Depositing " +str(x)+" cents. You have "+str(cashBox.total)+" cents credit.")
		else:
			cashBox.invalAm()
	def invalAm():	
		print("INVALID AMOUNT \n>>> We only take half-dollars, quarters, dimes, and nickels.")
	def cashBack(cost):
		cashBox.total=cashBox.total-cost
		coffeeMachine.totalCash(cashBox.total)
		print("Returning "+str(cashBox.total)+" cents.")
		cashBox.total=0
		return True
		
class selector:
	def select(num):
		if num <=5:
			if num !=5:
				if cashBox.total>=35:
					product.make(num-1)
				else:
					print("Sorry. Not enough money deposited.")
			elif num ==5:
				if cashBox.total>=25:
					product.make(num-1)
				else:
					print("Sorry. Not enough money deposited.")
		else:
			print ("invalid selection")

class product:
	first=["black","white","sweet","white & Sweet","bouillon"]
	
	def make(choice):
		if choice==0:
			print("Making black:\n Dispensing cup \nDispensing coffee \nDispensing water")
			cashBox.cashBack(35)
		elif choice==1:
			print("Making white: \nDispensing cup \nDispensing coffee \nDispensing creamer \nDispensing water")
			cashBox.cashBack(35)
		elif choice==2:
			print("Making sweet: \nDispensing cup \nDispensing coffee \nDispensing sugar \nDispensing water")
			cashBox.cashBack(35)
		elif choice==3:
			print("Making white & sweet: \nDispensing cup \nDispensing coffee \nDispensing sugar \nDispensing creamer \nDispensing water")
			cashBox.cashBack(35)
		elif choice==4:
			print("Making bouillon: \nDispensing cup \nDispensing bouillonPowder \nDispensing water")
			cashBox.cashBack(25)
def main():
	m = coffeeMachine()
	coffeeMachine.totalRec=0
	while m.one_action():
		pass
	total = coffeeMachine.totalRec
	print(f"Total cash received:n ${total/100:.2f}")
main()
