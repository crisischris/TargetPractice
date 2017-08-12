using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMovement : MonoBehaviour {
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

        print("X = " + initX);
        print("Y = " + initY);
        print("Z = " + initZ);

        deviationX = 1;
        deviationY = Random.Range(.35f, .4f);

    }
	
	// Update is called once per frame
	void Update () {

        


        transform.position = new Vector3(initX + Mathf.PingPong(Time.time, deviationX), initY + Mathf.PingPong(Time.time, deviationY), initZ);


    }

   
}
