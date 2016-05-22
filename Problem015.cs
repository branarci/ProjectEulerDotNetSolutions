/**Lattice paths
Problem 15
Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

image @ https://projecteuler.net/problem=15

How many such routes are there through a 20×20 grid?
*/


using System;
class MainClass {
  public static void Main (string[] args) {
    grid(20, 20);
  }

  public static void grid(int xm, int ym){
  	int xmax = xm + 1;
  	int ymax = ym + 1;
  	
  	long[,] array = new long[xmax, ymax];
  	
  	for(int x = 0; x < xmax; x++){
	  	for(int y = 0; y < ymax; y++){
  			array[x,y] = valuefunc(array, x, y);
  		}
  	}
  	
  	for(int x = 0; x < xmax; x++){
  		for(int y = 0; y < ymax; y++){
  			Console.Write(array[x,y] + "\t");
  		}
  		Console.WriteLine();
  	}
  	
  	Console.WriteLine("************");
  	Console.WriteLine(array[xm,ym]);
  }
  
  public static long valuefunc(long[,] a, int x, int y){	
	long value = 0;
	
	if((x == 0) && (y == 0)){
  		value = 0;
  	}else if(x == 0){
  		value = y;
  	}else if(y == 0){
  		value = x;
  	}else if(x == 1){
  		value = y + 1;
  	}else if(y == 1){
  		value = x + 1;
  	}else{
  		value = a[x-1,y] + a[x,y-1];
  	}

  	return value;
  }
  
}

/**
int maxX = 20;
//maxY = [a through t] = 20;
long total = 0;

for(int a = 0; a < maxX; a++{
for(int b = a; b < maxX; b++{
for(int c = b; c < maxX; c++{
for(int d = c; d < maxX; d++{
for(int e = d; e < maxX; e++{
for(int f = e; f < maxX; f++{
for(int g = f; g < maxX; g++{
for(int h = g; h < maxX; h++{
for(int i = h; i < maxX; i++{
for(int j = i; j < maxX; j++{
for(int k = j; k < maxX; k++{
for(int l = k; l < maxX; l++{
for(int m = l; m < maxX; m++{
for(int n = m; n < maxX; n++{
for(int o = n; o < maxX; o++{
for(int p = o; p < maxX; p++{
for(int q = p; q < maxX; q++{
for(int r = q; r < maxX; r++{
for(int s = r; s < maxX; s++{
for(int t = s; t < maxX; t++{
	total++;
}}}}}}}}}}}}}}}}}}}}

Console.WriteLine(total);
*/
