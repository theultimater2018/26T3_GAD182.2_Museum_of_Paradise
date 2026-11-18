using System;
using UnityEngine;
using UnityEngine.Events;

public class PlatformerSystem : MonoBehaviour
{
    [SerializeField] private Vector3 respawnLocation;
    [SerializeField] private GameObject player;

    public static UnityEvent OnPlayerKill = new();
    public static Action<Vector3> onCheckpointPass;

    private void KillPlayer()
    {
        player.transform.position = respawnLocation;
        Debug.Log("Player Killed");
    }

    private void OnEnable()
    {
        respawnLocation = new Vector3(-8f, -1.3f, -1f);
        OnPlayerKill.AddListener(KillPlayer);
        KillPlayer();
    }
    private void OnDisable()
    {
        OnPlayerKill.RemoveListener(KillPlayer);
    }
}
