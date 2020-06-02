using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up2 : MonoBehaviour 
{
    public GameObject counter;
    public double cost;
    public Text text;
    public GameObject but;
    public void Update()
    {
        if(counter.GetComponent<Counter>().value >= 10)
        {
            but.SetActive(true);
        }
    }
    public void OnPressedButt()
    {
        if (counter.GetComponent<Counter>().value >= cost)
        {
            counter.GetComponent<Counter>().value -= cost;
            counter.GetComponent<Counter>().currentValue += 2;
            cost += 14;
            text.GetComponent<Text>().text = "+2 валюты за нажатие. Цена: " + cost;
        }
    }
}
