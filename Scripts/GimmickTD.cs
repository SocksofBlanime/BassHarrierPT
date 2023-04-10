using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelay : MonoBehaviour
{
    public AudioSource theMusic;
    public GameObject hexaBlock;

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
        hexaBlock.GetComponent<GrowRetry>().enabled = true;
    }

}
