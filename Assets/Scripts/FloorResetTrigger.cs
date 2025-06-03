using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorResetTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Checkpoint.hasCheckpoint)
            {
                other.transform.position = Checkpoint.lastCheckpointPos;
                Rigidbody rb = other.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.linearVelocity = Vector3.zero;
                }
            }
            else
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);
            }
        }
    }
}
