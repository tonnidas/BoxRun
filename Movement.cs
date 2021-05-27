
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;
    // Use this for initialization
    public float forwardF = 5000f;
    public float sidewayF = 5000f;

    // Update is called once per frame
    void FixedUpdate () {

        rb.AddForce(0, 0, forwardF * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("f"))
        {
            rb.AddForce(0, 2000 * Time.deltaTime, 0);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemnger>().EndGame();

        }


    }
}
