/**Largest prime factor
Problem 3
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/


using System;
using System.Collections.Generic;

class MainClass {
	static int p = 2;
	
	public static void Main (string[] args) {
		primeFactorization(600851475143);
	}
    
    public static void nextPrime(){
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
    }
    
    public static void resetPrime(){
    	p = 2;
    }
    
    public static void primeFactorization(UInt64 n){
    	//Console.WriteLine("***************|  Number divided by prime  |***************");
    	UInt64 modifiedn = n;
    	List<int> nList = new List<int>();
    	
    	bool inProgress = true;
    	while(inProgress){
    		if(modifiedn == 0){
    			//Console.WriteLine("***************|        Ended in 0         |***************");
    			inProgress = false;
    		}else if (modifiedn == 1){
    			//Console.WriteLine("***************|        Ended in 1         |***************");
    			inProgress = false;
    		}
			
			double mnp = (double)modifiedn / (double)p;
			if((mnp % 1) == 0){
    			//Console.WriteLine("total:\t"+ modifiedn);
    			//Console.WriteLine("\t\tprime:\t"+ p +"\tremaining:\t"+ mnp);
    			
    			modifiedn = (UInt64) mnp;
    			nList.Add(p);
    			resetPrime();
    		}else{
    			nextPrime();
    		}
    	}
    	
    	//Console.WriteLine();
    	Console.WriteLine("primes used:");
    	foreach(int i in nList){
    		Console.WriteLine("\t"+ i);
    	}
    	
    	int max = 0;
    	foreach(int i in nList){
    		if(i > max){
    			max = i;
    		}
    	}
    	Console.WriteLine("Largest prime used is " + max);
    }
    
}
      
