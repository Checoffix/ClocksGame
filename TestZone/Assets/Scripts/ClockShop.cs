using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockShop : MonoBehaviour
{
	public MainScreen Score;//Счет
	public Button Clock1;//Часы 1
	public Button Clock2;//Часы 2

	void Start() //Убрать интерактивнось всех кнопок (пока не трогай, позже решим делать их неактивными или убрать вовсе на старте)
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
	public void ClickOnClock1()//При покупке Часов1
	{
		Score.bonuseIfCrash = 4;		//+ к бонусу при доламывании
		Score.strength = 2;				//+ к прочности
		Score.bonus = 2;				//+ к бонусу
		Score.score -= 10;				//Списание со счета
		if (Clock1.interactable == true)//Включение интерактивности
		{
			Clock1.interactable = false;
		}
	}
	public void ClickOnClock2()//При покупке Часов2
	{
		Score.bonuseIfCrash = 6;
		Score.strength = 3;
		Score.bonus = 3;
		Score.score -= 50;
		if (Clock2.interactable == true)
		{
			Clock2.interactable = false;
		}
	}
}