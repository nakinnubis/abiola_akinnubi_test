import sys

toint = lambda x:int(x)
def InputToArray(inpt):
    values = []
    listvalue = inpt.split(',')
    for inp in listvalue:
        values.append(toint(inp))
    if(len(values) > 1 and len(values) < 3):
        return values
    else:
        return None


RightIsLessThanLeft = lambda x4,x1:x4 < x1
RightIsGreaterThanLeft = lambda x3,x2:x3 > x2
def main():
    input1 = input("Enter the value of x1,x2 by separating the input with a comma: ")
    input2 = input("Enter the value of x3,x4 by separating the input with a comma: ")
    firstcoordinate = InputToArray(input1)
    secondcoordinate = InputToArray(input2)
    if(firstcoordinate != None and secondcoordinate != None):
           if (RightIsLessThanLeft(secondcoordinate[1], firstcoordinate[0]) or RightIsGreaterThanLeft(secondcoordinate[0], firstcoordinate[1])):
                print("LINES DOES NOT OVERLAP")
           else:
                print("LINES DOES OVERLAP")

if __name__ == "__main__":
    main()