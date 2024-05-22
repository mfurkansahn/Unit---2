using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player Get Hit, Game Over");

            //Bonus Feature - Hard
            gameManager.AddLives(-1);
            //

            Destroy(gameObject);
        }

        //Bonus Feature - Hard
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);
            //

            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }       

    }
}
