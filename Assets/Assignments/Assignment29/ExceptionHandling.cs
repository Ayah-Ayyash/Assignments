using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExceptionHandling : MonoBehaviour
{

    int playerScore = 100;
    int diviser = 0;

    void Start()
    {
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;
        }
        catch (System.DivideByZeroException)
        {
            Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");

        }
    }

    void Update()
    {

    }
}
