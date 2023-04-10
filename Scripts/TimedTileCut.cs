using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedTileCut : MonoBehaviour
{
    public AudioSource theMusic;
    public GameObject levelSpawner;

    // Update is called once per frame
    void Update()
    {
        if (theMusic.isPlaying)
        {
            StartCoroutine(Timedelay());
        }
    }

    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(43);
        levelSpawner.GetComponent<TileManager>().enabled = false;
    }

}
