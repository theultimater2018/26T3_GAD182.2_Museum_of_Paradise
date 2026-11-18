using UnityEngine;
using UnityEngine.InputSystem;

public class ArrowSize : MonoBehaviour
{

    public GameObject arrow;

    public float arrowTimer = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (arrowTimer > 0)
        {
            arrowTimer -= Time.deltaTime;
        }

        ArrowSizes();

        if (arrowTimer <= 0)
        {
            arrow.SetActive(false);
        }
    }

    public void ArrowSizes()
    {
        if (arrowTimer >= 4.5f)
        {
            arrow.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (arrowTimer <= 4)
        {
            arrow.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (arrowTimer <= 3.5f)
        {
            arrow.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (arrowTimer <= 3)
        {
            arrow.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (arrowTimer <= 2.5f)
        {
            arrow.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (arrowTimer <= 2)
        {
            arrow.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (arrowTimer <= 1.5f)
        {
            arrow.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (arrowTimer <= 1)
        {
            arrow.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        if (arrowTimer <= 0.5f)
        {
            arrow.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
