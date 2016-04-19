using System;
class MainClass {
  public static void Main (string[] args) {
    int limit = 1000;
    
    int result = findMultiples(limit);
    
    Console.WriteLine (result);
  }
  
  public static int findMultiples(int roof){
  	int sum = 0;
  	for(int i = 0; i < roof; i++){
  		if((i%3 == 0) || (i%5 == 0)){
  			sum = sum + i;
  		}
  	}
  	return sum;
  }
}
