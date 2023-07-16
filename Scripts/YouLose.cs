using UnityEngine;

public class YouLose : MonoBehaviour
{
    public static void Proigrali()
    {
        PanelsPerehod.Pokazat(2);
        PanelsPerehod.Spratat(0);
        TimeController.VremaMenaisa(0);
    }
}
