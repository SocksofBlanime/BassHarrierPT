using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -18.5f;
    public static float rightSide = 18.5f;
    public static float topSide = 15.5f;
    public static float bottomSide = 1;
    public float internaltop;
    public float internalbottom;
    public float internalLeft;
    public float internalRight;
 
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
        internalbottom = bottomSide;
        internaltop = topSide;
    }
}
