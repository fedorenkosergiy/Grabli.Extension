using NUnit.Framework;

public partial class BoolExtensionTest
{
	[TestCase(true, 1u)]
	[TestCase(false, 0u)]
	public void CheckToUintConvertion(bool value, uint expected)
	{
		uint actual = value.ToUint();
		Assert.AreEqual(expected, actual);
	}
}

