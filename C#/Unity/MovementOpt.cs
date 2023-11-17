using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MovementOpt : MonoBehavior
{
    // Night Setup
    public bool isNight = true; // used for the While(isNight) loop

    // Padding 
    public float timeUntilActive = 15; // Time until they start wandering.
    public float timeUntilOpt = 5; // Time between every movement Opt.

    // "AI" Levels
    public int ai_Char1 = 0;
    public int ai_Char2 = 0;
    public int ai_Char3 = 0;
    public int ai_Char4 = 0;

    void Start ()
    {
        Random random = new Random();
        System.Threading.Thread.Sleep(timeUntilActive * 1000);
        int movementCycles = 0;
        while (isNight == true)
        {
            System.Threading.Thread.Sleep(timeUntilOpt * 1000);
            int comparisonNumber = random.Next(1, 20);
            if (comparisonNumber < ai_Char1)
            {
                // Do whatever you want it to
            }
            comparisonNumber = random.Next(1, 20);
            if (comparisonNumber < ai_Char2)
            {
                // Do whatever you want it to
            }
            comparisonNumber = random.Next(1, 20);
            if (comparisonNumber < ai_Char3)
            {
                // Do whatever you want it to
            }
            comparisonNumber = random.Next(1, 20);
            if (comparisonNumber < ai_Char4)
            {
                // Do whatever you want it to
            }
            movementCycles + 1;
            if(movementCycles =< 72)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                isNight = false;
            }
        }
    }
}
