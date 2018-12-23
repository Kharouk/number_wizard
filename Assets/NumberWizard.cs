using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Setting our variables:
    int max;
    int min;
    int guess;
    string title = "Magical Number Wizard";

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        // Resetting Our Variables:
        max = 1000;
        min = 1;
        guess = 500;

        // Encapsulating the code into a function, calling it after in our Start Method
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
            NextGuess("min");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            NextGuess("max");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (guess == 500)
            {
                Debug.Log("Really? Your number is going to be 500?");
                StartGame();
            } else
            {
                Debug.Log("Woohoo! A.I level achieved.");
                StartGame();
            }
        }
    }

    void NextGuess(string isMinOrMax)
    {
        if (isMinOrMax == "min")
        {
            min = guess;
            guess = ((max + min) / 2);
            Debug.Log($"Is the number {guess}? Press up for higher and down for lower or enter for yes!");
        }
        else if (isMinOrMax == "max")
        {
            max = guess;
            guess = ((max + min) / 2);
            Debug.Log($"Is the number {guess}? Press up for higher and down for lower or enter for yes!");
        }
    }
}
