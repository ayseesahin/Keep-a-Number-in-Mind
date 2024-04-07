using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 100;
    int guess;
    bool gameStarted = false;
    bool gameFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Do you want to play games with me? (Y/N)");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            //........Start
            if (Input.GetKeyDown(KeyCode.Y))
            {
                print("Great! Keep a number between 1 and 100 in your mind and press Enter!");
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                print("You know best!");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Control();
                gameStarted = true;
            }
            //.........Start

        }
        else if(!gameFinished)
        {
            //.........Game
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minNumber = guess;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxNumber = guess;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Hooray, I found the trick you had in mind!");
                gameFinished = true;
            }
            //.......Game
        }

    }
    void Control()
    {
        guess = (minNumber + maxNumber) / 2;
        print("Is the number you keep in mind " + guess + "? If it is larger, press the up arrow key, if it is smaller, press the down arrow key! If correct, press the space bar!");

    }
}
