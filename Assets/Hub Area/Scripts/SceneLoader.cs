using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string targetScene;

    private void OnTriggerEnter(Collider other)
    {
        LoadScene(targetScene);
    }

    private void LoadScene(string target)
    {
        SceneManager.LoadSceneAsync(target);
    }
}
