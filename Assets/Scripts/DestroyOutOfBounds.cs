using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField]
    float topBound = 35;

    [SerializeField]
    float lowerBound = -5;

    //Bonus Feature - Medium
    [SerializeField]
    float sideBound = 28;
    //

    //Bonus Feature - Hard
    private GameManager gameManager;
    //

    // Start is called before the first frame update
    void Start()
    {
        //Bonus Feature - Hard
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //
    }

    // Update is called once per frame
    void Update()
    {
        //If an object goes past the players view in the game, remove that object, then show it as "Game Over" in the Unity Console 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over Bound");

            //Bonus Feature - Hard
            gameManager.AddLives(-1);
            // 

            Destroy(gameObject);
        }

        //Bonus Feature - Medium
        else if (transform.position.x < -sideBound)
        {
            //Debug.Log("GameOver Left");

            //Bonus Feature - Hard
            gameManager.AddLives(-1);
            // 

            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            //Debug.Log("GameOver Right");

            //Bonus Feature - Hard
            gameManager.AddLives(-1);
            //

            Destroy(gameObject); 
        }
        //
    }
}
