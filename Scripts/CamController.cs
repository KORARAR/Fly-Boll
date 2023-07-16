using UnityEngine;

public class CamController : MonoBehaviour
{
    private Transform Cam;
    [SerializeField] private Transform Ball;


    private void FixedUpdate()
    {
        Cam.position = new Vector3(Ball.position.x, 0, -10);
    }

    private void Start() { Cam = GetComponent<Transform>(); }
}
