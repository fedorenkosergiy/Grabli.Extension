[JetBrains.Annotations.PublicAPIAttribute]
public static class FloatExtension
{
	public static bool IsBetweenIncludeEdges(this float single, float first, float second)
	{
		return (single >= first && single <= second) || (single <= first && single >= second);
	}

	public static bool IsBetween(this float single, float first, float second)
	{
		return (single > first && single < second) || (single < first && single > second);
	}
}
