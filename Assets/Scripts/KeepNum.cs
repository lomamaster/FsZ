using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepNum : MonoBehaviour {
    public int num;

    private void Start()
    {
        num = GetStaticS();
    }

    public void ChangeChar() {
        num = CharacterCreation.s;
		Debug.Log (num);
	}

    public int GetStaticS()
    {
        return CharacterCreation.s;
    }

    //void Update()
  //  {
     //   num = CharacterCreation.s;
        
   // }
}
