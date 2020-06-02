using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up5 : MonoBehaviour
{
    public GameObject counter;
    public double cost;
    public Text text;
    public GameObject but;
    public void Update()
    {
        if (counter.GetComponent<Counter>().value >= 500)
        {
            but.SetActive(true);
        }
    }
public void OnPressedButt()
    {
        if (counter.GetComponent<Counter>().value >= cost)
        {
            counter.GetComponent<Counter>().value -= cost;
            counter.GetComponent<Counter>().currentValue += 5;
            cost += 50;
            text.GetComponent<Text>().text = "+5 валюты за нажатие. Цена: " + cost;
        }
    }
}
