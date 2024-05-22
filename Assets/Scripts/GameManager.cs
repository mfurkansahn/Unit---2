using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Hard
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    private static int _score = 0;
    private static int _lives = 3;
    

    public void AddLives(int value)
    {
        _lives += value;

        if (_lives == 0)
        {
            Debug.Log("Game Over");
            Destroy(_player);
        }

        Debug.Log("Lives: " + _lives);
    }

    public void AddScore(int value)
    {
        _score += value;
        Debug.Log("Score: " + _score);
    }
}
//
