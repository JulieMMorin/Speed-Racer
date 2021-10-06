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

        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade);
        }
        else
        {
            print("The car was introduced in " + yearMade);
        }
        //this is where I gave up on Wednesday. part 4a

        CalculateAge(yearMade);
        


    }

    

    void CheckWeight()
    {
        if (carWeight < 1500)
            print("The " + carModel + " weighs less than 1500kg.");
        else if (carWeight > 1500)
            print("The " + carModel + " weighs more than 1500kg.");


    }
    int CalculateAge(int number)
    {
        int result;
        result = 2021 - number;
        return result;

    }
    // Update is called once per frame
    void Update()
    {

    }
}
