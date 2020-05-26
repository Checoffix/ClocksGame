using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockShop : MonoBehaviour
{
	public Text txt;
	public MainScreen Score;//Счет
	public Button Clock1;//Часы 1
	public Button Clock2;//Часы 2

	void Start() //Убрать интерактивнось всех кнопок
	{
		Clock1.interactable = false;
		Clock2.interactable = false;
	}
	void Update() //Проверка на значение счета, после которого кнопка становится активной
	{
		if (Score.score >= 10)
		{
			Clock1.interactable = true;
		}
		if (Score.score >= 50)
		{
			Clock2.interactable = true;
		}
	}
	public void ClickOnClock1()//При нажатии на Часы1
	{
		Score.bonus = 2;
		Score.score -= 10;
		txt.text = Score.score + "$";
		if(Clock1.interactable == true)
        {
			Clock1.interactable = false;
		}
	}
	public void ClickOnClock2()//При нажатии на Часы2
	{
		Score.bonus = 3;
		Score.score -= 50;
		txt.text = Score.score + "$";
		if (Clock2.interactable == true)
		{
			Clock2.interactable = false;
		}
	}
}
