using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    /// <summary>
    /// If the Colldider2D on the gameObject is set as a trigger this method will get called when a rigidbody overlaps it
    /// </summary>
    /// <param name="collider"></param>
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Look to see if the colliding object is our ball
        if (collider.CompareTag("Ball"))
        {
            // if it is the ball then destroy it, thus removing it from the scene
            Destroy(collider.gameObject);
        }
    }
}
