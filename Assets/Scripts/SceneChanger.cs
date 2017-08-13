using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject cactus3;
    public GameObject cactus4;

    private float cactus1X;

    // Use this for initialization
    void Start()
    {
        print("this is the scene changing script talking");
            
        

       

    }

    // Update is called once per frame
    void Update()
    {

      


        


        if (cactus1.transform.rotation.x > 45)
        {
            print("access to cactus1");
        }
        if (cactus1.transform.rotation.x >= .069 && cactus2.transform.rotation.x >= .069 && cactus3.transform.rotation.x >= .069 && cactus4.transform.rotation.x >= .069)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
            
        }           

    }
}
