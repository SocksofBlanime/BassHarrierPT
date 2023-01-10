using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 70;
    }
}
