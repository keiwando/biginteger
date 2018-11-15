using System;
using ScottGarland;

namespace Keiwando.BigIntegerTest {

	public class BigIntegerTest {

		public static void RunTests() {

			//TestAddition();
			//TestExponentiation();
			//CustomTest();
			TestShift();
			MicrosoftTestShift();
		}

		private static void TestAddition() {
			BigInteger number = new BigInteger("1000");
			var result = BigInteger.Add(number, new BigInteger("1"));
			Assert(result == 1001, "static Add not working - result: " + result);
		}

		private static void TestExponentiation() {
			BigInteger b = 410;
			BigInteger exponent = 29;
			BigInteger result = BigInteger.Pow(b, exponent);
			result = b.Pow(exponent);
			Console.WriteLine(b + "^" + exponent + " = " + result);
		}

		private static void CustomTest() {
			BigInteger number = new BigInteger("1");
			Console.WriteLine(number.GetDataAsString());
			Console.WriteLine(UInt32.MaxValue);
		}

		private static void TestShift() {
			Console.WriteLine("Shift Test");
			var number = new BigInteger(long.MinValue);
			var shiftAmount = 1;
			var leftShift = number << shiftAmount;
			var rightShift = leftShift >> shiftAmount;
			Console.WriteLine(string.Format("{0} << {1} = {2}", number, shiftAmount, leftShift));
			Console.WriteLine(string.Format("{0} >> {1} = {2}", leftShift, shiftAmount, rightShift));
		}

		/// <summary>
		/// Based on https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger.op_leftshift?view=netframework-4.7.2
		/// </summary>
		private static void MicrosoftTestShift() { 
		
			BigInteger number = new BigInteger("-9047321678449816249999312055");
			Console.WriteLine("Shifting {0} left by:", number);
			for (int ctr = 0; ctr <= 16; ctr++) {
				BigInteger newNumber = BigInteger.Multiply(number, BigInteger.Pow(2, ctr));
				Console.WriteLine(" {0,2} bits: {1,35}",
								  ctr, newNumber);
			}
		}

		static void Main(string[] args) {
			BigIntegerTest.RunTests ();
			//Console.Write ("All tests run successfully!");
		}

		static void Assert(bool condition, string message)
		{
			if (!condition) throw new Exception(message);
		}
	}
}

