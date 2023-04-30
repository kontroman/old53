using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public int Price;
    
    public void Buy()
    {
        Shop.Instance.BuyItem(this);
    }
}
