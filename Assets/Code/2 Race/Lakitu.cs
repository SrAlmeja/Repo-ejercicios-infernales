using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lakitu : MonoBehaviour
{
    System.Random selection = new System.Random();

    List<CarsInformation> listOfCars = new List<CarsInformation>();

    CarsInformation carOne = new CarsInformation(2, 4, 4, 40, 150, 5, "Vocho");
    CarsInformation carTwo = new CarsInformation(5, 5, 4, 45, 175, 5, "Aveo");
    CarsInformation carThree = new CarsInformation(2, 2, 3, 130, 140, 5, "Capuchino");
    CarsInformation carFour = new CarsInformation(5, 5, 4, 60, 180, 4, "Chariot");
    CarsInformation carFive = new CarsInformation(4, 5, 4, 50, 186, 5, "Spectre");
    CarsInformation carSix = new CarsInformation(4, 5, 4, 50, 190, 5, "Solaris");
    CarsInformation carSeven = new CarsInformation(2, 2,10, 70, 306, 6, "Viper");
    CarsInformation carEight = new CarsInformation(4, 5, 4, 64, 127, 6, "avalón");
    CarsInformation carNine = new CarsInformation(3, 4, 4, 57, 130, 5, "Fuego Turbo");
    CarsInformation carTen = new CarsInformation(2, 2, 4, 50, 130, 5, "Audi TT RS Roadster");
    public int winner = 0;
    private void Awake()
    {
        listOfCars.Add(carOne);
        listOfCars.Add(carTwo);
        listOfCars.Add(carThree);
        listOfCars.Add(carFour);
        listOfCars.Add(carFive);
        listOfCars.Add(carFive);
        listOfCars.Add(carSeven);
        listOfCars.Add(carEight);
        listOfCars.Add(carNine);
        listOfCars.Add(carTen);
    }
    
    public void ChooseCar()
    {
        int randomOne = selection.Next(1, listOfCars.Count);
        int randomTwo = selection.Next(1, listOfCars.Count);
        Debug.Log(randomOne);
        Debug.Log(randomTwo);
        theRice(randomOne, randomTwo);
    }

    public void theRice(int index1, int index2)
    {

        int lineOfGoal = 200;
        float carDistanceA;
        float carDistanceB;
        float timeA;
        float timeB;
        float fight;

        CarsInformation fisrtPlaza = listOfCars[index1];
        CarsInformation secondPlaza = listOfCars[index2];

        Debug.Log("pee, pee, pee, ¡Start!");
        Debug.Log(listOfCars[index1].Information(fisrtPlaza));
        Debug.Log(listOfCars[index2].Information(secondPlaza));

        carDistanceA = listOfCars[index1].MaximumSpeed / 3.6f;
        carDistanceB = listOfCars[index2].MaximumSpeed / 3.6f;

        timeA = carDistanceA / lineOfGoal;
        timeB = carDistanceB / lineOfGoal;

        Debug.Log("Primer vehículo = " + timeA + " segundos " + "segundo vehiculo =" + timeB + " segundos");

        if (timeA < timeB)
        {
            fight = timeA - timeB;
            Debug.Log("El segundo vehículo gano por = " + fight + " segundos");
        }
        if (timeA > timeB)
        {
            Debug.Log("Lo lamento pero fuiste lento vehiculo 2");
            winner = 1;
        }
        if (timeB < timeA)
        {
            fight = timeB - timeA;
            Debug.Log("El primer vehículo gano por = " + fight + " segundos");
        }
        if (timeB > timeA)
        {
            Debug.Log("Parece que ya no eres el numero uno .-.");
        }
        if (timeA == timeB)
        {
            Debug.Log("los dos son igual de mancos, ninguno gana");
        }

    }
    public void ShowCars()
    {
        Debug.Log("vehículo 1 = " + carOne.Information(carOne));
        Debug.Log("Vehículo 2 = " + carTwo.Information(carTwo));
        Debug.Log("Vehículo 3 = " + carThree.Information(carThree));
        Debug.Log("Vehículo 4 = " + carFour.Information(carFour));
        Debug.Log("Vehículo 5 = " + carFive.Information(carFive));
        Debug.Log("Vehículo 6 = " + carSix.Information(carSix));
        Debug.Log("Vehículo 7 = " + carSeven.Information(carSeven));
        Debug.Log("Vehículo 8 = " + carEight.Information(carEight));
        Debug.Log("Vehículo 9 = " + carNine.Information(carNine));
        Debug.Log("Vehículo 10 = " + carTen.Information(carTen));

        Debug.Log(listOfCars.Count);
    }


}
