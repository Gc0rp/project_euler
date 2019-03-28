/*
 * Created by SharpDevelop.
 * User: 102542177
 * Date: 28/03/2019
 * Time: 4:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace fibSequence
{
	class Program
	{
		
		public static void generateSequence(){
			ulong[] fibNumbers = new ulong[2];
			fibNumbers[0] = 1;
			fibNumbers[1] = 1;
			
			
			ulong sum = 0;
			ulong total = 0;
			
			while(fibNumbers[1] < 4000000){
				
				sum = fibNumbers[0] + fibNumbers[1];
				fibNumbers[0] = fibNumbers[1];
				fibNumbers[1] = sum;
			
				if(sum % 2 == 0){
					total += sum;
				}
				
				
				
			}
			
			Console.WriteLine(total);
		}
		
		public static void Main(string[] args)
		{
			
			generateSequence();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}