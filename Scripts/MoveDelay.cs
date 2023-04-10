using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDelay : MonoBehaviour
{
    public AudioSource theMusic;
    public GameObject objectSpinner;

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
        yield return new WaitForSeconds(20);
        objectSpinner.SetActive(true);
    }

}
