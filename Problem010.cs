/**Summation of primes
Problem 10
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/


using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int limit = 2000000;
    
	sieveE(limit);
  }
  
  public static void sieveE(int limit){
    	List<int> limitList = new List<int>();
    	
    	for(int h = 0; h < limit; h++){
    		limitList.Add(h);
    	}
    	limitList[1] = 0;
    	Console.WriteLine("Finished adding numbers to list and adjusted 1 to nil");
    	
    	int adjustedLimit = limit;
    	for(int i = 0; i < limitList.Count; i++){
    		if(!(limitList[i] == 0)){
    			for(int j = 2; j < adjustedLimit; j++){
    				int k = j * i;
    				
    				if(k > limit){
    					adjustedLimit = j;
    					//Console.WriteLine("\t\t"+ adjustedLimit);
    					break;
    				}
    				
    				if(k < limit){
    					limitList[k] = 0;
    				}
    			}
    		}
    	}
    	Console.WriteLine("Finished altering list");
    	
    	long sum = 0;
    	for(int m = 0; m < limitList.Count-1; m++){
    		sum = sum + (long)limitList[m];
    	}
    	Console.WriteLine("*********Sum: "+ sum);
    }
  
}
