using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{

    public GameObject playerBullet;
    public GameObject shootLocation;
    public float bulletSpeed;
    public int fireRate;
    public int fireSpeed;


    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = 10f;
        

    }

    //Function to instantiate bullets
    public void BulletGenerator ()
    {
        GameObject bullet = Instantiate(playerBullet, new Vector2(shootLocation.transform.position.x,shootLocation.transform.position.y), Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.right*bulletSpeed,ForceMode2D.Impulse);
    }

    //Function to establish the firing rate of the weapon
    public void StartShootig()
    {
        if(fireRate >= fireSpeed)
        {
            Invoke("BulletGenerator", 1f * Time.deltaTime);
            fireRate = 0;
        }
        else
        {
            fireRate++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the enemy is dead it will stop to instantiate bullets
        if (EnemyController.enemyDead)
        {
            CancelInvoke("BulletGenerator");
        }
        else
        {
            StartShootig();
        }

    }
}
