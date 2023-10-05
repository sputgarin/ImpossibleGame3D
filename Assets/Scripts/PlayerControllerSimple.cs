
using UnityEngine;

public class PlayerControllerSimple : MonoBehaviour
{
    public float forwardSpeed = 0.05f;
    public int jumpForce = 5;
    private float horizontalInput;
    public float sideSpeed = 3f;
    private Vector3 movedirection;

    private float initialGravityScale;
    private ConstantForce cf;

    public Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cf = GetComponent<ConstantForce>();
        
    }


    void Update()
    {
        transform.Translate(0,0,forwardSpeed  * Time.deltaTime);
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpUp();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(movedirection.x * sideSpeed, rb.velocity.y, rb.velocity.z);
    }

    public void JumpUp()
    {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        movedirection = new Vector3(horizontalInput , 0 ,0);
        
    }
    
    
}
