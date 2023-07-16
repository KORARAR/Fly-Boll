using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlaser : MonoBehaviour
{
    [SerializeField] private List<Chunc> chuncs;
    [SerializeField] private Chunc[] ChuncPrefabs;
    [SerializeField] private Chunc FirstChunc;
    [SerializeField] private Transform Plane;


    private IEnumerator PovtoralkaChanka()
    {
        while (true)
        {
            if (Plane.position.x > chuncs[^1].Beg.position.x - 30) { Spavn(); }
            if (chuncs.Count >= 10) { DestroyChunk(); }
            yield return new WaitForSeconds(1);
        }
    }

    private void DestroyChunk()
    {
        Destroy(chuncs[0].gameObject);
        chuncs.RemoveAt(0);
    }

    private void Spavn()
    {
        Chunc NewChunc = Instantiate(ChuncPrefabs[Random.Range(0, ChuncPrefabs.Length)]);
        NewChunc.transform.position = new Vector3(chuncs[^1].End.position.x + ((chuncs[^1].Beg.position.x - chuncs[^1].End.position.x) / 2), 0, 0); //тут мы высчитывает расстояние между точками и ставим чанк на нужное расстояние
        chuncs.Add(NewChunc);
    }

    private void Start()
    {
        chuncs.Add(FirstChunc);
        StartCoroutine(PovtoralkaChanka());
    }
}
