using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCountDownController : MonoBehaviour
{

    public bool bosBarFull;


    void Start()
    {
        bosBarFull = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Slider>().value = EnemySpawner.enemyTestNumber;


        if(EnemySpawner.enemyTestNumber >= 10)
        {
            bosBarFull = true;
            print(bosBarFull);
            EnemySpawner.enemyTestNumber = 0;
        }
    }
}
