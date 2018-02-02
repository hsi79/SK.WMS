using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

namespace NEXCORE.Components.ComponentManager
{
	/// <summary>
	/// RemoteLoader
	/// </summary>
	public class Loader: MarshalByRefObject
	{
		private Assembly assembly;

		public Loader()
		{
		}

		public MethodList Load(string fileName)
		{
			MethodList functionList = new MethodList();

			try
			{
                assembly = Assembly.LoadFrom(fileName);

                Skcc.Diagnostics.LogWrapper.Write("Load assembly : " + assembly.FullName, "Framework");
                foreach (Type t in assembly.GetTypes())
                {
                    functionList.AddFromType(t, fileName);
                }
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
                Skcc.Diagnostics.LogWrapper.Write(e.ToString(), "Framework");
			}
			return functionList;
		}

		public MethodList LoadFrom(string FileName)
		{
			MethodList functionList = new MethodList();

			assembly = Assembly.LoadFrom(FileName);

			foreach (Type t in assembly.GetTypes())
			{
				functionList.AddFromType(t);
			}
			return functionList;
		}
		
		public MethodInfo GetMethod(string Name)
		{
			foreach (Type t in assembly.GetTypes())
			{
				MethodInfo[] methods = t.GetMethods();

				foreach (MethodInfo mi in methods)
				{
					if (mi.Name == Name)
						return mi;
				}
			}
			return null;
		}

		public MethodInfo GetMethod(string Name, string TypeName)
		{
			Type t = assembly.GetType(TypeName);
			MethodInfo[] methods = t.GetMethods( BindingFlags.Public);

			foreach (MethodInfo mi in methods)
			{
				if (mi.Name == Name)
					return mi;
			}
			return null;
		}

        private byte[] LoadFile(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, System.IO.FileAccess.Read);
            byte[] buffer = new byte[(int)fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            return buffer;
        }
	}
}
