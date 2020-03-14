using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cratecontrol : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Debug.Log (this.transform.position);
			other.GetComponent<PlayerController> ().Change(1);
			Destroy (this.gameObject);
		}

		if (other.CompareTag ("Boundary") || other.CompareTag ("Enemy"))

		{
			return;
		}
	}


}
