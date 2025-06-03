using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Vector3 lastCheckpointPos = Vector3.zero;
    public static bool hasCheckpoint = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lastCheckpointPos = transform.position;
            hasCheckpoint = true;
        }
    }
}
