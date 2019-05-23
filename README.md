THIS README IS FILE IS THE GUIDE TO SOLUTION I PROVIDED FOR THE FOLLOWING QUESTION.
TECHNICAL TEST

Question A
Your goal for this question is to write a program that accepts two lines (x1,x2) and (x3,x4) on the x-axis and returns whether they overlap. As an example, (1,5) and (2,6) overlaps but not (1,5) and (6,8).
=======================
SOLUTION A DOCUMENTATION
=======================
I have tried to implement each question using both C# (Csharp) and python 3 programming language, C# version is written using .NET Core and should run on any machine be it Linux, MAC and windows
**C# Implementation:**
if you have dotnet core sdk and runtime install on your pc

1. cd into QuestionIsOverlapProgram C# version directory
2. do dotnet restore in the directory
3. do dotnet run
4. asked you for the value in x1,x2 format
5. press the Enter key
6. asked you for the value of x3,x4
7. press enter key
8. it parse your to decimal since it is a line number as it could be 1.2, 3.2
9. check to see if it is not null or empty
10. checks if x4 is less x1 using a boolean function called RightIsLessThanLeft(decimal x4, decimal x1) returns x4 <x1
11. checks if x3 is less x2 using a boolean function called RightIsGreaterThanLeft(decimal x3, decimal x2) returns x3 > x2
12. uses the || (or) operator to check for true and false this tells if the numbers overlap on each other on a straightline

**Python Implementation**
this assumes you have python setup on your machine.

1. cd into QuestionIsOverlapProgram python version folder
2. run the file isoverlap.py
3. asked you for the value in x1,x2 format
4. press the Enter key
5. asked you for the value of x3,x4
6. press enter key
7. it parse your to decimal since it is a line number as it could be 1.2, 3.2
8. check to see if it is not null or empty
9. checks if x4 is less x1 using a boolean function called RightIsLessThanLeft(x4, x1) returns x4 <x1
10. checks if x3 is less x2 using a boolean function called RightIsGreaterThanLeft(x3, x2) returns x3 > x2
11. uses the or operator to check for true and false this tells if the numbers overlap on each other on a straightline

Question B
The goal of this question is to write a software library that accepts 2 version string as input and returns whether one is greater than, equal, or less than the other. As an example: “1.2” is greater than “1.1”. Please provide all test cases you could think of.
=======================
SOLUTION B DOCUMENTATION
=======================
C# implementation
cd into QuestionBVersionChecker c# version folder

1. Since the questions states that library should created i create a .NET class library that can be used as a dll file
2. This library accepts the string of software version to compare
3. checks for null in both string by ensuring no empty string is sent
4. splits the string based on the dot(.) seperator
5. trim empty tailing string by check for isnull or empty
6. parse or converts the number to integer
7. return arrays of integer
8. this handles a scenerior where a user may enter 1.2.5. for v1 and 1.2.4.9 for v2
9. in such case it appends 0 to the end of the array before computing
10. Then a while loop to keep checking
11. if new version is greater than than the older version it returns -1
12. if old is greater than new it returns 1
13. if both matches the it returns 0
    a sample projects which imports this library is already included called QuestionBVersionChecker but the class library project is called VersionChecker
    python implementation
    cd into QuestionBVersionChecker python version folder
14. This library accepts the string of software version to compare
15. checks for null in both string by ensuring no empty string is sent
16. splits the string based on the dot(.) seperator
17. trim empty tailing string by check for isnull or empty
18. parse or converts the number to integer
19. return arrays of integer
20. this handles a scenerior where a user may enter 1.2.5. for v1 and 1.2.4.9 for v2
21. in such case it appends 0 to the end of the array before computing
22. Then a while loop to keep checking
23. if new version is greater than than the older version it returns -1
24. if old is greater than new it returns 1
25. if both matches the it returns 0
    Please to test the python version run checker.py which imports versionchecker.py you can change the test value
    Question C
    At Ormuco, we want to optimize every bits of software we write. Your goal is to write a new library that can be integrated to the Ormuco stack. Dealing with network issues everyday, latency is our biggest problem. Thus, your challenge is to write a new Geo Distributed LRU (Least Recently Used) cache with time expiration. This library will be used extensively by many of our services so it needs to meet the following criteria:  
     1 - Simplicity. Integration needs to be dead simple.
    2 - Resilient to network failures or crashes.
    3 - Near real time replication of data across Geolocation. Writes need to be in real time.
    4 - Data consistency across regions
    5 - Locality of reference, data should almost always be available from the closest region
    6 - Flexible Schema
    7 - Cache can expire
    As a hint, we are not looking for quantity, but rather quality, maintainability, scalability, testability and a code that you can be proud of.
    =======================
    SOLUTION C DOCUMENTATION
    =======================
