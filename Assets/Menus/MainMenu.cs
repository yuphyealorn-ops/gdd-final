using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f; // make sure nothing is still paused
    }

    public void PlayMadDriver()    { SceneManager.LoadScene("Prototype 1"); }
    public void PlayFlyLikeABird() { SceneManager.LoadScene("Challenge 1"); }
    public void PlaySumo()         { SceneManager.LoadScene("Prototype 4"); }

    public void ExitGame()
    {
        Debug.Log("Exit pressed");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // so Exit visibly works in the Editor
#endif
    }
}
