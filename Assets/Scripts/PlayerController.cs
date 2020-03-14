using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Boundary boundary;
	public GameObject shot;
	public GameObject shot2;

	public Transform shotSpawn;
	public Transform shotSpawn2;
	public Transform shotSpawn3;
	public Transform shotSpawn4;
	public Transform shotSpawn5;

	public float fireRate;

	private float nextFire;

	public bool immortal;


	public GameObject basebullet;
	public GameObject[] bullet;

	void Start()
	{
        immortal = true;
		Invoke ("Mortal", 3);
		basebullet = bullet [0];

	}
	void Update ()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;

			if (basebullet == bullet [0]) {
				Instantiate (basebullet, shotSpawn.position, shotSpawn.rotation);
			} 
			else if (basebullet== bullet [1]) {
				Instantiate (basebullet, shotSpawn2.position, shotSpawn2.rotation);
				Instantiate (basebullet, shotSpawn3.position, shotSpawn3.rotation);
			}
			else if (basebullet== bullet [2]) {
				Instantiate (basebullet, shotSpawn.position, shotSpawn.rotation);
				Instantiate (basebullet, shotSpawn4.position, shotSpawn4.rotation);
				Instantiate (basebullet, shotSpawn5.position, shotSpawn5.rotation);
			}
			GetComponent<AudioSource>().Play ();
	}
	}
	
	void FixedUpdate()

	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;

		GetComponent<Rigidbody>().position = new Vector3
			(
				Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (GetComponent<Rigidbody>().position.z,  boundary.zMin,  boundary.zMax)
			);
		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}

	public void Change(int i)
	{
		
		basebullet = bullet [i];
	}
	public void MaskChange(int i)
	{

		basebullet = bullet [i];
	}
	void Mortal() {
		immortal = false;
	}

}
