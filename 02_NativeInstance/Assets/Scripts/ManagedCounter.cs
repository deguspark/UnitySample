using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

namespace Shogonir.NativeInstance {

	public class ManagedCounter {

		private IntPtr _instance;

		[DllImport ("Native", EntryPoint="com_shogonir_NativeCounter_Create")]
		private static extern IntPtr _Create();

		[DllImport ("Native", EntryPoint="com_shogonir_NativeCounter_Destroy")]
		private static extern void _Destroy(IntPtr instance);

		[DllImport ("Native", EntryPoint="com_shogonir_NativeCounter_Increment")]
		private static extern void _Increment(IntPtr instance);

		[DllImport ("Native", EntryPoint="com_shogonir_NativeCounter_GetCount")]
		private static extern int _GetCount(IntPtr instance);

		public ManagedCounter() {
			_instance = _Create();
		}

		private bool IsDestroyed() {
			return _instance == IntPtr.Zero;
		}

		~ManagedCounter() {
			if (IsDestroyed()) {
				return;
			}
			_Destroy(_instance);
			_instance = IntPtr.Zero;
		}

		public void Increment() {
			if (IsDestroyed()) {
				return;
			}
			_Increment(_instance);
		}

		public int GetCount() {
			if (IsDestroyed()) {
				return -1;
			}
			return _GetCount(_instance);
		}
	}
}
