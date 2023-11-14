
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerSimple : MonoBehaviour
{
    public bool canJump = true;
    public float forwardSpeed = 0.05f;
    public float jumpForce = 5;
    private float horizontalInput;
    public float sideSpeed = 3f;
    private Vector3 movedirection;
    

    private bool isTouchingGround;
    
    private ConstantForce cf;
    private Vector3 forceDirection;
    
    public Rigidbody rb;

    private int colliderCounter;

    [SerializeField] 
    private float downwardForce;

    public GameObject explosion;
    public Vector3 startingPosition;
    
    public MeshRenderer spaceshipRenderer;
    
    void Start()
    {
        spaceshipRenderer = GetComponentInChildren<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        cf = GetComponent<ConstantForce>();
        forceDirection = new Vector3(0, 0, 0);
        startingPosition = this.gameObject.transform.position;

    }


    void Update()
    {
        // Code In the classroom Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        // MoveForwardAtForwardSpeed();
        Move();
        if (Input.GetButtonDown("Jump") && isTouchingGround && canJump == true)
        {
            JumpUp();
        }

        if (isTouchingGround == false && (rb.velocity.y > 0 || rb.velocity.y < 0))
        {
            AddForceWhenPlayerGoesUpAndDown();
        }

        else
        {
            forceDirection.y = 0;
            cf.force = forceDirection;
        }
    }

    private void FixedUpdate()
    {
        
        rb.velocity = new Vector3(movedirection.x * sideSpeed, rb.velocity.y, forwardSpeed );
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
    
    
    private void AddForceWhenPlayerGoesUpAndDown()
    {
        Debug.Log(rb.velocity);
        Debug.Log("Add Force!");
        forceDirection.y = downwardForce;
        cf.force = forceDirection;
    }

    private void MoveForwardAtForwardSpeed()
    {
        // Marc's code using velocity with the rigidbody. might need to change but then it might 
        // Change the whole game. need to test.
        // rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, forwardSpeed);
        transform.Translate(0, 0, forwardSpeed * Time.deltaTime);
    }
    
    // Used to check if the player is grounded.
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            colliderCounter++;
            Debug.Log(colliderCounter);
            if (colliderCounter > 0)
            {
                isTouchingGround = true;
            Debug.Log("Player is grounded!");
            }
            
            
            // Animation is not used for my character yet.
            // anim.SetBool(IsLanded, true);
        }
    }

    /*
    bool isTrouchingGround()
    {
        int layerMask = LayerMask.GetMask(("Ground"));
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
    */
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            colliderCounter--;
            Debug.Log(colliderCounter);
            if (colliderCounter < 1)
            {
                isTouchingGround = false;
                Debug.Log("NO GROUND!");
            }
            
            // anim.SetBool(IsLanded, false);
            
        }
    }

    public void Death()
    {
        
        //Collider spaceshipCollider;
        
        spaceshipRenderer.enabled = false;
        explosion.SetActive(true);
        this.GetComponent<PlayerControllerSimple>().enabled = false;
        rb.isKinematic = true;
        //spaceshipCollider = GetComponent<Collider>();
        //spaceshipCollider.enabled = false;
    }

    public void Respawn()
    {
        explosion.SetActive(false);
        this.gameObject.transform.position = startingPosition;
        spaceshipRenderer.enabled = true;
        this.GetComponent<PlayerControllerSimple>().enabled = true;
        rb.isKinematic = false;
        
    }
    
}
