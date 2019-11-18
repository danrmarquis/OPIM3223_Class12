using UnityEngine;
using System.Collections;

public class BombEmitter : MonoBehaviour
{
    public GameObject bombPrefab;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine (DropBombs ());
    }

    IEnumerator DropBombs ()
    {
        while (Application.isPlaying)
        {
            CreateBomb ();
            yield return new WaitForSeconds (2);
        }
    }

    void CreateBomb ()
    {
        if (bombPrefab != null)
        {
            Instantiate (bombPrefab, transform.position, bombPrefab.transform.rotation);
        }
    }
}
