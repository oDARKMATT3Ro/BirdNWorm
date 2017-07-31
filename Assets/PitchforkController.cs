using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchforkController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D what_hit_the_pitchfork)
    {
        Debug.Log("The Pitchfork was hit by: " + what_hit_the_pitchfork.gameObject.name);
    }
}
