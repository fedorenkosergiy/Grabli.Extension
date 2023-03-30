namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class LinkedListExtension
	{
		public static bool IsEmpty<T>(this LinkedList<T> list) => ((ICollection)list).IsEmpty();
	}
}
