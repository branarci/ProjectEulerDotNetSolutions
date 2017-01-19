/**Number letter counts
Problem 17
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*/


using System;
using System.Collections.Generic;

class MainClass {
	public static void Main (string[] args) {
		//loop through 1000
		int total = 0;
		for(int i = 1; i <= 1000; i++){
			int a = NoOfLettersInNumberAsWords(i);
			total += a;
		}
		
		Console.WriteLine(total);
	}
	public static int NoOfLettersInNumberAsWords(int number){
		//List of numbers and their word equivalent
		Dictionary<int, string> numberToWordList = new Dictionary<int, string>();
		numberToWordList.Add(0, "zero");
		numberToWordList.Add(1, "one");
		numberToWordList.Add(2, "two");
		numberToWordList.Add(3, "three");
		numberToWordList.Add(4, "four");
		numberToWordList.Add(5, "five");
		numberToWordList.Add(6, "six");
		numberToWordList.Add(7, "seven");
		numberToWordList.Add(8, "eight");
		numberToWordList.Add(9, "nine");
		numberToWordList.Add(10, "ten");
		numberToWordList.Add(11, "eleven");
		numberToWordList.Add(12, "twelve");
		numberToWordList.Add(13, "thirteen");
		numberToWordList.Add(14, "fourteen");
		numberToWordList.Add(15, "fifteen");
		numberToWordList.Add(16, "sixteen");
		numberToWordList.Add(17, "seventeen");
		numberToWordList.Add(18, "eighteen");
		numberToWordList.Add(19, "nineteen");
		numberToWordList.Add(20, "twenty");
		numberToWordList.Add(30, "thirty");
		numberToWordList.Add(40, "forty");
		numberToWordList.Add(50, "fifty");
		numberToWordList.Add(60, "sixty");
		numberToWordList.Add(70, "seventy");
		numberToWordList.Add(80, "eighty");
		numberToWordList.Add(90, "ninety");
		
		//---------------------------------
			//string n = numberToWordList[-3];
			//Console.WriteLine (n);
		//---------------------------------
		
		//global method variables
		string std4 = "";
		string std3 = "";
		string std2 = "";
		string std1 = "";
		string std21 = "";
		string fullnumberAsWord = "";
		
		int ind4 = -1;
		int ind3 = -1;
		int ind2 = -1;
		int ind1 = -1;
		int ind21 = -1;
		int fullnumber = number;
		
		int noOfDigits = fullnumber.ToString().Length;
		//---------------------------------
			//Console.WriteLine(noOfDigits);
		//---------------------------------
		
		//when number is in the thousands
		if (noOfDigits == 4){
			//get first digit as string
			string t4 = fullnumber.ToString().Substring(0,1);
			//convert digit from string to int
			ind4 = Int32.Parse(t4);
			//use digit to find word equivalent
			std4 = numberToWordList[ind4] + " thousand";
			
			//check remaining digits to determine if ", " or " and " should be appended
			string t3 = fullnumber.ToString().Substring(1,1);
			string t12 = fullnumber.ToString().Substring(2,2);
			int it3 = Int32.Parse(t3);
			int it12 = Int32.Parse(t12);
			if (it3 != 0){
				std4 += ", ";
			}
			if ((it3 == 0 ) && (it12 != 0)){
				std4 += " and ";
			}
			
			//remove 4th digit for next conversion
			string tfn = fullnumber.ToString().Substring(1);
			fullnumber = Int32.Parse(tfn);
			noOfDigits = 3;
		}
		
		if ((noOfDigits == 3) && (fullnumber != 0)){
			//get first digit as string
			string t3 = fullnumber.ToString().Substring(0,1);
			//convert digit from string to int
			ind3 = Int32.Parse(t3);
			//use digit to find word equivalent
			std3 = numberToWordList[ind3] + " hundred";
			
			//check remaining digits to determine if " and " should be appended
			string t12 = fullnumber.ToString().Substring(1,2);
			int it12 = Int32.Parse(t12);
			if (it12 != 0){
				std3 += " and ";
			}
			
			//remove 3rd digit for next conversion
			string tfn = fullnumber.ToString().Substring(1);
			fullnumber = Int32.Parse(tfn);
			noOfDigits = 2;
		}
		
		if ((noOfDigits == 2) && (fullnumber != 0)){
			//get last 2 digits as string
			string t12 = fullnumber.ToString();
			//convert digits from string to int
			ind21 = Int32.Parse(t12);
			
			//check if both digits will be used together or apart
			if ((ind21 > 20) && (ind21 % 10 != 0)){//get both digits separately and 
				//get tens digit as string
				string t2 = fullnumber.ToString().Substring(0,1);
				//convert digit from string to int
				ind2 = Int32.Parse(t2);
				ind2 *= 10;
				
				//get ones digit as string
				string t1 = fullnumber.ToString().Substring(1,1);
				//convert digit from string to int
				ind1 = Int32.Parse(t1);
				
				std21 = numberToWordList[ind2] + "-" + numberToWordList[ind1];
			} else {//get both digits together
				//use both digits to find word equivalent
				std21 = numberToWordList[ind21];
			}
		}
		
		if ((noOfDigits == 1) && (fullnumber != 0)){
			//get last digit as string
			string t1 = fullnumber.ToString();
			//convert digit from string to int
			ind1 = Int32.Parse(t1);
			//use digit to find word equivalent
			std1 = numberToWordList[ind1];
			
			//make sure 2nd digit is zero
			ind2 = 0;
		}
		
		if (ind4 != -1){
			fullnumberAsWord += std4;
		}
		if (ind3 != -1){
			fullnumberAsWord += std3;
		}
		if (ind21 != -1){
			fullnumberAsWord += std21;
		} else {
			if ((ind2 != -1) && (ind1 != -1)){
				fullnumberAsWord += std2 + std1;
			} else {
				fullnumberAsWord += std1;
			}
		}
		
		//---------------------------------
			//Console.WriteLine(fullnumberAsWord);
		//---------------------------------
		
		//Remove spaces, commas and hyphens
		fullnumberAsWord = fullnumberAsWord.Replace(" ", "");
		fullnumberAsWord = fullnumberAsWord.Replace(",", "");
		fullnumberAsWord = fullnumberAsWord.Replace("-", "");
		
		//---------------------------------
			//Console.WriteLine(fullnumberAsWord);
		//---------------------------------
		
		//get the number of letters in word form of the number
		int noOfDigitsInWord = fullnumberAsWord.Length;
		
		return noOfDigitsInWord;
	}
}   
