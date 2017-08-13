using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SignAction : MonoBehaviour
{

    public GameObject main;
    public GameObject sign2;
    public GameObject text;
    public Rigidbody rb;



    bool Clicked = false;
    private float initX;
    private float initY;
    private float initZ;


    // Use this for initialization
    void Start()
    {

        initX = main.transform.position.x;
        initY = main.transform.position.y;
        initZ = main.transform.position.z;

        rb.mass = 5;
        rb.useGravity = false;
        print(initX);
        print(initY);
        print(initZ);



    }

    // Update is called once per frame
    void Update()
    {

        if (Clicked == true)
        {
            rb.AddForce(Vector3.back * 20);
            rb.useGravity = true;
            GameObject.Instantiate(sign2, new Vector3(1.5f, 2.5f, 3.6f), Quaternion.Euler(0, 0, -10));
            Clicked = false;

        }


        DeleteSign();

    }

    public void SignFall()
    {
        Clicked = true;

       

    }

    void DeleteSign()
    {
        if (main.transform.position.y <= .53f)
        {
            Destroy(main);

        }

    }



}
