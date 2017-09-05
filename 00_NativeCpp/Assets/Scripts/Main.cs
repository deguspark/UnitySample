using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NativeCpp
{
	public class Main : MonoBehaviour
	{
		void Start ()
		{
			Debug.Log(NativeUtils.FourFours());
		}
	}
}
