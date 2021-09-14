using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public GameObject Projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 10 * Time.deltaTime, 0)); //speed of projectile

        var player = GameObject.FindGameObjectsWithTag("Player"); //destroys enemy projectiles when there are no player
        if (player.Length == 0)
        {
            Destroy(Projectile);
        }

        var enemy = GameObject.FindGameObjectsWithTag("Enemy"); //destroys projectiles when there are no enemies
        if (enemy.Length == 0)
        {
            Destroy(Projectile);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy") // destroys objects with enemy tag on collision
        {
            Destroy(collision.gameObject);
            Destroy(Projectile);
        }

        if (collision.gameObject.tag == "Edge") // destroys projectile on collision with tag Edge
        {
            Destroy(Projectile);
        }

    }
}
