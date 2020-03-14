using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController3 : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public Transform shotSpawn2;
	public Transform shotSpawn3;
	public Transform shotSpawn4;

	public float fireRate;
	public float delay;
	public float delay2;
	private AudioSource audioSource;



	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		InvokeRepeating ("Fire",delay,fireRate);
		InvokeRepeating ("Fire2",delay2,fireRate);
	}

	void Fire ()
	{
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		Instantiate (shot, shotSpawn2.position, shotSpawn2.rotation);
		audioSource.Play ();
	}
	void Fire2 ()
	{
		Instantiate (shot, shotSpawn3.position, shotSpawn.rotation);
		Instantiate (shot, shotSpawn4.position, shotSpawn2.rotation);	
		audioSource.Play ();
	}
}
