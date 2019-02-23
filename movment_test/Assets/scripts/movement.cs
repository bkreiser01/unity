using UnityEngine;

public class movement : MonoBehaviour {
    public Rigidbody rb;
    public float speed;
    public float jumpHight;
    public bool onGround;
    public Vector3 spawn= new Vector3(0f, 5f, 0f);

    public ParticleSystem particle1;
    public ParticleSystem particle2;

    void OnCollisionEnter(Collision col)
    {
        onGround = true;
    }

    void Update()
    {
        if(rb.position.y < -5)
        {
            rb.position = spawn;
            rb.velocity = Vector3.zero;
            onGround = false;
        }
    }

    void FixedUpdate () {
	    if(Input.GetKey("w"))
        {
            rb.AddForce(0 ,0, speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space") && onGround)
        {
            rb.AddForce(0, (speed * jumpHight) * Time.deltaTime, 0);
            onGround = false;
        }
    }
}
