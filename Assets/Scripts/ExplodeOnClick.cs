using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExplodeOnClick : MonoBehaviour
{

	bool isClicked = false;
	public GameObject main;
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

        if (GameObject.Find("Skeet") == null)
        {
            //GameObject.Instantiate(main, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            print("Skeet does not exist!");

        }

        if (isClicked == true) {

            
            xpos = transform.position.x;
            ypos = transform.position.y;
            zpos = transform.position.z;
            Destroy(main);
            GameObject.Instantiate(explode, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            Destroy(explode);

            
		}

        


    }

    

	public void Clicked (BaseEventData eventData)
	{
        
		isClicked = true;
		//ClickedSound.playClip ();
		print ("clicked!" + main.gameObject);
		
	}

	public void IsGazed (BaseEventData eventData)
	{
		GetComponent<Renderer> ().material.color = Color.red;
	}


	public void IsNotGazed (BaseEventData eventData)
	{
		GetComponent<Renderer> ().material.color = Color.white;
	}
}
