using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int delay;

    public void Start()
    {
        Destroy(gameObject, delay);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Destroy(gameObject);
    }

    public void OnDestroy()
    {
        GameController.Instance.StartGame();
    }

}
