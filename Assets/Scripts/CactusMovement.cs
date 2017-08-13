using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMovement : MonoBehaviour {
    private float initX;
    private float initY;
    private float initZ;
    private float deviationX;
    public AudioClip ClickedSound;
    public AudioSource source;
    private float Speed;


    // Use this for initialization


    void Start () {

        source = GetComponent<AudioSource>();
        initX = transform.position.x;
        initY = transform.position.y;
        initZ = transform.position.z;
               
        deviationX = Random.Range(5.5f,7.5f);
        Speed = Random.Range(.75f,1.25f);
        
    }
	
	// Update is called once per frame
	void Update () {

        
            transform.position = new Vector3(initX + Mathf.PingPong(Time.time*Speed, deviationX), initY, initZ);

        

    }



    public void IsClicked()
    {

       transform.rotation = Quaternion.Euler(90,0,0);

        source.PlayOneShot(ClickedSound);

    }
    

}
