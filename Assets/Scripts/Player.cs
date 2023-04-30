using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public List<string> PlayerItems = new List<string>();
    public int Lives = 4;
    public int Reputation = 0;
    public int Money = 10;
    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI ReputationText;
    public TextMeshProUGUI LiveText;

    public GameObject WIN;
    public GameObject LOSE;

    public void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        UpdateMoneyText();
        UpdateReputation();
        UpdateLives();

        if(Lives <= 0)
        {
            LOSE.SetActive(true);
        }

        if(Reputation >= 3)
        {
            WIN.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UpdateLives()
    {
        LiveText.text = "" + Lives;
    }

    public void UpdateMoneyText()
    {
        MoneyText.text = "" + Money;
    }

    public void UpdateReputation()
    {
        ReputationText.text = "Reputation: " + Reputation + "/3";
    }

    public void UpdateLivesText()
    {

    }

}

