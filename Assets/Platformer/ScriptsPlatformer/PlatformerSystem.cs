using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlatformerSystem : MonoBehaviour
{
    [SerializeField] private Vector3 respawnLocation;
    [SerializeField] private GameObject player;

    public static UnityEvent OnPlayerKill = new();
    public static UnityEvent OnPlayerJump = new();
    public static UnityEvent OnPlayerMove = new();
    public static Action<bool> onGameStateChange;



    private void KillPlayer()
    {
        player.transform.position = respawnLocation;
        Debug.Log("Player Killed");
    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        respawnLocation = new Vector3(-8f, -1.3f, -1f);
        OnPlayerKill.AddListener(KillPlayer);
        onGameStateChange += GameState;
    }
    private void OnDisable()
    {
        OnPlayerKill.RemoveListener(KillPlayer);
        onGameStateChange -= GameState;
    }

    private void GameState(bool hasPlayerWon)
    {
        string loadedScene;

        if (hasPlayerWon == true)
        {
            loadedScene = "YouWinPlatformer";
        }
        else
        {
            loadedScene = "YouLosePlatformer";
        }
        SceneManager.LoadSceneAsync(loadedScene);
    }


}
