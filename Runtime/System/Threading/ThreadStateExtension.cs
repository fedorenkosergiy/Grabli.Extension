namespace System.Threading
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class ThreadStateExtension
	{
		public static bool IsRunning(this ThreadState state) => state == ThreadState.Running;

		public static bool IsStopped(this ThreadState state) => state == ThreadState.Stopped;

		public static bool IsNotRunning(this ThreadState state) => !state.IsRunning();
	}
}
