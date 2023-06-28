using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneButton : MonoBehaviour
{
    public string nextSceneName;

    private void Start()
    {
        // Add a Button component to your GameObject and assign this script to it
        // Set the onClick event to call the LoadNextScene method
        // Alternatively, you can use Input.GetKeyDown or other input methods to trigger the scene load
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
