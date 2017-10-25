using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shogonir.NativeInstance {

	public class Main : MonoBehaviour {

		void Start () {
			ManagedCounter counter = new ManagedCounter();
			Debug.Log("count : " + counter.GetCount());
			counter.Increment();
			counter.Increment();
			counter.Increment();
			Debug.Log("count : " + counter.GetCount());
			counter.Increment();
			counter.Increment();
			Debug.Log("count : " + counter.GetCount());
		}
	}
}
