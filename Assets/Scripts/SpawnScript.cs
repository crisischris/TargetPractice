using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnScript : MonoBehaviour
{

    public GameObject clayClose;
    public GameObject clayFar;

	// Use this for initialization
	void Start ()
	{

    }

        

	// Update is called once per frame
	void Update ()
	{

     
    }    

	
    


    public void SpawnClayAir()
    {
        
        GameObject.Instantiate(clayClose, new Vector3(2.5f, 6, 5), Quaternion.identity);
    }

    public void SpawnClayGound()
    {

        GameObject.Instantiate(clayFar, new Vector3(30, 6, 20), Quaternion.Euler(90,0,0));
    }




}
