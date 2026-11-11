using UnityEngine;
using UnityEngine.InputSystem;

public class LoadingStart : MonoBehaviour
{

    public GameObject loadingScreen;

    public GameObject controlScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        loadingScreen.SetActive(false);
        controlScene.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        loadingScreen.SetActive(true);
        controlScene.SetActive(false);
    }
}
