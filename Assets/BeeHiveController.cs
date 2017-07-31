using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeHiveController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D what_hit_the_beehive)
    {
        Debug.Log("The Bee Hive was hit by: " + what_hit_the_beehive.gameObject.name);
    }
}
