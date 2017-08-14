using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMovementShooting : MonoBehaviour {
    private float initX;
    private float initY;
    private float initZ;
    private float deviationX;
    private float deviationY;
    
    // Use this for initialization

   


    void Start () {

        initX = transform.position.x;
        initY = transform.position.y;
        initZ = transform.position.z;
               
        deviationX = 1f;
        deviationY = Random.Range(.02f, .06f);
        
    }
	
	// Update is called once per frame
	void Update () {

        
            transform.position = new Vector3(initX + Mathf.PingPong(Time.time / 5, deviationX), initY + Mathf.PingPong(Time.time / 10, deviationY), initZ);
                

    }

        

}
