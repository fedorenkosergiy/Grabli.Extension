using System.Collections.Generic;
using UnityEngine;

[JetBrains.Annotations.PublicAPIAttribute]
public static class StringExtension
{
	public static bool TryGetAssetBundle(this string name, out AssetBundle bundle)
	{
		bundle = default;
		IEnumerable<AssetBundle> bundles = AssetBundle.GetAllLoadedAssetBundles();

		using IEnumerator<AssetBundle> enumerator = bundles.GetEnumerator();

		while (enumerator.MoveNext())
		{
			if (enumerator.Current != null && enumerator.Current.name != name) continue;

			bundle = enumerator.Current;

			return true;
		}

		return false;
	}

	public static GUIContent ToGUIContent(this string text) => new GUIContent(text);

	public static bool IsNullOrEmpty(this string text) => string.IsNullOrEmpty(text);

	public static bool IsSmth(this string text) => !IsNullOrEmpty(text);

	public static bool IsEmpty(this string text) => text.Is() && text.Length == 0;
}
