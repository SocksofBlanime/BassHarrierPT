using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDelayCam : MonoBehaviour
{
    public GameObject mainCam;
    public AudioSource theMusic;


    // Update is called once per frame
    void Update()
    {
        if (theMusic.isPlaying)
        {
            StartCoroutine(Timedelay());
            StartCoroutine(StopShake());
        }
    }

    IEnumerator Timedelay()
    {
        yield return new WaitForSeconds(23);
        mainCam.GetComponent<Animator>().enabled = true;
    }

    IEnumerator StopShake()
    {
        yield return new WaitForSeconds(103);
        mainCam.GetComponent<Animator>().enabled = false;
    }
}
