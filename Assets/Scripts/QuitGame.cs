using Unity.VisualScripting;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("escape")) {
            Application.Quit();
            Debug.Log("Quit Game");
        }
    }
}
