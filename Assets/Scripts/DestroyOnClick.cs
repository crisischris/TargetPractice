using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyOnClick : MonoBehaviour
{

	bool isClicked = false;
	public GameObject main;
	
    
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
      
        if (isClicked == true) {
                  
            
            Destroy(main);
                        
		}

        


    }

    

	public void Clicked (BaseEventData eventData)
	{
        
		isClicked = true;
				
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
