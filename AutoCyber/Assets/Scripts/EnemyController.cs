using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    static public int enemyHealth;
    static public bool enemyDead;


    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //If enemys health reacher 0 it will be destroyed
        if(enemyHealth <=0)
        {
            Destroy(gameObject);
            enemyDead = true;
        }
        
    }
}
