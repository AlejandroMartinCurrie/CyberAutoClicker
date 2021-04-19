using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCountDownController : MonoBehaviour
{

    public bool bosBarFull;
    [SerializeField] Image fill;

    void Start()
    {
        bosBarFull = false;
    }

    // Update is called once per frame
    void Update()
    {
       fill.fillAmount= EnemySpawner.enemyTestNumber/10f    ;


        if(EnemySpawner.enemyTestNumber >= 10)
        {
            bosBarFull = true;
            print(bosBarFull);
            EnemySpawner.enemyTestNumber = 0;
        }
    }
}
