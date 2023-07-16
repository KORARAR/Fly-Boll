using UnityEngine;

public class Obychenie : MonoBehaviour
{
    public void Naychilis()
    {
        PanelsPerehod.Pokazat(0);
        PlayerPrefs.SetInt("Obuch", 1);
        PanelsPerehod.Spratat(3);
        TimeController.VremaMenaisa(1);
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Obuch")) { TimeController.VremaMenaisa(0); return; }
        DestroyObychenie();
    }

    private void DestroyObychenie()
    {
        PanelsPerehod.Pokazat(0);
        PanelsPerehod.Spratat(3);
        TimeController.VremaMenaisa(1);
    }
}
