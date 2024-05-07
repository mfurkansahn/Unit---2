using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float horizontalInput;

    [SerializeField]
    float speed = 10.0f;

    [SerializeField]
    float xRange = 10.0f;

    //Easy: Bonus Features
    [SerializeField]
    float zRange = 10.0f;
    [SerializeField]
    float verticalInput;
    //

    [SerializeField]
    GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Oyuncunun sýnýrlarýný belirle X eksenine göre
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Easy: Bonus Features
        //Oyuncunun sýnýrlarýný belirle Z eksenine göre
        if (transform.position.z < (-zRange / 10)) //-1
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (-zRange / 10));
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        //

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Easy: Bonus Features
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, this.transform.position, projectilePrefab.transform.rotation);
        }
    }
}
