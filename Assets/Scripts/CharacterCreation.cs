using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour {

	private List<GameObject> models;

	private int selectionIndex = 0;

	public static int s ;

	private void Start(){
		models = new List<GameObject> ();
		foreach (Transform t in transform) {
			models.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}

		models [selectionIndex].SetActive (true);

        //Debug.Log(s);
	}

	private void Update(){
		if(Input.GetMouseButton(0))
		transform.Rotate (new Vector3 (0.0f, Input.GetAxis ("Mouse X"), 0.0f));
	}

	public void Select (int index){
		if (index == selectionIndex)
			return;
		if (index < 0 || index >= models.Count)
			return;

		models [selectionIndex].SetActive (false);
		selectionIndex = index;
		models [selectionIndex].SetActive(true);
		
	}
	public void loadscene (){
		SceneManager.LoadScene("main", LoadSceneMode.Single);

	}
	public void  Choose()
	{
		Send (0);
	}

	public void  Choose1()
	{
		Send (1);
	}

	public void  Choose2()
	{
		Send (2);
	}


	public void Send (int index){
        //Debug.Log("index = " + index);
		s = index;
        
		//Debug.Log ("s = " + s);
		
	}
}
