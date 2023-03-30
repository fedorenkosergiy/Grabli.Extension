namespace System.Collections
{
	public static class ICollectionExtension
	{
		public static bool IsEmpty(this ICollection collection) => collection is { Count: 0 };

		public static bool IsNotEmpty(this ICollection collection) => collection is { Count: > 0 };

		public static bool IsNullOrEmpty(this ICollection collection) => collection is null or { Count: 0 };

		public static int FirstIndex(this ICollection collection) => 0;

		public static int LastIndex(this ICollection collection) => collection.Count - 1;
	}
}
