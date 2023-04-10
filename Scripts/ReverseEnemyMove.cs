using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseEnemyMove : MonoBehaviour
{

    private List<GameObject> activeEnemies = new List<GameObject>();
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * -30;
        if (!this.gameObject)
        {
            DeleteTile();
        }
    }

    private void DeleteTile()
    {
        Destroy(activeEnemies[0]);
        activeEnemies.RemoveAt(0);
    }
}
