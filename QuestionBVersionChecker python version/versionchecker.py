import sys
class versionChecker():
        '''
           This library accepts the string of software version to compare
           checks for null in both string by ensuring no empty string is sent 
           splits the string based on the dot(.) seperator
           trim empty tailing string by check for isnull or empty
           parse or converts the number to integer
           return arrays of integer
           the handles a scenerior where a user may enter 1.2.5. for v1 and 1.2.4.9 for v2 
           in such case it appends 0 to the end of the array before computing
           then a while loop to keep checking 
           if new version is greater than than the older version it returns -1
           if old is greater than new it returns 1
           if both matches the it returns 0
    '''
        def check(v1, v2):     
            # This will split both the versions by '.'
            versionold = v1.split(".") 
            versionnew = v2.split(".") 
  
            # Initializer for the version arrays
            i = 0 
            if len(versionold) < len(versionnew):
                versionold.append("0")
            elif len(versionnew) < len(versionold):
                versionnew.append("0")
    
            while(i < len(versionold)): 
          
                # New version is more recent
                if int(versionnew[i]) > int(versionold[i]): 
                    return -1
          
                # Older version is more recent
                if int(versionold[i]) > int(versionnew[i]): 
                    return 1
  
       
                i += 1
          
            # Upto date
            return 0

