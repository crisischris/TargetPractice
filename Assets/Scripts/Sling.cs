using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sling : MonoBehaviour
{

    public scoreManager ScoreKeeper;

    //bool isClicked = false;
    public float vel;
    public Rigidbody rb;
    public GameObject explode;
    float xpos;
    float ypos;
    float zpos;
    public bool IsSlung = false;
    public SpawnScript SpawnManager;
    bool LaunchItClose = false;
    bool LaunchItFar = false;
    BoxCollider boxCollider;

    //AudioManager ClickedSound;

    // Use this for initialization
    void Start()
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



        if (LaunchItClose == true)
        {
            LaunchClose();
            LaunchItClose = false;
        }

        if (LaunchItFar == true)
        {
            LaunchFar();
            LaunchItFar = false;
        }


        if (gameObject.transform.position.y <= .5f)
        {

            DestroyOutOfBounds();
        }

        if (gameObject.transform.position.x > 75 && gameObject.transform.position.x < 150 || gameObject.transform.position.z > 75 && gameObject.transform.position.z < 150)
        {
            boxCollider = gameObject.GetComponent<BoxCollider>();
            boxCollider.size = new Vector3(2, 2, 2);

        }

        if (gameObject.transform.position.x > 150 || gameObject.transform.position.z > 150)
        {
            boxCollider = gameObject.GetComponent<BoxCollider>();
            boxCollider.size = new Vector3(3, 3, 3);

        }

        


    }

    public void LaunchClose()
    {
        if (gameObject.transform.position.x < 6 && gameObject.transform.position.y < 6 && gameObject.transform.position.z < 6)
        {
            Vector3 randomDirection = new Vector3(0, Random.Range(.25f, 1), Random.Range(.5f, .75f));
            rb.AddForce(randomDirection * vel);
            rb.useGravity = true;
        }


    }


    public void LaunchFar()
    {
        if (gameObject.transform.position.x > 28)
        {
            Vector3 randomDirection = new Vector3(Random.Range(-.25f, -1), 0, 0);
            rb.AddForce(randomDirection * vel);
            rb.useGravity = true;
        }


    }


    public void Clicked()
    {
        xpos = gameObject.transform.position.x;
        ypos = gameObject.transform.position.y;
        zpos = gameObject.transform.position.z;
        Destroy(gameObject);
        GameObject.Instantiate(explode, new Vector3(xpos, ypos, zpos), Quaternion.identity);
        ScoreKeeper.IsScored();

    }

    public void DestroyOutOfBounds()
    {
        Destroy(gameObject);

    }

    public void IsGazedClose(BaseEventData eventData)
    {
        LaunchItClose = true;

    }


    public void IsGazedFar(BaseEventData eventData)
    {
        LaunchItFar = true;

    }



}
