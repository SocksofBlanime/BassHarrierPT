using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kremlings : MonoBehaviour
{
    public GameObject[] kremlings;
    public Transform[] points;
    public float beat = 140 / 60;
    private float timer;
    public float moveSpeed;
    public AudioSource theMusic;
   


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (timer > beat)
        {
            GameObject cube = Instantiate(kremlings[Random.Range(0, 1)], points[Random.Range(0, 4)]);
            cube.transform.localPosition = Vector3.forward;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }
        if (!theMusic.isPlaying)
        {
            Destroy(gameObject);

        }
        timer += Time.deltaTime;
    }
}
