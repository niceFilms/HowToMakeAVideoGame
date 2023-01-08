using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //initializes the speed variable
    public float Speed = 2000f;
    //initialize the sis speed
    public float SisSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per fixed amount of time
    void FixedUpdate()
    {
        //add a force of 2000*deltatime every fixed frame
        rb.AddForce(0, 0, Speed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SisSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SisSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

}
