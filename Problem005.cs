/**Smallest multiple
Problem 5
Published on Friday, 30th November 2001, 06:00 pm; Solved by 305551; Difficulty rating: 5%
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/


using System;
class MainClass {
  public static void Main (string[] args) {
    
    int a = dividedWithNoRemainder(20, 500000000);
    
    Console.WriteLine(a);
  }
  
  public static int dividedWithNoRemainder(int floor, int roof){
  	int result = 0;
  	for(int j = floor; j < roof; j++){
  		for(int k = 1; k < floor+1; k++){
  			if(j%k != 0){
  				break;
  			}
  			if(k == floor){
  				result = j;
  				return result;
  			}
  		}
  	}
  	return result;
  }
}
