using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneRemover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Destroy(GameObject.FindWithTag("explosion"),3);


    }
}
