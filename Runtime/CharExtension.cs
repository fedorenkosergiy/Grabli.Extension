[JetBrains.Annotations.PublicAPIAttribute]
public static class CharExtension
{
	private const char minDecimalDigit = '0';
	private const char maxDecimalDigit = '9';

	public static bool IsDecimalDigit(this char symbol) => symbol is >= minDecimalDigit and <= maxDecimalDigit;
}
