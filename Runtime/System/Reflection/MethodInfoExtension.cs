namespace System.Reflection
{
	public static class MethodInfoExtension
	{
		public static bool IsParameterless(this MethodInfo methodInfo) => methodInfo.GetParameters().Length == 0;
	}
}
