using Unity.VisualScripting;
using UnityEngine;

public class Lift : MonoBehaviour
{

    public GameObject lift;

    public Vector3 pointA = new Vector3(0, 0, 0);
    public Vector3 pointB = new Vector3(5, 0, 0);
    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
        Debug.Log("Lift is moving");
    
}
    

}
