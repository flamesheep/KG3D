using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public float speed;

    private float HInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HInput = Input.GetAxis("Vertical");

        float rotation = HInput * 0.5f;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(-rotation, 0, 0);

    }
}
