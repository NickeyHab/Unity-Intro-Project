using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float duration = 5f;

    private Rigidbody rb;
    void Start()
    {
        Invoke("DestroySelf", duration);

        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    public void SetSpeed (float speed)
    {
        this.speed = speed;
    }
    public void SetDuration (float duration)
    {
        this.duration = duration;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
