using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D what_hit_the_cabin)
    {
        Debug.Log("The Cabin was hit by: " + what_hit_the_cabin.gameObject.name);
    }
}
