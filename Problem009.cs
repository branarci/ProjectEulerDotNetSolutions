/**Special Pythagorean triplet
Problem 9
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/


using System;
class MainClass {
  public static void Main (string[] args) {
    
    pythagoreanTriplet(500, 1000);
    
    //Console.WriteLine(answer);
  }
  
  public static void pythagoreanTriplet(int roof, int target){
  	int actualc = 2;
	int actualcSquared = 4;
  	int actualSum = 3;
  	
  	for(int a = 1; a<(roof-1); a++){
  		for(int b = a+1; b<roof; b++){
  			actualcSquared = a*a + b*b;
  			
  			if((Math.Sqrt(actualcSquared) % 1) == 0){
  				actualc = (int)Math.Sqrt(actualcSquared);
  				actualSum = a+b+actualc;
  				
  				//Console.WriteLine(a +"\t"+ b +"\t"+ actualc +"\t"+ actualSum);
  				
  				if(actualSum == target){
	  				Console.WriteLine(a +"\t"+ b +"\t"+ actualc +"\t"+ actualSum);;
	  			}
  			}
  		}
  	}
  }
  
}
