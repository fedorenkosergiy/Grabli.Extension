using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace System.Reflection
{
	public static class AssemblyExtension
	{
		public static bool IsUnityProjectAssembly(this Assembly assembly)
		{
			if (assembly.IsDynamic || assembly.Location.IsNullOrEmpty()) return false;

			FileInfo fileInfo = new FileInfo(assembly.Location);

			if (fileInfo.Directory is not { Name: ApplicationEx.ScriptAssembliesDirName }) return false;

			DirectoryInfo library = fileInfo.Directory.Parent;

			if (library is not { Name: ApplicationEx.LibraryDirName }) return false;
			if (library.Parent == null) return false;

			string expectedDirectoryPath = ApplicationEx.ProjectPath
														.Replace(Path.AltDirectorySeparatorChar,
															     Path.DirectorySeparatorChar)
														.Trim(Path.DirectorySeparatorChar);


			string actualDirectoryPath = library.Parent.FullName
												.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
												.Trim(Path.DirectorySeparatorChar);

			return expectedDirectoryPath == actualDirectoryPath;
		}

		public static void AddAllTypesWithAttribute<T>(this Assembly assembly, List<Type> listToAdd) where T : Attribute
		{
			Type[] types = assembly.GetTypes();

			for (int i = 0; i < types.Length; i++)
			{
				Type type = types[i];

				if (type.HasAttribute<T>()) { listToAdd.Add(type); }
			}
		}

		public static bool TryGetType(this Assembly assembly, string fullName, out Type type)
		{
			Type[] types = assembly.GetTypes();

			for (int i = 0; i < types.Length; ++i)
			{
				if (types[i].FullName != fullName) continue;

				type = types[i];

				return true;
			}

			type = default;

			return false;
		}
	}
}
