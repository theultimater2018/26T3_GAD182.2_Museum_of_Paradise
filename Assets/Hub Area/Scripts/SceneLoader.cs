using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Scene targetScene;

    private void OnTriggerEnter(Collider other)
    {
        // UnloadScene();
    }

    private void UnloadScene(Scene target)
    {
        SceneManager.UnloadSceneAsync(target);
    }
}
