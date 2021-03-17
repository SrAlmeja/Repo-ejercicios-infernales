using UnityEngine;

public class Vehículo
{
    private int weight, hight, surface, doorNumber, passengerNumber, cylinder, gas, maximumSpeed, numberOfSpeeds;
    private string color, carName;
    public float carSelector1, carSelector2;

    public Vehículo()
    {

    }

    public Vehículo(int aweight)
    {
        weight = aweight;
    }

    public Vehículo(string acolor, int aweight, int ahight, int asurface, int adoorNumber, int apassengerNumber, int acylinder, int agas, int amaximumSpeed, int anumberOfSpeed,
    string acarName)
    {
        color = acolor;
        weight = aweight;
        hight = ahight;
        surface = asurface;
        doorNumber = adoorNumber;
        passengerNumber = apassengerNumber;
        cylinder = acylinder;
        gas = agas;
        maximumSpeed = amaximumSpeed;
        numberOfSpeeds = anumberOfSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
