using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float JumpHieght;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRb = GetComponent<Rigidbody>();
            PlayerRb.AddForce(Vector3.up * JumpHieght, ForceMode.Impulse);
        }
    }
}
