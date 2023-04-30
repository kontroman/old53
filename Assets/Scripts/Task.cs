using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public string ItemToUse;
    public Way ThisWay;
    public GameObject UseButton;


    public void Init()
    {
        if (!Player.Instance.PlayerItems.Contains(ItemToUse))
        {
            UseButton.GetComponent<Button>().interactable = false;
        }
    }

    public void UseItem()
    {
        if (Player.Instance.PlayerItems.Contains(ItemToUse))
        {
            Player.Instance.PlayerItems.Remove(ItemToUse);
            ThisWay.Stop = false;
            Destroy(gameObject);
        }
    }

    public void LoseLive()
    {
        Player.Instance.Lives -= 1;
        Player.Instance.UpdateLivesText();
        ThisWay.Stop = false;
        Destroy(gameObject);
    }
}
