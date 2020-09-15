using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GController : MonoBehaviour
{
    private string symbolX = "X";
    private string symbolO = "O";
    private bool step = false;
    private bool isEnd = false;
    private SpawnerTile sTile;
    private DataThree dataThree;
    private DataFive dataFive;
    private List<int[]> dataListFPlayer = new List<int[]>();
    private List<int[]> dataListSPlayer = new List<int[]>();
    private int countTiles;
    private const int tailThree = 3;
    private const int tailFive = 5;

    [SerializeField]
    private AI computer;
    public bool isAIandP = false;
    public bool aiIsFirst = false;
    //public bool isAI = false;

    [SerializeField] private Text txtScore;

    private void Awake()
    {
        sTile = GetComponent<SpawnerTile>();
        
    }
    private void InitData()
    {
        step = false;
        if (countTiles == tailThree)
        {
            dataThree = GetComponent<DataThree>();
            dataThree.ClearLists();
            if (dataThree != null)
            {
                if (isAIandP)
                {
                    if (aiIsFirst)
                    {
                        dataListFPlayer = dataThree.Copy(step);
                        computer.GetList(dataListFPlayer);
                        dataListSPlayer = dataThree.Copy();
                    }
                    else
                    {
                        dataListFPlayer = dataThree.Copy(step);
                        dataListSPlayer = dataThree.Copy();
                        computer.GetList(dataListSPlayer);
                        
                    }
                }
                else
                {
                    dataListFPlayer = dataThree.Copy(step);
                    dataListSPlayer = dataThree.Copy();
                }

            }
            else
                Debug.Log(dataThree);
        }
        else if (countTiles == tailFive)
        {
            dataFive = GetComponent<DataFive>();
            dataFive.ClearLists();
            if (dataFive != null)
            {
                if (isAIandP)
                {
                    if (aiIsFirst)
                    {
                        dataListFPlayer = dataFive.Copy(step);
                        computer.GetList(dataFive.Copy(step));
                        dataListSPlayer = dataFive.Copy();
                    }
                    else
                    {
                        dataListFPlayer = dataFive.Copy(step);
                        computer.GetList(dataFive.Copy());
                        dataListSPlayer = dataFive.Copy();
                    }
                }
                else
                {
                    dataListFPlayer = dataFive.Copy(step);
                    dataListSPlayer = dataFive.Copy();
                }
            }
            else
                Debug.Log(dataFive);
        }
        else
        {
            Debug.Log("Number of Tails not found. GC.");
        }
    }
    //Получаем сивол и проверяем на выигрыш 
    public string SetSymbStep(int numberOfTile)
    {
        step = !step;
        if (step)
        {
            CheckList(numberOfTile, dataListFPlayer);
            return symbolX;
        }
        else
        {
            CheckList(numberOfTile, dataListSPlayer);
            return symbolO;
        } 
    }
    public void SetSymbStep(int numberOfTile, bool aIsFirst)
    {
        step = !step;
        if (step)
        {
            CheckList(numberOfTile, dataListFPlayer);
            sTile.OffButton(numberOfTile, symbolX);
            Debug.Log("ИИ запустил ход на плитку " + numberOfTile);
        }
        else
        {
            CheckList(numberOfTile, dataListSPlayer);
            //Нажатие произойдет от игрока на самой кнопке и перейдет сюда
            sTile.OffButton(numberOfTile, symbolO);

            //Debug.Log("Игрок и индекс: " + numberOfTile);

            //И после того, как игрок сходил, запускать ИИ на расчеты-------------------
            //Нижний метод возможно и не нужен
            computer.SetTail(numberOfTile);
            computer.AlienSteps(numberOfTile);
            //computer.Step(true);
        }
    }
    private void CheckList(int number, List<int[]> dataList)
    {
        for (int ind = 0; ind < dataList.Count; ind++)
        {
            int[] arr = dataList[ind];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == number)
                {
                    arr[arr.Length - 1]++;
                    //break;
                }
            }
            dataList[ind] = arr;
            if (arr[arr.Length - 1] == arr.Length - 1)
            {
                //-------------------------------------------------------------------------------
                Debug.Log("Выйигрыш у " + step);

                txtScore.gameObject.SetActive(true);
                if (step)
                    txtScore.text = "Выигрыш у Крестиков";
                else
                    txtScore.text = "Выигрыш у Ноликов";
                //foreach (int i in arr)
                //    Debug.Log(i);
                sTile.StopGame();
                break;
            }
        }
    }
    public void GetCountTail(int tails)
    {
        countTiles = tails;
        InitData();
        sTile.Spawn(countTiles);

        //Запускаем ИИ
        if (isAIandP)
        {
            computer.GetCountTails(countTiles);
            computer.Step(true);
            sTile.ToPlayWithAI();
        }

    }
    public void QuitApplication()
    {
        Application.Quit();
    }

    //private void Temp(int[] arr, int number)
    //{
    //    for (int i = 0; i < arr.Length - 1; i++)
    //    {
    //        if (arr[i] == number)
    //        {
    //            arr[arr.Length - 1]++;
    //            //break;
    //        }
    //    }
    //    if (arr[arr.Length - 1] == arr.Length - 1)
    //    {
    //        Debug.Log("Выйигрыш у " + step);
    //        sTile.StopGame();
    //    }
    //}
    public void UnActiveScore()
    {
        txtScore.gameObject.SetActive(false);
    }

}
