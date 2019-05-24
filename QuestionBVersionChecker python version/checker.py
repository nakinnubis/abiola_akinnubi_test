import sys
from versionchecker import versionChecker
def main():
    version1 = "1.2.5."
    version2 = "1.2.4.9"
    versionCheck = versionChecker.check(version1,version2)    
    if versionCheck  < 0: 
        print("{} is older".format(version1))
    elif versionCheck > 0: 
        print("{} is older".format(version2))
    else: 
        print("Version is up to date")

if __name__ == "__main__":
    main()