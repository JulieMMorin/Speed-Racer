using System;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public string carMaker;
    public int carWeight = 1609;
    public int yearMade = 2009;
    public double maxAcceleration = 0.98;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;


    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }
    public Fuel carFuel = new Fuel(100);



    // Start is called before the first frame update
    void Start()
    {
        print("RaceCar is a " + carModel + ". It is made by " + carMaker + " It has a " + engineType + " engine.");
        print(CheckCharacteristics());
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two - thirds.");
                break;
            case 50:
                print("Fuel level is at half amount.");
                break;
            case 10:
                print("WARNING! Fuel level is critically low.");
                break;
            default:
                print("There is nothing to report.");
                break;



        }



    }

    
        
    
}
