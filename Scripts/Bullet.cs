using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float life = 3;
   

    void Awake()
    {
        Destroy(gameObject, life);
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
           
        }
        else if (other.gameObject.CompareTag("Special"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameManager.instance.ZapptaEnemy();

        }
        else if (other.gameObject.CompareTag("zoom")){
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameManager.instance.AcidEnemy();
        }

       
    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 70;
    }
}
