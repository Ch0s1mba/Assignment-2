using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Projectile;
    public GameObject ProjectileClone;
    public float moveSpeed;
    float xInput, yInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireProjectile();
    }

    void FireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //press space to fire projectile
        {
            ProjectileClone = Instantiate(Projectile, new Vector3(Player.transform.position.x,Player.transform.position.y + 0.8f, 0), Player.transform.rotation) as GameObject; //makes the projectile stick to player and also makes a copy of projectile
        }
    }
    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0f * Time.deltaTime); // player movement
    }

    private void OnCollisionEnter2D(Collision2D collision) // destroys Player on collision with tag Edge
    {
        if (collision.gameObject.tag == "Edge")
        {
            Destroy(Player);
        }
    }


}
