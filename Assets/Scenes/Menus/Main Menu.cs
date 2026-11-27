using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main Hub");
    }

    public void ExitGame()
    {
        //Before compiling, uncomment Application.Quit() and remove the next line.
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}