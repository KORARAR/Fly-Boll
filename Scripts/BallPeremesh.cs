using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallPeremesh : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float Speed;
    

    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(rb.position.x - Speed, 0));
    }

    private void Start() { rb = GetComponent<Rigidbody2D>(); }
}
