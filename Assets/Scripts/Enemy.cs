using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float moveTime = 0.5f;
    int moveMents = 0;
    float speed = 0.4f;


    public GameObject enemy;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;
    public GameObject player;


    void Start()
    {

    }

   
    void Update()
    {
        if (GameManager.playGame)
        {

            timer += Time.deltaTime;
            if (timer > moveTime && moveMents < 15) // moves 15 times to the right
            {
                transform.Translate(new Vector3(speed, 0f, 0f));
                timer = 0;
                moveMents++;
            }

            if (moveMents == 15) //if moves = 15 go down y axel and move to the opposite
            {
                transform.Translate(new Vector3(0f, -1f, 0f));
                timer = 0;
                moveMents = 0;
                speed = -speed;
                timer = 0f;
            }

            var player = GameObject.FindGameObjectsWithTag("Player"); //if gameobject with tag Player = 0, game over

            if (moveMents != 0f && player.Length == 1f) //if no movements are done don't fire projectiles
            {
                fireEnemyProjectile();
            }

        }
    }

    void fireEnemyProjectile() // fire projectiles at random
    {
        if (Random.Range(0f, 700f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 1f, 0), enemy.transform.rotation) as GameObject; //makes a copy of enemyProjectile
        }
    }
}
