using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScreen : MonoBehaviour
{
	//public GameObject Settings;
	public GameObject Canvas;
	public GameObject ClockSH; //Магаз Часов
	public GameObject DestroySH; //Магаз Предметов
	public GameObject BonuseSH;//Магаз Бонусов
	public GameObject Tup;
	public Text Counter;
	public int score = 0; //Общий счет
	public int bonus = 1; //Прибавляемый бонус
	void Start() //Все панели с магазами убираются
	{
		ClockSH.SetActive(false);
		DestroySH.SetActive(false);
		BonuseSH.SetActive(false);
		//	Settings.SetActive(false);
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
	/*public void ClickOnSettings()
    {
		Settings.SetActive(true);
    }*/
	public void ClickOnClockShop() //При клике на Магаз часов
	{
		ClockSH.SetActive(!ClockSH.activeSelf);
		DestroySH.SetActive(false);
		BonuseSH.SetActive(false);
	}
	public void ClickOnDestroyShop() //При клике на магаз Предметов
	{
		DestroySH.SetActive(!DestroySH.activeSelf);
		BonuseSH.SetActive(false);
		ClockSH.SetActive(false);
	}
	public void ClickOnBonusShop() //При клике на магаз Бонусов
	{
		BonuseSH.SetActive(!BonuseSH.activeSelf);
		ClockSH.SetActive(false);
		DestroySH.SetActive(false);
	}
}