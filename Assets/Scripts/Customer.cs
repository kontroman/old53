using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Threading;
using DG.Tweening;

public class Customer : MonoBehaviour
{
    public GameObject Text;

    public Vector2 Position;

    public string ItemBack;

    public GameObject LastWord;

    public Button UseButton;
    public Button BackButton;

    public void ShowText()
    {
        Text.SetActive(true);

        GetComponent<AudioSource>().Play();
    }

    public void Start()
    {
        StartCoroutine(MoveToStart());
    }

    public IEnumerator MoveToStart()
    {
        transform.DOLocalMove(Position, 3f);

        yield return new WaitForSeconds(3);

        ShowText();
    }

    public void SetLastWord()
    {
        Text.SetActive(false);
        LastWord.SetActive(true);

        if (!Player.Instance.PlayerItems.Contains(ItemBack))
            UseButton.interactable = false;

        GetComponent<AudioSource>().Play();
    }

    public void Use()
    {
        Player.Instance.Reputation += 1;
        Player.Instance.Money += 3;

        Player.Instance.UpdateMoneyText();
        Player.Instance.UpdateReputation();

       StartCoroutine( Back());
    }

    public void Lose()
    {
        StartCoroutine(Back());
    }

    public IEnumerator Back()
    {
        LastWord.SetActive(false);

        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);

        transform.DOLocalMove(new Vector3(-1166f, -296.5f), 3f);

        yield return new WaitForSeconds(3);

        GameController.Instance.CustomerNumber++;
        GameController.Instance.GenerateNextCustomer();
    }
}
