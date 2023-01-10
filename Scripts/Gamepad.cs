using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamepad : MonoBehaviour
{
    public float leftRightSpeed = 4;
    public float upDownSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
        {
            Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f) * leftRightSpeed;
            transform.position = transform.position + horizontal * Time.deltaTime;
        }
    }

}
