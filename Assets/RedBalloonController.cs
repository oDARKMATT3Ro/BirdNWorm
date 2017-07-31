using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBalloonController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D what_hit_the_redballoon)
    {
        Debug.Log("The Red Balloon was hit by: " + what_hit_the_redballoon.gameObject.name);
    }
}
