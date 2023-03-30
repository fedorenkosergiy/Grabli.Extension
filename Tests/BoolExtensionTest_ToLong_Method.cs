using NUnit.Framework;

public partial class BoolExtensionTest
{
	[TestCase(true, 1L)]
	[TestCase(false, 0L)]
	public void CheckToLongConvertion(bool value, long expected)
	{
		long actual = value.ToLong();
		Assert.AreEqual(expected, actual);
	}
}
