/**Longest Collatz sequence
Problem 14
Published on Friday, 5th April 2002, 06:00 pm; Solved by 145934; Difficulty rating: 5%
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.
*/


using System;
class MainClass {
  public static void Main (string[] args) {
    int maxChain = 0;
    int startingNum = 0;
    
    int limit = 1000000;
    for(int i = 0; i < limit; i++){
    	double n = (double)i;
    	
    	int chainLimit = 0;
    	while(n > 1){
    		if((n % 2) == 0 ){
    			n = n * 0.5;
    		}else{
    			n = 3*n + 1;
    		}
    		chainLimit++;
    	}
    	
    	if(chainLimit > maxChain){
    		maxChain = chainLimit;
    		startingNum = i;
    		Console.WriteLine(i);
    	}
    }
    
    Console.WriteLine("Starting number and chain length:\t"+ startingNum +"\t"+ maxChain);
    
  }
  
}
