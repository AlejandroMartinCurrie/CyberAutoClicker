using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int bulleteDamage;

    // Start is called before the first frame update
    void Start()
    {
        bulleteDamage = 2;
    }


    //Detects collision for the bullet and calls he function to do damage to the enemy
    private void OnCollisionEnter2D(Collision2D hitTarget)
    {
        if(hitTarget.gameObject.tag == "enemy")
        {
            RecieveDamage();
            Destroy(gameObject);
            //print(EnemyController.enemyHealth);
        }
    }

    public void RecieveDamage()
    {
        EnemyController.enemyHealth = EnemyController.enemyHealth - bulleteDamage;
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
