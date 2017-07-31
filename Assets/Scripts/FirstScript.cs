using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour {

    public float distance;
    public int count;
    public string message;
    private bool finished;
    public GameObject the_aliveworm;

    // Use this for initialization
    void Start() {

        Debug.Log ("Hello from the Start Method!");
/*
        distance = 0.0f;
        Debug.Log ("The distance value is: " + distance);

        count = 25;
        Debug.Log ("The count is: " + count);

        message = "This is fun!";
        Debug.Log (message);

        finished = false;
        Debug.Log("The value of finished is: " + finished);
*/
        if (count == 0) {
            Debug.Log("The variable count is 0");
        } else {
            Debug.Log("The variable count is not 0");
        }

        // Functions

        int anumber;
        anumber = double_it(5);

        Debug.Log("The doubled value is: " + anumber);

        anumber = double_it(12);

        Debug.Log("The doubled value is: " + anumber);
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey("right"))
        {
            Flip("right");
            transform.Translate(.1f, 0f, 0f);
        }

        if (Input.GetKey("left"))
        {
            Flip("left");
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

    public void Flip( string direction)
    {
        var thescale = transform.localScale;    // get the Transform's scale.
                                                // the x scale must be 1 or -1 for this to work properly
        if (direction == "right")
        {
            thescale.x = 1.0f;                  // flip it to the right by making the x scale negative
        }
        else
        {
            thescale.x = -1.0f;                 // flip it to the left by making the x scale negative
        }
        transform.localScale = thescale;        // set the transform's scale to the proper value
    }

    int double_it(int input_number) {
        var temp = input_number * 2;
        return temp;
    }

    void OnCollisionEnter2D (Collision2D what_the_bird_hit)
    {
        if (what_the_bird_hit.gameObject.name == "theworm")
        {
            Debug.Log("OnCollisionEnter2D was called");
            the_aliveworm.SetActive(false); // this will hide the worm
        }
    }
}
