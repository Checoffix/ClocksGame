using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScreen : MonoBehaviour
{
<<<<<<< HEAD
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
=======
	#region Все переменые
	public GameObject Canvas;		//Основной канвас
	public GameObject Tup;			//Кнопка с часами
	public Text Counter;			//Счетчик
	public float score = 0;			//Общий счет
	public float bonus = 1;			//Прибавляемый бонус
	public float strength = 2;		//Прочность часов
	public float damage = 1;		//Урон
	public float bonuseIfCrash = 2; //Бонус при доламывании часов
	public GameObject FlyTextParent, FlyTextPrefab;         //Родитель текстов и Префаб
	private int FlyNum;										//Величина массива
	private FlyScale[] FlyTextPool = new FlyScale[30];      //Массив вылетающих текстов
	#endregion
	void Start()
	{
        #region Загрузки данных
        score = PlayerPrefs.GetFloat("Score+", score);  //Загружает счет
		bonus = PlayerPrefs.GetFloat("Bonuse+", bonus); //Загружает бонус
		strength = PlayerPrefs.GetFloat("Strength+", strength); //Загружает прочность
		damage = PlayerPrefs.GetFloat("Damage+", damage); //Загружает урон
		bonuseIfCrash = PlayerPrefs.GetFloat("BonuseIfCrash+", bonuseIfCrash); //Загружает урон при доламывании
        #endregion
        Counter.text = "Счет: " + score;				//Просто чтобы текст вывелся сразу, а не после клика
		for (int i = 0; i < FlyTextPool.Length; i++)	//Заполнение массива Префабами вылетающего текста
>>>>>>> 44089facdf165d5766a2b569e18bde04ceab03c9
		{
			FlyTextPool[i] = Instantiate(FlyTextPrefab, FlyTextParent.transform).GetComponent<FlyScale>();
		}
	}
<<<<<<< HEAD
	private void Accept(float STG, float DMG, float BNS)//Получение новых значений из др Скриптов
=======
	void Update()
    {
		Counter.text = "Счет: " + score;
		#region Сохранение Данных
		PlayerPrefs.SetFloat("Score+", score); //Сохраняет счет
		PlayerPrefs.SetFloat("Bonuse+", bonus); //Сохраняет бонус
		PlayerPrefs.SetFloat("Strength+", strength); //Сохраняет прочность
		PlayerPrefs.SetFloat("Damage+", damage); //Сохраняет урон
		PlayerPrefs.SetFloat("BonuseIfCrash+", bonuseIfCrash); //Сохраняет урон при доламывании
		#endregion

	}
	private void Accept(int STG, float DMG, float BNS)//Получение новых значений из др Скриптов
>>>>>>> 44089facdf165d5766a2b569e18bde04ceab03c9
	{
		strength = STG;
		damage = DMG;
		bonus = BNS;
	}
	public void OnMouseDown()//При нажатии на "Часы"
	{
<<<<<<< HEAD

=======
>>>>>>> 44089facdf165d5766a2b569e18bde04ceab03c9
		strength -= damage; //Снятие ХП
		if (strength > 0)   //Проверка на то последний это удар или нет
		{//Если не последний:
			score += bonus;                         //+бонус
<<<<<<< HEAD
			Counter.GetComponent<Text>().text = "Счёт: " + score;
=======
>>>>>>> 44089facdf165d5766a2b569e18bde04ceab03c9
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
<<<<<<< HEAD
			Counter.GetComponent<Text>().text = "Счёт: " + score;
			FlyTextPool[FlyNum].StartMotion(bonuseIfCrash);
			if (FlyNum == FlyTextPool.Length - 1)
			{
=======
			FlyTextPool[FlyNum].StartMotion(bonuseIfCrash);
			if (FlyNum == FlyTextPool.Length - 1)
			{ 
>>>>>>> 44089facdf165d5766a2b569e18bde04ceab03c9
				FlyNum = 0;
			}
			else
				FlyNum++;
			Destroy(gameObject, 0.01f);
			Instantiate(Tup, Canvas.transform);
		}
<<<<<<< HEAD
	}
=======
		//Instantiate(Tup);								Жалкая попытка создания объекта (не работает)
		//Tup.transform.SetParent(Canvas.transform);     
		//Destroy(this.gameObject);
	}
	/*void Update()										Ещё одна попытка (тоже блять не работает)
	{
		if (this.gameObject == null)
		{
			Instantiate(Tup);
			Tup.transform.SetParent(Canvas.transform);		
		}
	}*/
>>>>>>> 44089facdf165d5766a2b569e18bde04ceab03c9
}