using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Get Hit, Game Over");
            Destroy(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
