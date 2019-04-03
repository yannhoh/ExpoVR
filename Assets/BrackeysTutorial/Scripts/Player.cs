
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float forwardForcePlayer = 500f;
    public float sidewaysForce = 500f; 

	// Use this for initialization
	/*void Start () {

        rb.AddForce(0,200,0);

	} */
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // add a forward force

        if ( Input.GetKey ("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForcePlayer * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForcePlayer * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
 
    }
}
