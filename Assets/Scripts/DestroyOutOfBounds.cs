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

    // Start is called before the first frame update
    void Start()
    {

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
            Destroy(gameObject);
        }

        //Bonus Feature - Medium
        else if (transform.position.x < -sideBound)
        {
            //Debug.Log("GameOver Left");
            Destroy(gameObject);  
        }
        else if (transform.position.x > sideBound)
        {
            //Debug.Log("GameOver Right");
            Destroy(gameObject);
        }
        //
    }
}
