using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        Debug.Log("Hello from the Start Method!");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right"))
        {
            transform.Translate(.1f, 0f, 0f);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(-.1f, 0f, 0f);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0f, .1f, 0f);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(0f, -.1f, 0f);
        }
    }
}
