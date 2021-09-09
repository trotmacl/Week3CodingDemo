using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // If the I Key is pressed while Unity is processing this frame then move the right paddle up
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }

        // If the J Key is pressed while Unity is processing this frame then move the right paddle down
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        }

        // Clamp the paddle to the screen when in a 16:9 aspect ratioa
        var yPosition = Mathf.Clamp(transform.position.y, -3.4f, 3.4f);
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
}
