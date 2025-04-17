using Unity.VisualScripting;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] private float acceleration = 0.5f;
    [SerializeField] private int brake = 3;
    private Rigidbody rb;
    private float lastAccelerate;
    private float lastBrake;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Accelerate"))
        {
            if(Time.time - lastAccelerate < 1) return;
                Vector3 direction = rb.linearVelocity.normalized;
                rb.linearVelocity += acceleration * direction;
                lastAccelerate = Time.time;
                Debug.Log("Accelerated");
        }
        else if (Input.GetButtonDown("Brake"))
        {
            if(Time.time - lastBrake > 0.5) {
                Vector3 direction = rb.linearVelocity.normalized;
                float speed = rb.linearVelocity.magnitude;
                if (speed > brake){;
                rb.linearVelocity -= brake * direction;
            }   else {
                    rb.linearVelocity = new Vector3(0,0,0);
            }
                lastBrake = Time.time;
                Debug.Log("Braking");
            }

        
        }
    }
}
