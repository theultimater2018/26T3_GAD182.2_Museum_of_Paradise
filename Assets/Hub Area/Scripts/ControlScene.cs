using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour
{
    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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
