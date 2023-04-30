using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Way : MonoBehaviour
{
    public List<float> Stops;
    public List<GameObject> Tasks;
    public float Speed;
    public bool Stop = true;
    public int Passed;
    public Customer MyCustomer;

    public TextMeshProUGUI MoneyText;

    public GameObject EndWay;
    public GameObject Map;

    public Image path;

    public void Init()
    {
        Passed = 0;
        Stop = false;
    }

    public void Update()
    {
        if (!Stop)
        {
            path.fillAmount += Time.deltaTime * Speed;

            if(path.fillAmount == 1)
            {
                Stop = true;

                ShowEnd();
                return;
            }

            if(path.fillAmount >= Stops[Passed])
            {
                Stop = true;
                Tasks[Passed].SetActive(true);
                Tasks[Passed].GetComponent<Task>().Init();
                Passed++;
            }
        }

        MoneyText.text = "" + Player.Instance.Money;
    }

    public void ShowEnd()
    {
        EndWay.SetActive(true);
        Player.Instance.Money += 3;
    }

    public void GoBack()
    {
        Map.SetActive(false);
        MyCustomer.SetLastWord();
        Destroy(EndWay);
    }
}
