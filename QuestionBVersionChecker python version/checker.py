import sys
from versionchecker import versionChecker
def main():
    version1 = "1.2.5."
    version2 = "1.2.4.9"
    versionCheck = versionChecker.check(version1,version2)
    ans = versionCheck 
    if ans < 0: 
        print(version1 + " is older")
    elif ans > 0: 
        print(version2 + " is older")
    else: 
        print("Version is up to date")

if __name__ == "__main__":
    main()