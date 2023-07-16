using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallJump : MonoBehaviour
{
    private Rigidbody2D rb;
 

    public void Jump()
    {
        rb.velocity = new Vector2(0, 5);
    }

    private void Start() { rb = GetComponent<Rigidbody2D>(); }
}
