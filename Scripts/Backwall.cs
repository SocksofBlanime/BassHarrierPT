using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backwall : MonoBehaviour {
  
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
           
        }
        else if (other.gameObject.CompareTag("Special"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("zoom")){
            Destroy(gameObject);
        }

       
    }
}
