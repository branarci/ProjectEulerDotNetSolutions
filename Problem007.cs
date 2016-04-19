/**10001st prime
Problem 7
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
*/


using System;
class MainClass {
  public static void Main (string[] args) {
    
    int current = 2;
    int limit = 1000;
    for(int i = 0; i < limit; i++){
    	current = nextPrime(current);
    }
    
    Console.WriteLine(current);
  }
  
  public static int nextPrime(int p){
    	bool stillChecking = true;
    	int nextp = p;
    	
    	while(stillChecking){
			nextp = nextp + 1;
    		
    		for(int i = 2; i <= nextp; i++){
    			if((nextp % i == 0) && (i == nextp)){
    				p = nextp;
    				stillChecking = false;
    			}else if(nextp % i == 0){
    				break;
    			}
    		}
    	}
    	
    	return nextp;
    }
}
      
