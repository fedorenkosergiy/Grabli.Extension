namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class IDictionaryExtension
	{
		public static void GetPairs<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
												  List<KeyValuePair<TKey, TValue>> toAddTo)
		{
			toAddTo.AddRange(dictionary);
		}
	}
}
