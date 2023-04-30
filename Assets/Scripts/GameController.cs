using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    public List<GameObject> Customers;

    public GameObject s0;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject s7;
    public GameObject s8;

    public int CustomerNumber;

    public GameObject Map;
    public List<GameObject> Ways;

    public void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        GenerateNextCustomer();
    }


    public IEnumerator Start()
    {
        yield return new WaitForSeconds(1);

        //GenerateNextCustomer();
    }

    public void GenerateNextCustomer()
    {
        Customers[CustomerNumber].SetActive(true);

        if(CustomerNumber == 1)
        {
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(true);
            s4.SetActive(true);
        }

        if (CustomerNumber == 2)
        {
            s0.SetActive(false);
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(false);
            s5.SetActive(false);

            s3.SetActive(true);
            s6.SetActive(true);
            s8.SetActive(true);
            s7.SetActive(true);
        }
    }

    public void StartMap()
    {
        Map.SetActive(true);
        Ways[CustomerNumber].SetActive(true);
    }

}
