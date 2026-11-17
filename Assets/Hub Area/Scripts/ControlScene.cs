using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour
{
    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadScene(string target)
    {
        SceneManager.LoadSceneAsync(target);
    }

    public void ExitMinigame()
    {
        LoadScene("Main Hub");
    }
}
