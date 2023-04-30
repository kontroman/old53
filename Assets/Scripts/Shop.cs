using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop Instance { get; private set; }

    public GameObject Shop2;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowShop()
    {
        Shop2.SetActive(!Shop2.activeSelf);
    }

    public void BuyItem(Item item)
    {
        if(item.Price <= Player.Instance.Money)
        {
            Player.Instance.PlayerItems.Add(item.Name);
            Player.Instance.Money -= item.Price;
            Player.Instance.UpdateMoneyText();
        }
    }
}
