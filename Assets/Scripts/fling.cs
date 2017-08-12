using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fling : MonoBehaviour
{

	bool isClicked = false;
	public float vel;
	public GameObject main;
	public Rigidbody rb;
    public GameObject explode;
    float xpos;
    float ypos;
    float zpos;
    
	//AudioManager ClickedSound;

	// Use this for initialization
	void Start ()
	{
        /*
        ClickedSound = gameObject.AddComponent<AudioBehaviour>();
		ClickedSound.soundBite =  gameObject.AddComponent<AudioSource> ();;
		ClickedSound.intializeClip ();
        */
    }

        

	// Update is called once per frame
	void Update ()
	{
		if (isClicked == true && transform.position.y <= 0 || transform.position.y >= 100 || transform.position.z >= 100) {
			main.GetComponent<Renderer>().enabled = false;;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.useGravity = false;
			isClicked = false;
            xpos = transform.position.x;
            ypos = transform.position.y;
            zpos = transform.position.z;
            Destroy(main);
            GameObject.Instantiate(explode, new Vector3(xpos, ypos, zpos), Quaternion.identity);



		}
	}

    

	public void Clicked (BaseEventData eventData)
	{
        Vector3 randomDirection = new Vector3 (Random.value, Random.value, Random.value);
		rb.AddForce (randomDirection * vel);
		rb.useGravity = true;
		isClicked = true;
		//ClickedSound.playClip ();
		print ("clicked!" + main.gameObject);
		print (randomDirection);
	}

	public void IsGazed (BaseEventData eventData)
	{
		GetComponent<Renderer> ().material.color = Color.red;
	}


	public void IsNotGazed (BaseEventData eventData)
	{
		GetComponent<Renderer> ().material.color = Color.yellow * Random.value;
	}
}
