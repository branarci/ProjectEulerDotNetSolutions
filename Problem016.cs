/**Power digit sum
Problem 16
Published on Friday, 3rd May 2002, 06:00 pm; Solved by 149492; Difficulty rating: 5%
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^1000?
*/


using System;
using System.Collections.Generic;
using System.Text;

class MainClass {
	public static void Main (string[] args) {
				
		//Repeat for each power (2^count)
		//Always starts at 2^1
		int count = 1000;
		string svar = "2";
		for(int i = 1; i < count; i++){
			svar = multipleAndAdd(svar);
		}
		Console.WriteLine("string: " + svar);
		
		//Calculate the sum of the digits in the string
		int total = 0;
		foreach(char c in svar){
			int t = Int32.Parse(c.ToString());
			total += t;
		}
		Console.WriteLine("sum of digits: " + total);
	}
	
	public static string multipleAndAdd(string s){
		//Change string into list of numbers
		List<int> listIn = new List<int>();
		foreach(char c in s){
			int t = Int32.Parse(c.ToString());
			listIn.Add(t);
		}
		
		//Reverse list of numbers to work by smallest to largest
		//e.g. ones before tens ...etc
		listIn.Reverse();
		
		//Sets up the lists to use
		//Adds 0 to overflow to align lists
		List<int> list2 = new List<int>();
		List<int> list2Overflow = new List<int>();
		list2Overflow.Add(0);

		//Multiple each number in the list by 2
		//then separate the results into ones and tens
		foreach(int i in listIn){
			int t = i*2;
			
			//Find the number of digits in the result
			double d = Math.Floor(Math.Log10(t) + 1);

			//If the results is larger than a single number
			//Store the output in one list
			//and the overflow in the other list
			if(d > 1){
				string ts = t.ToString();
				int tones = Int32.Parse(ts.Substring(1, 1));
				int ttens = Int32.Parse(ts.Substring(0, 1));
				list2.Add(tones);
				list2Overflow.Add(ttens);
			}else{
				list2.Add(t);
				list2Overflow.Add(0);
			}
		}
		
		//Used to even out the list counts of the 2 lists
		list2.Add(0);
		
		//While loop exit condition
		bool condition = true;
    
		//Add the lists together to get another list
		//Loop until second overflow list sum is 0
		while(condition == true){
			//[Testing] Check used to see if lists are the same length (count)
			if(list2.Count != list2Overflow.Count){
				Console.WriteLine("error: list count mismatch");
			}
			
			//sets up the lists to use and adds 0 to overflow to align lists
			List<int> listt = new List<int>();
			List<int> listtOverflow = new List<int>();
			listtOverflow.Add(0);
			
			//Add each number from both lists together
			//then separate the results into ones and tens
			for(int i = 0; i < list2.Count; i++){
				int t = list2[i] + list2Overflow[i];
				
				//Find the number of digits in the result
				double d = Math.Floor(Math.Log10(t) + 1);
				
				//If the results is larger than a single number
				//Store the output in one list
				//and the overflow in another list
				if(d > 1){
					string ts = t.ToString();
					int tones = Int32.Parse(ts.Substring(1, 1));
					int ttens = Int32.Parse(ts.Substring(0, 1));
					listt.Add(tones);
					listtOverflow.Add(ttens);
				}else{
					listt.Add(t);
					listtOverflow.Add(0);
				}
			}
			
			//Check overflow list to see if all overflows are included
			//i.e. all numbers that overflowed are supposed to be added to the result
			int total = 0;
			foreach(int i in listtOverflow){
				total += i;
			}
			
			//Check to see if the overflow list still contains numbers,
			//Repeat loop to merge overflow
			//or prepare list into to be returned as a string
			if(total > 0){
				list2 = listt;
				list2Overflow = listtOverflow;
			}else{
				//Reverse the list back to normal order
				listt.Reverse();
				
				//Convert list into a single string
				StringBuilder builder = new StringBuilder();
				foreach(int i in listt){
					builder.Append(i);
				}
				s = builder.ToString();
				
				//Remove any leading zeros caused by aligning ones and tens
				s = s.TrimStart(new Char[] { '0' } );
				
				//End loop
				condition = false;
			}
		}
		
		//Return the original string if failed
		//or return the new number
		return s;
	}
}
