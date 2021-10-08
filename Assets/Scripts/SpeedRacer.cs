using System;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    double maxAcceleration = 0.98;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        print("RaceCar is a " + carModel + ". It has a " + engineType + " engine.");

        CheckWeight();
        CheckCharacteristics();

        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade);
            CalculateAge(yearMade);
            int CalculateAge(int yearMade)
            {
                return 2021 - yearMade;

                int carAge = CalculateAge(yearMade);
                print("The car is " + carAge + "years old.");
            }
            
        }
        else
        {
            print("The car was introduced in the 2010s");
            print("The car's max acceleration is " + maxAcceleration);
        }

        string CheckCharacteristics()
        {
           
            if (isCarTypeSedan)
            {
                return "The car is a sedan type.";

            }
            else if (hasFrontEngine)
            {
                return "The car is not a sedan, but has a front engine.";

            }
            else
            {
                return "The car is neither a sedan, nor is its engine a front engine.";
            }
        }

    }

    
    
    
    void CheckWeight()
    {
        if (carWeight < 1500)
            print("The " + carModel + " weighs less than 1500kg.");
        else if (carWeight > 1500)
            print("The " + carModel + " weighs more than 1500kg.");


    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
