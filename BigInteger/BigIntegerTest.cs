using System;

namespace Keiwando.BigInteger {
	
	public class BigIntegerTest {

		public static void RunTests() {
			
			TestAddition();
			TestExponentiation ();
			CustomTest ();
		}

		private static void TestAddition() {
			BigInteger number = new BigInteger ("1000");
			var result = BigInteger.Add (number, new BigInteger("1"));
			Assert (result == 1001, "static Add not working - result: " + result);
		}

		private static void TestExponentiation() {
			BigInteger b = 410;
			BigInteger exponent = 29;
			BigInteger result = BigInteger.Pow (b, exponent);
			result = b.Pow(exponent);
			Console.WriteLine (b + "^" + exponent + " = " + result);
		}

		private static void CustomTest() {
			BigInteger number = new BigInteger ("1");
			Console.WriteLine (number.GetDataAsString ());
			Console.WriteLine (UInt32.MaxValue);
		} 

		static void Main(string[] args) {
			BigIntegerTest.RunTests ();
			Console.Write ("All tests run successfully!");
		}

		static void Assert(bool condition, string message)
		{
			if (!condition) throw new Exception(message);
		}
	}
}

