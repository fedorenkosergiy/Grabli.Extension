using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace System
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class TypeExtension
	{
		private const char typeNameSeparator = '.';

		public static bool HasAttribute<T>(this Type type) where T : Attribute
		{
			return type.GetCustomAttributes(typeof(T), true).Length > 0;
		}

		public static bool TryGetAttribute<T>(this Type type, out T attribute) where T : Attribute
		{
			attribute = null;
			bool result = type.HasAttribute<T>();

			if (result) { attribute = type.GetCustomAttribute<T>(); }

			return result;
		}

		public static bool InheritedFrom<T>(this Type child) => child.InheritedFrom(typeof(T));

		public static bool InheritedFrom(this Type child, Type parent)
		{
			return parent.IsAssignableFrom(child) && child != parent;
		}

		public static MethodInfo[] GetPublicStaticMethods(this Type type)
		{
			return type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);
		}

		public static bool IsNotAbstract(this Type type) { return !type.IsAbstract; }

		public static void GetAllNotAbstractChildrenClasses(this Type type, Assembly assembly, in List<Type> result)
		{
			result.Clear();
			Type[] types = assembly.GetTypes();
			result.Capacity = types.Length;

			for (int i = 0; i < types.Length; ++i)
			{
				Type current = types[i];

				if (current.InheritedFrom(type) && current.IsNotAbstract())
				{
					result.Add(current);
				}
			}
		}

		public static string[] GetNamespaceNodes(this  Type type) => type.Namespace.Split(typeNameSeparator);

		public static string[] GetFullNameNodes(this Type type) { return type.FullName.Split(typeNameSeparator); }

		public static bool IsUnityComponent(this Type type) { return type.IsCastableClass<Component>(); }

		private static bool IsCastableClass<T>(this Type type)
		{
			if (!type.IsClass || type == typeof(object)) { return false; }

			return type == typeof(T) || IsCastableClass<T>(type.BaseType);
		}

		public static bool IsScriptableObject(this Type type) => type.IsCastableClass<ScriptableObject>();

		public static bool IsAttribute(this Type type) => type.InheritedFrom<Attribute>();

		public static bool IsDelegate(this Type type) => type.InheritedFrom<Delegate>();

		public static bool IsVoid(this Type type) => type == typeof(void);
	}
}
