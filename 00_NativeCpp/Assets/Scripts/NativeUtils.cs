using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace NativeCpp
{
	public class NativeUtils
	{
		[DllImport ("Native", EntryPoint="FourFours")]
		private static extern int _FourFours();

		public static int FourFours() {
			return _FourFours();
		}
	}
}
