using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DieAfterSeconds : MonoBehaviour
{

    public float SecondsToDie;
    
	
    
	// Use this for initialization
	void Start ()
	{
     
    }

        

	// Update is called once per frame
	void Update ()
	{
      
                 
            Destroy(gameObject,SecondsToDie);
                        
		}
    

    }

    



