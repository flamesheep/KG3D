using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed;

    private float VInput;
    private float HInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VInput = Input.GetAxis("Vertical");
        HInput = Input.GetAxis("Horizontal");

        float rotation = HInput * 0.5f;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * VInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed * HInput);
        transform.Rotate(0, rotation, 0);
    }
}
