using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScreen : MonoBehaviour
{
	public GameObject Canvas;       //Основной канвас
	public GameObject Tup;          //Кнопка с часами
	public Text Counter;            //Счетчик
	public float score = 0;         //Общий счет
	public float bonus = 1;         //Прибавляемый бонус
	public float strength = 2;      //Прочность часов
	public float damage = 1;        //Урон
	public float bonuseIfCrash = 2; //Бонус при доламывании часов
	public GameObject FlyTextParent, FlyTextPrefab;         //Родитель текстов и Префаб
	private int FlyNum;                                     //Величина массива
	private FlyScale[] FlyTextPool = new FlyScale[15];      //Массив вылетающих текстов
	void Start()
	{
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
			Counter.text = "Счет: " + score;
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
			score += bonuseIfCrash;
			Counter.text = "Счет: " + score;
			FlyTextPool[FlyNum].StartMotion(bonuseIfCrash);
			if (FlyNum == FlyTextPool.Length - 1)
			{
				FlyNum = 0;
			}
			else
				FlyNum++;
			Destroy(this.gameObject);
			Instantiate(Tup);
			Tup.transform.SetParent(Canvas.transform);
		}
	}
}