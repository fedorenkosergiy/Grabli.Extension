namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class ICollectionExtension
	{
		public static bool IsEmptyCollection<T>(this ICollection<T> collection) => collection is { Count: 0 };

		public static bool IsNotEmpty<T>(this ICollection<T> collection) => collection is { Count: > 0 };

		public static bool IsNullOrEmpty<T>(this ICollection<T> collection) => collection is null or { Count: 0 };

		public static int FirstIndex<T>(this ICollection<T> collection) => 0;

		public static int LastIndex<T>(this ICollection<T> collection) => collection.Count - 1;
	}
}
