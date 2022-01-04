using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmerMove : MonoBehaviour
{
    public float HInput;
    public float speed = 10;

    public float xRange = 15;

    //public GameObject foodLaunch;

    public GameObject[] throwThings;
    public int thingIndex;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        HInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * HInput * speed);
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 throwPosition = new Vector3(transform.position.x, 2, -3);
            thingIndex = Random.Range(0, throwThings.Length);
            Instantiate(throwThings[thingIndex], throwPosition, Quaternion.identity);
        }
    }
}
