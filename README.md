# biginteger
A C# BigInteger implementation based on the <a href="http://biginteger.codeplex.com"> BigInteger </a> class by Scott Garland.

This class can be used in Unity, since the <a href="https://msdn.microsoft.com/en-us/library/system.numerics(v=vs.111).aspx" > System.Numerics </a> is not available there.

This version introduces some fixes and additions to the original file. (WIP)
### Current fixes:

- BigInteger.Add(..) was originally subtracting the numbers

### Current additions:

- BigInteger.Pow(base, exponent)  (currently only for positive exponents)
- instance.Pow(exponent)            (currently only for positive exponents)
