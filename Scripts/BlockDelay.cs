using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickTD : MonoBehaviour
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
        yield return new WaitForSeconds(23);
        enemySpawner.GetComponent<Animator>().enabled = true;
    }

}
