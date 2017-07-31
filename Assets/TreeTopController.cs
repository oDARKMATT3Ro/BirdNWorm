using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTopController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D what_hit_the_treetop)
    {
        Debug.Log("The Tree Top was hit by: " + what_hit_the_treetop.gameObject.name);
    }
}
