using UnityEngine;

public class Vrezalis : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        YouLose.Proigrali();
    }
}
