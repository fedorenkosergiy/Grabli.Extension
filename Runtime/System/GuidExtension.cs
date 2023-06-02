namespace System
{
public static class GuidExtension
{
public static string GetUniqueString(this Guid guid, string prefix)
		{
			return prefix + guid;
		}
}
}
