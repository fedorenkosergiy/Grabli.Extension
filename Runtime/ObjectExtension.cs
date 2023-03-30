using UnityEngine;
using System;
using Object = UnityEngine.Object;

[JetBrains.Annotations.PublicAPIAttribute]
public static class ObjectExtension
{
	public static bool IsNull<T>(this T value) where T : class => !Is(value);

	public static bool Is<T>(this T value) where T : class
	{
		if (value is Object unityObject) return unityObject;

		return value != null;
	}

	public static T UnityLog<T>(this T value)
	{
		Debug.Log(GetValidLog(value));

		return value;
	}

	public static T UnityWarning<T>(this T value)
	{
		Debug.LogWarning(GetValidLog(value));

		return value;
	}

	private static object GetValidLog(object value) => value ?? "NULL";

	public static T UnityLogFormat<T>(this T value, string template)
	{
		string log = string.Format(template, GetValidLog(value));
		Debug.Log(log);

		return value;
	}
}
