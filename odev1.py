def findNumber(number, myArray):
    for i in range(len(myArray)):
	if number == myArray[i]:
	    return i

myArray = [1,2,3,4]

number = int(input("Enter a number:"))
print findNumber(number, myArray)
