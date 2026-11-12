using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuTimer : MonoBehaviour
{

    public float menuTimer = 3f;

    public TMPro.TextMeshProUGUI timer1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (menuTimer > 0)
        {
            menuTimer -= Time.deltaTime;
        }
        else
        {
            menuTimer = 0;
        }

        DisplayTimer(menuTimer);

        if (menuTimer <= 0)
        {
            RunStarted();
        }

    }

    private void DisplayTimer(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Calculating Mintues //

        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Calculating Seconds //

        timer1.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }   // Displaying the Timer in Text Format by Minutes / Seconds / Minutes / Seconds //

    public void RunStarted()
    {
        if (menuTimer > 0)
        {
            menuTimer -= Time.deltaTime;
        }
        if (menuTimer <= 0)
        {
            SceneManager.LoadScene("Main Level");
        }
    }
}
