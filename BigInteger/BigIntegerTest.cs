using System;

namespace Keiwando.BigInteger {
	
	public class BigIntegerTest {

		public static void runTests() {
			
			BigInteger number = new BigInteger ("1000");
			var result = BigInteger.Add (number, new BigInteger("1"));
			Console.Write (result);
		}

		static void Main(string[] args) {
			BigIntegerTest.runTests ();
		}
	}
}

