/*
 * Created by SharpDevelop.
 * User: 102542177
 * Date: 28/03/2019
 * Time: 3:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace problem1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number = 0, total = 0;
			
			while(number < 1000){
				if ( (number % 3 == 0) || number % 5 == 0){
					total += number;
				}	
				
				number++;
			}
			
			Console.WriteLine(total);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}