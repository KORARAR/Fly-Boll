using UnityEngine;

public class TimeController : MonoBehaviour
{
    public static void VremaMenaisa(int indexIzmenenia)
    {
        Time.timeScale = indexIzmenenia;
    }

    private void Start() 
    {
        VremaMenaisa(0);
    }
}
