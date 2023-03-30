namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class IReadOnlyCollectionExtension
	{
		public static bool IsEmptyReadOnlyCollection<T>(this IReadOnlyCollection<T> collection)
		{
			return collection is {Count: 0};
		}
	}
}
