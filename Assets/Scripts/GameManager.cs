using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool playGame = true;

    public GameObject player;

   // List<GameObject> listOfOpponents = new List<GameObject>();

    public GameObject enemy;

    public Text youWin;

    public Text gameOver;

    public GameObject enemyProjectile;
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        var player = GameObject.FindGameObjectsWithTag("Player"); //if gameobject with tag Player = 0, game over
        if (player.Length == 0)
        {
            gameOver.text = "Game Over";
            Time.timeScale = 0f;
            return;
        }

        var enemy = GameObject.FindGameObjectsWithTag("Enemy"); //if gameobject with tag Enemy = 0, win
        if (enemy.Length == 0)
        {
            youWin.text = "You Win";
            Time.timeScale = 0f;
            return;
        }
    }
}
