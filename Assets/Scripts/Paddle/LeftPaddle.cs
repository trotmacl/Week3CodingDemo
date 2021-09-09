using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddle : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // If the W Key is pressed while Unity is processing this frame then move the left paddle up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }

        // If the S Key is pressed while Unity is processing this frame then move the left paddle down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        }

        // Clamp the paddle to the screen when in a 16:9 aspect ratioa
        var yPosition = Mathf.Clamp(transform.position.y, -3.4f, 3.4f);
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
}
