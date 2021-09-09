using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Ball ballPrefab;

    void Update()
    {
        // If the user presses space add a new ball to the scene
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab);
        }
    }
}
