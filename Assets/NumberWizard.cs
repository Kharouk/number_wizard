using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Setting our variables:
    int max = 1000;
    int min = 1;
    int guess = 500;
    string title = "Magical Number Wizard";

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log($"Welcome to the {title}!");
        Debug.Log($"Please pick a number between {min} and {max}");
        Debug.Log($"To play the game, you must: Push Up = higher, Push Down = lower, Enter = Correct");
        Debug.Log($"Is your number higher or lower than {guess}?");
        // Fixing the bug that max doesn't reach 999:
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = ((max + min) / 2);
            Debug.Log($"Is the number {guess}? Press up for higher and down for lower or enter for yes!");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = ((max + min) / 2);
            Debug.Log($"Is the number {guess}? Press up for higher and down for lower or enter for yes!");

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed.");
        }
    }
}
