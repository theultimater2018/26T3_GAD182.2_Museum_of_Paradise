using UnityEngine;

public class Wall : MonoBehaviour
{

    public GameObject wall;

    public GameObject car;

    public Cars cars;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            Debug.Log("Car destroyed");
           // Destroy(car);
          // cars.DestroyCar();
        }
    }
}
