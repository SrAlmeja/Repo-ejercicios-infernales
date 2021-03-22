using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lakitu : MonoBehaviour
{
    public CarsInformation theCars = new CarsInformation(0, 0, 0, 0, 0, 0, "");
    private bool carNumber;

    [SerializeField] private GameObject ShowCarList;
    [SerializeField] private GameObject DeathBattle;

    public bool CarNumber { get { return carNumber; } set { carNumber = value; } }

    List<CarsInformation> carsList = new List<CarsInformation>();

    void Awake()
    {
        //colocar rango de seleccion de autos (1 --> 10)
        Debug.Log("Escoge uno de los siguientes 10 autos");
        Debug.Log("1), 2), 3), 4), 5), 6), 7), 8), 9), 10)");

        Debug.Log("Escoge el sigiente vehiculo");
        Debug.Log("1), 2), 3), 4), 5), 6), 7), 8), 9), 10)");
    }



}
