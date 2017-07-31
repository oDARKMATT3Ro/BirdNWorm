using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoatController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D what_hit_the_goat)
    {
        Debug.Log("The Goat was hit by: " + what_hit_the_goat.gameObject.name);
    }
}
