/**Largest palindrome product
Problem 4
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/


using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int limit = 999;
    int startj = 900;
    int startk = 900;
    
    palindrome(limit, startj, startk);
  }
  
  public static void palindrome(int roof, int sj, int sk){
	int topProduct = 0;
	int topj = 0;
	int topk = 0;
	
	for(int j = sj; j < roof; j++){
		for(int k = sk; k < roof; k++){
			int temp = j*k;
			
			string stemp = temp.ToString();
			
			char[] castemp = stemp.ToCharArray();
			Array.Reverse(castemp);
			string rstemp = new string(castemp);
			
			if(stemp.Equals(rstemp)){
				int product = Int32.Parse(stemp);
				
				Console.WriteLine(j + "    " + k + "    " + product);
				topProduct = product;
				topj = j;
				topk = k;
			}
		}
	}
	
	Console.WriteLine("The highest palindrome is made up of:");
	Console.WriteLine("\t"+ topj +"\tand\t"+ topk);
	Console.WriteLine("\tto make:\t"+ topProduct);
  }
  
}
