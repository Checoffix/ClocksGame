using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoFuckingBack : MonoBehaviour
{
    public GameObject counter;
    public void OnPressedBut()
    {
        GameObject.Find("Counter").GetComponent<Text>().text = "Ваш счёт: " + counter.GetComponent<Counter>().value;
    }
}
