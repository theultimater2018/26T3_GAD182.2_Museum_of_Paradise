using UnityEngine;

public class CarChangeDirection : MonoBehaviour
{

    public GameObject car1;
    public GameObject car2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        car1.SetActive(true);
        car2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void ChangeCarDirection()
    {
        car1.SetActive(false);
        car2.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            ChangeCarDirection();
            Debug.Log("Car changed direction");
        }

        Debug.Log("Car changed direction");
    }
}
