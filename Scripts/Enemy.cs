using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int score = 100;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
    }
   private void OnTriggerEnter(Collider other)
   { 
       if (other.gameObject.CompareTag("Bullet"))
       {
            Destroy(other.gameObject);
            GameManager.instance.EnemyHit();
            
       }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Backwall"))
        {
            Destroy(this.gameObject);
            GameManager.instance.EnemyMissed();
        }
    }

}