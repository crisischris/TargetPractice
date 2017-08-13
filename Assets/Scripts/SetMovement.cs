using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMovement : MonoBehaviour {
    private float initX;
    private float initY;
    private float initZ;
    private float deviationX;
    private float deviationY;
    bool GazedAt = false;
    public AudioClip ClickedSound;
    public AudioSource source;

    // Use this for initialization

    void awake()
    {
        source = GetComponent<AudioSource>();
    }


    void Start () {

        initX = transform.position.x;
        initY = transform.position.y;
        initZ = transform.position.z;
               
        deviationX = 1;
        deviationY = Random.Range(.2f, .4f);
        
    }
	
	// Update is called once per frame
	void Update () {


        if (GazedAt == true)
        {
            transform.position = new Vector3(initX + Mathf.PingPong(Time.time, deviationX), initY + Mathf.PingPong(Time.time, deviationY), initZ);

        }

    }



    public void IsClicked()
    {
        source.PlayOneShot(ClickedSound);

    }

    public void IsGazed()
    {
        GazedAt = true;
    }

    public void NotGazed()
    {
        GazedAt = false;
    }

}
