[JetBrains.Annotations.PublicAPIAttribute]
public static class UintExtension
{
	public static bool ToBool(this uint value) { return value > uint.MinValue; }

	public static bool IsEven(this uint value) => value % 2 == uint.MinValue;

	public static bool IsOdd(this uint value) => !IsEven(value);

	public static bool IsBetween(this uint value, uint a, uint b, bool aIncluded, bool bIncluded)
	{
		if (a > b)
		{
			(a, b) = (b, a);

			(aIncluded, bIncluded) = (bIncluded, aIncluded);
		}

		if (value < a) return false;

		if (value == a && value == b && (aIncluded || bIncluded)) return true;

		if (value == a && !aIncluded) return false;

		if (value > b) return false;

		return value != b || bIncluded;
	}
}
