using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScreen : MonoBehaviour
{
	private GameObject Canvas;       //Основной канвас
	public GameObject Tup;          //Кнопка с часами
	private GameObject Counter;            //Счетчик
	public float score = 0;         //Общий счет
	public float bonus = 1;         //Прибавляемый бонус
	public float strength = 2;      //Прочность часов
	public float damage = 1;        //Урон
	public float bonuseIfCrash = 2; //Бонус при доламывании часов
	private GameObject FlyTextParent;
	public GameObject FlyTextPrefab;         //Родитель текстов и Префаб
	private int FlyNum;                                     //Величина массива
	private FlyScale[] FlyTextPool = new FlyScale[15];      //Массив вылетающих текстов
	void Start()
	{
		Canvas = GameObject.Find("MainCanvas");
		FlyTextParent = GameObject.Find("ParentOfFlyScale");
		Counter = GameObject.Find("Counter");
		for (int i = 0; i < FlyTextPool.Length; i++) //Заполнение массива Префабами вылетающего текста
		{
			FlyTextPool[i] = Instantiate(FlyTextPrefab, FlyTextParent.transform).GetComponent<FlyScale>();
		}
	}
	private void Accept(float STG, float DMG, float BNS)//Получение новых значений из др Скриптов
	{
		strength = STG;
		damage = DMG;
		bonus = BNS;
	}
	public void OnMouseDown()//При нажатии на "Часы"
	{

		strength -= damage; //Снятие ХП
		if (strength > 0)   //Проверка на то последний это удар или нет
		{//Если не последний:
			score += bonus;                         //+бонус
			Counter.GetComponent<Text>().text = "Счёт: " + score;
			FlyTextPool[FlyNum].StartMotion(bonus); //Добавление в окно вылетающего текста цифры
			if (FlyNum == FlyTextPool.Length - 1)   //Танцы с правильным заполнением массива
			{
				FlyNum = 0;
			}
			else
				FlyNum++;
		}
		else
		{//Если последний:
			strength = 2;
			score += bonuseIfCrash;
			Counter.GetComponent<Text>().text = "Счёт: " + score;
			FlyTextPool[FlyNum].StartMotion(bonuseIfCrash);
			if (FlyNum == FlyTextPool.Length - 1)
			{
				FlyNum = 0;
			}
			else
				FlyNum++;
			Destroy(gameObject, 0.01f);
			Instantiate(Tup, Canvas.transform);
		}
	}
}