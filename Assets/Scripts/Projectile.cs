using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float duration = 5f;
    void Start()
    {
        Invoke("DestroySelf", duration);
    }

    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
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
}
