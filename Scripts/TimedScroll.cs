using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedScroll : MonoBehaviour
{
    public float scrollSpeedX;
    public float scrollSpeedY;
    private MeshRenderer meshRenderer;
    public AudioSource theMusic;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset = new Vector2(Time.realtimeSinceStartup * scrollSpeedX, Time.realtimeSinceStartup * scrollSpeedY);
        if (theMusic.isPlaying)
        {
            StartCoroutine(TimeScroll());
        }
    }

    IEnumerator TimeScroll()
    {
        yield return new WaitForSeconds(16);
        scrollSpeedX = 0;
        scrollSpeedY = 1;
    }
}
