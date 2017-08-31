using UnityEngine;

public class PlayerMovment : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("q"))
        {
            Application.Quit();
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange) ;
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       // if (rb.position.y < -1f || rb.position.x < -8.2f || rb.position.x > 8.2f)

       if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            enabled = false;
        }
    }

}
