using NUnit.Framework;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Projectile")
        {
            Destroy(other.gameObject);

            if (Checkpoint.hasCheckpoint)
            {
                transform.position = Checkpoint.lastCheckpointPos;
                rb.linearVelocity = Vector3.zero;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
    }
}
