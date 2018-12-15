using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Setting our variables:
        int max = 1000;
        int min = 1;
        string title = "Magical Number Wizard";

        Debug.Log($"Welcome to the {title}!");
        Debug.Log($"Please pick a number between {min} and {max}");
        Debug.Log($"Is your number higher or lower than {max/2}?");
        Debug.Log("Push Up = higher, Push Down = lower, Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed.");
        }
    }
}
