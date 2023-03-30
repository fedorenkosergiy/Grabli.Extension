namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
    public static class IReadOnlyListExtension
    {
        public static T First<T>(this IReadOnlyList<T> list) => list[0];
	}
}
