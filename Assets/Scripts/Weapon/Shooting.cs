using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float forwardInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {


        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



        forwardInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * forwardInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
