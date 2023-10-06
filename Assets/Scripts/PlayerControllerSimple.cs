
using UnityEngine;

public class PlayerControllerSimple : MonoBehaviour
{
    public float forwardSpeed = 0.05f;
    public float jumpForce = 5;
    private float horizontalInput;
    public float sideSpeed = 3f;
    private Vector3 movedirection;

    private bool isTouchingGround;
    
    private ConstantForce cf;
    private Vector3 forceDirection;
    
    public Rigidbody rb;

    [SerializeField] 
    private float downwardForce;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cf = GetComponent<ConstantForce>();
        forceDirection = new Vector3(0, 0, 0);
        
    }


    void Update()
    {
        // Code In the classroom Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        transform.Translate(0,0,forwardSpeed  * Time.deltaTime);
        Move();
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            JumpUp();
        }

        if (isTouchingGround == false && (rb.velocity.y > 0 || rb.velocity.y < 0))
        {
            Debug.Log(rb.velocity);
            Debug.Log("WAS TRIGGERED!!½!!!");
            forceDirection.y = downwardForce;
            cf.force = forceDirection;
        }

        else
        {
            forceDirection.y = 0;
            cf.force = forceDirection;
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
    
    // Used to check if the player is grounded.
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isTouchingGround = true;
            
            // Animation is not used for my character yet.
            // anim.SetBool(IsLanded, true);
            Debug.Log("Player is grounded!");
        }
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isTouchingGround = false;
            // anim.SetBool(IsLanded, false);
            Debug.Log("NO GROUND!");
        }
    }
    
    
}
