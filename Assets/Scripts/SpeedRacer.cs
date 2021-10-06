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
        System.Console.WriteLine("RaceCar is a GTR R35. It has a V6 Twin Turbo Engine.");

        CheckWeight();
        void CheckWeight()
        { 
            if (carWeight < 1500)
                System.Console.WriteLine("The carModel weighs less than 1500kg.")
             else if (carWeight > 1500)
                System.Console.WriteLine("The carModel weighs more than 1500kg.")    
                    
                    }
            
     

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
