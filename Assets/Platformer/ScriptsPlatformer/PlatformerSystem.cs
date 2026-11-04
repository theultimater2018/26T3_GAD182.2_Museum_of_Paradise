using System;
using UnityEngine;
using UnityEngine.Events;

public class PlatformerSystem : MonoBehaviour
{
    [SerializeField] private Vector2 respawnLocation;
    [SerializeField] private GameObject player;

    public static UnityEvent OnPlayerKill = new();
    public static Action<Vector2> onCheckpointPass;

    private void KillPlayer()
    {
        player.transform.position = respawnLocation;
        Debug.Log("Player Killed");
    }

    private void SetNewCheckpoint(Vector2 newPosition)
    {
        respawnLocation = newPosition;
    }

    private void OnEnable()
    {
        respawnLocation = new Vector2(-29.4f, -1.3f);
        OnPlayerKill.AddListener(KillPlayer);
        onCheckpointPass += SetNewCheckpoint;
    }
    private void OnDisable()
    {
        OnPlayerKill.RemoveListener(KillPlayer);
        onCheckpointPass -= SetNewCheckpoint;
    }
}
