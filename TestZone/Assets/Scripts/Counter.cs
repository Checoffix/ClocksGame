using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public double value = 0;
    public double currentValue;
    public void OnPressedClocks()
    {
        value += currentValue;
        GameObject.Find("Counter").GetComponent<Text>().text = "Ваш счёт: " + value;
    }
}
