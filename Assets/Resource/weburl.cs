using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weburl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void btnOne()
    {
        Application.OpenURL("www.google.com");
    }
}
