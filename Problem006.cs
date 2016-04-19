/**Sum square difference
Problem 6
Published on Friday, 14th December 2001, 06:00 pm; Solved by 307411; Difficulty rating: 5%
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/


using System;
class MainClass {
  public static void Main (string[] args) {
    
    int largeAnswer = squareOfSum(100);
    int smallAnswer = sumOfSquares(100);
    
    Console.WriteLine(largeAnswer +"\t"+ smallAnswer);
    Console.WriteLine("\t\t"+ (largeAnswer - smallAnswer));
  }
  
  public static int sumOfSquares(int roof){
  	int sum = 0;
  	for(int i = 1; i < roof+1; i++){
  		int temp = i*i;
  		sum += temp;
  	}
  	return sum;
  }
  
  public static int squareOfSum(int roof){
  	int sum = 0;
  	int temp= 0;
  	for(int i = 1; i < roof+1; i++){
  		temp += i;
  	}
  	sum = temp*temp;
  	
  	return sum;
  }
}
      
