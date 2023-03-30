using UnityEngine;

[JetBrains.Annotations.PublicAPIAttribute]
public static class IntExtension
{
	public static bool ToBool(this int value) => value > 0;

	public static TextAnchor ToUnityTextAnchor(this int value) => (TextAnchor)value;

	public static bool IsEven(this int value) => value % 2 == 0;

	public static bool IsOdd(this int value) => !IsEven(value);

	public static bool IsBetween(this int value, int a, int b, bool aIncluded, bool bIncluded)
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
