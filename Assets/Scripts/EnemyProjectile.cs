using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0)); //speed of projectile

        var player = GameObject.FindGameObjectsWithTag("Player"); //destroys enemy projectiles when there are no player
        if (player.Length == 0)
        {
            Destroy(enemyProjectile);
        }

        var enemy = GameObject.FindGameObjectsWithTag("Enemy"); //destroys enemy projectiles when there are no enemies
        if (enemy.Length == 0)
        {
            Destroy(enemyProjectile);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // destroys objects with player tag on collision
        {
            Destroy(collision.gameObject);
            Destroy(enemyProjectile);
        }

        if (collision.gameObject.tag == "Edge") // destroys enemy projectile on collision with edge
        {
            Destroy(enemyProjectile);
        }

    }
}
