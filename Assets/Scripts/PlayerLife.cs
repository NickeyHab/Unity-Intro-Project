using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.collider.tag == "Projectile")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
