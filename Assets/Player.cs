using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public float force;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.AddForce(Vector3.up * force);
            print("I´m pressing the jump button");
        }
    }
}
