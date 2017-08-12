using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyOnClickUI : MonoBehaviour {

    public GameObject sign;
    public GameObject text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void OnClick()
    {
        Destroy(sign);
        Destroy(text);

    }
}
