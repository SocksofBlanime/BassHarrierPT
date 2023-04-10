using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDelay : MonoBehaviour
{
    public AudioSource theMusic;
    public GameObject enemySpawner;

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
        yield return new WaitForSeconds(95);
        enemySpawner.GetComponent<Kremlings>().enabled = true;
    }

}
