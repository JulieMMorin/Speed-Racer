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
        print("RaceCar is a GTR R35. It has a V6 Twin Turbo Engine.");

        CheckWeight();
        CalculateAge();
        


    }
    void CheckWeight()
    {
        if (carWeight < 1500)
            print("The string carModel weighs less than 1500kg.");
        else if (carWeight > 1500)
            print("The sting carModel weighs more than 1500kg.");


    }
    int CalculateAge(2021 - int yearMade)
    {


    }
    // Update is called once per frame
    void Update()
    {

    }
}
