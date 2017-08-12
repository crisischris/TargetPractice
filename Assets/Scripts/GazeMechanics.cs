using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeMechanics : MonoBehaviour
{
    public Material blue;
    public Material red;

    
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
    void Update()
    {

    }

	public void IsGazed (BaseEventData eventData)
	{
		
        GetComponent<Renderer>().material = red;


    }


	public void IsNotGazed (BaseEventData eventData)
	{
        GetComponent<Renderer>().material = blue;
    }

    
}
