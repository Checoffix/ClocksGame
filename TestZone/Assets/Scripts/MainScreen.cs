using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScreen : MonoBehaviour
{
	//public GameObject Settings;
	public GameObject Canvas;
	public GameObject Tup;
	public Text Counter;
	public int score = 0; //Общий счет
	public int bonus = 1; //Прибавляемый бонус
	void Start() //Все панели с магазами убираются
	{ 
	}
	private void Bonus(int BNS)//Получение нового значения бонуса из ClockShop
	{
		bonus = BNS;
	}
	public void OnMouseDown()//При нажатии на "Часы"
	{
		score += bonus;
		Counter.text = "Счет: " + score;
		if (Tup != null)
		{
			Destroy(Tup);
		}
	}
	void Update()
	{
		if (Tup == null)
        {
			Tup = Instantiate(Tup);
			Tup.transform.SetParent(Canvas.transform);
		}
	}
}