using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsInformation : Vehículo
{
    private int doorNumber, personNumber, cylinderCapacity, gas, maximumSpeed, speedNumber;
    private string carName;

    public Vehículo theCars = new Vehículo("", 0, 0, 0);

    public CarsInformation(int adoorNumber, int apersonNumber, int acylinderCapacity, int agas, int amaximumSpeed, int aspeedNumber, string acarName)
    {
        doorNumber = adoorNumber;
        personNumber = apersonNumber;
        cylinderCapacity = acylinderCapacity;
        gas = agas;
        maximumSpeed = amaximumSpeed;
        speedNumber = aspeedNumber;
        carName = acarName;
    }

    public int DoornNumber { get { return doorNumber; } set { doorNumber = value; } }

    public int PersonNumber { get { return personNumber; } set { personNumber = value; } }

    public int CylinderCapacity { get { return cylinderCapacity; } set { cylinderCapacity = value; } }

    public int Gas { get { return gas; } set { gas = value; } }

    public int MaximumSpeed { get { return maximumSpeed; } set { maximumSpeed = value; } }

    public int SpeedNumber { get { return speedNumber; } set { speedNumber = value; } }

    public string CarName { get { return carName; } set { carName = value; } }

}
