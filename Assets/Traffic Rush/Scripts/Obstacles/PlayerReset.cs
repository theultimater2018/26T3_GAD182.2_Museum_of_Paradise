using UnityEngine;

public class PlayerReset : MonoBehaviour
{

    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerResetPosition()
    {
        transform.position = player.position;
    }
}
