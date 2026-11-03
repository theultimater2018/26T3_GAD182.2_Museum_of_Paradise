using Unity.VisualScripting;
using UnityEngine;

public class People : MonoBehaviour
{

    public GameObject people;

    public Vector3 pointA = new Vector3(0, 0, 0);
    public Vector3 pointB = new Vector3(5, 0, 0);
    public float speed = 1.0f;

    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);

        if (people != null)
        {
            spriteRenderer.flipX = pointA.x < pointB.x ? time < 0f : time >= 0f;
            spriteRenderer.flipX = true;
        }

        else if (people == null)
        {
            spriteRenderer.flipX = pointB.x < pointA.x ? time < 1f : time >= 1f;
            spriteRenderer.flipX = false;

        }

        if (people == null)
        {
            if (spriteRenderer.flipX = pointB.x < pointA.x)
            {
                spriteRenderer.flipX = true;
            }
        }

        if (people != null)
        {
            if (spriteRenderer.flipX = pointA.x < pointB.x)
            {
                spriteRenderer.flipX = false;
            }
        }
    }

}