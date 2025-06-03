using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private string nextLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!string.IsNullOrEmpty(nextLevel))
            {
                SceneManager.LoadScene(nextLevel);
                return;
            }
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            int numberOfScenes = SceneManager.sceneCountInBuildSettings;

            if (nextSceneIndex >= numberOfScenes)
                {
                    SceneManager.LoadScene(0);
                }
                else
                {
                    SceneManager.LoadScene(nextSceneIndex);
                }
            
        }
    }
}
