using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour {
	public float speedx;
	// Use this for initialization
	void Start () {
		

		GetComponent<Rigidbody> ().velocity = transform.forward * speedx;
		Invoke ("Stop", 1);

	}
	void Stop()
	{
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
	}
}
