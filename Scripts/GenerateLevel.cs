using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sectionplane;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;
   
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(sectionplane[secNum], new Vector3(73.664f, -10, zPos), Quaternion.identity);
        zPos += 165; 
        yield return new WaitForSeconds(2f);
        creatingSection = false;

    }
}
