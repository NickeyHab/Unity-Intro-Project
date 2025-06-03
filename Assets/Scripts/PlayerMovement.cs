using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float jumpHeight = 10f;
    [SerializeField] private Transform FloorCheck;
    [SerializeField] private LayerMask FloorLayer;
    [SerializeField] private float rotationDamping = 1f;
    private float FloorCheckRadius;
    private Rigidbody rb;
    private float horizontal;
    private float vertical;
    private float g = -9.81f;
    private float rotationAngle;
    private bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FloorCheckRadius = FloorCheck.localScale.y;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rotationAngle += rotationSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(transform.eulerAngles.x, rotationAngle, transform.eulerAngles.z);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationDamping * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity += Mathf.Sqrt(-jumpHeight * 2 * g) * Vector3.up;
        }
            
    }

    private void FixedUpdate() {
        Vector3 localMovement = new Vector3(horizontal, 0, vertical);
        
        if (localMovement.sqrMagnitude > 1f)
            localMovement.Normalize();
        
        Vector3 worldMovement = transform.TransformDirection(localMovement) * speed;
        rb.MovePosition(rb.position + worldMovement * Time.fixedDeltaTime);
        
        isGrounded = Physics.CheckSphere(FloorCheck.position, FloorCheckRadius, FloorLayer);
    }

}