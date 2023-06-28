using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar;
    private string nextSceneName;

    public void LoadNextScene(string sceneName)
    {
        nextSceneName = sceneName;
        StartCoroutine(LoadSceneAsynchronously(nextSceneName));
    }

    IEnumerator LoadSceneAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            loadingBar.value = operation.progress;
            yield return new WaitForSeconds(2.1f); // Adjust the delay time here
        }
    }
}
