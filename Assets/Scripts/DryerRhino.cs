using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryerRhino : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Debug.Log (this.transform.position);
			other.GetComponent<PlayerController> ().MaskChange(2);
			Destroy (this.gameObject);
		}
		if (other.CompareTag ("Boundary") || other.CompareTag ("Enemy"))

		{
			return;
		}
	}
}
