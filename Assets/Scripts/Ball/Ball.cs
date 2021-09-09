using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    [SerializeField]
    private Rigidbody2D rigidbody = null;

    private Vector3 currentDirection = Vector3.zero;

    /// <summary>
    /// Awake is the first method Unity will invoke on MonoBehaviour's. 
    /// Awake is either invoked at the start of the scene or right after an AddComponent has been used to add a new component to a gameObject
    /// </summary>
    private void Awake()
    {
        currentDirection = new Vector3(Random(), Random(), 0).normalized;
    }

    /// <summary>
    /// Fixed update is Unity's physics update
    /// We want to move the position now so that the physics engine is in sync with any new collisions the movement could have created
    /// </summary>
    void FixedUpdate()
    {
        var newDelta = currentDirection * Time.deltaTime * speed;
        rigidbody.MovePosition(transform.position + newDelta);
    }
 
    /// <summary>
    /// OnCollisionEnter is invoked any time the Ball gameObject interacts with another collider in the scene
    /// The ball only cares about the angle of the collision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
    }

    /// <summary>
    /// Helper method to return only -1 or positive 1 for the direction the ball can move.
    /// </summary>
    /// <returns></returns>
    private int Random()
    {
        return UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
    }
}
