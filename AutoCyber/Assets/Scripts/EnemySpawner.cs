using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public static int enemyTestNumber;
    public Color blueColor;
    public Color currentColor;
    // Start is called before the first frame update
    void Start()
    {
        blueColor = Color.blue;
        currentColor = Color.red;
        enemyToSpawn.GetComponent<SpriteRenderer>().color = currentColor;
        enemyTestNumber = 0;
        Instantiate(enemyToSpawn, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyController.enemyDead)
        {
            /////////////////////////Testeo de contador de enemigos
            enemyTestNumber++;
            //print("Este es el enimgo " + enemyTestNumber);
            if(enemyTestNumber == 1)
            {
                enemyToSpawn.GetComponent<SpriteRenderer>().color = blueColor;    
            }
            /*else
            {
                enemyToSpawn.GetComponent<SpriteRenderer>().color = currentColor;
                enemyTestNumber = 0;
            }*/

            EnemyController.enemyDead = false;
            Instantiate(enemyToSpawn, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            print(enemyTestNumber);
        }
    }
}
