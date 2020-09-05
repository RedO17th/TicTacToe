using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AI : MonoBehaviour
{
    private int countTails = 0;
    public int[] emptyArray;
    private List<int[]> listData = new List<int[]>();
    private List<int[]> listCurrentData = new List<int[]>();
    private bool isStep = false;
    private bool isFirstIteration = true;
    private int stepIndex = 0;
    [SerializeField]
    private GController gController;

    public void GetCountTails(int tails)
    {
        countTails = tails;
        InitEmpty();
        stepIndex = GetFirstDiagIndex(countTails);
    }
    private void InitEmpty()
    {
        emptyArray = null;
        int count = countTails * countTails;

        emptyArray = new int[count];
        for (int i = 0; i < count; i++)
            emptyArray[i] = 0;
    }
    public void SetTail(int number)
    {
        emptyArray[number] = 1;
    }
    public void GetList(List<int[]> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int[] arr = new int[list[i].Length];
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = list[i][j];
            }
            listData.Add(arr);
        }
        // 
    }
    private int GetFirstDiagIndex(int count)
    {
        List<int> diag = new List<int>();
        diag.Add(count - count);
        diag.Add(count - 1);
        diag.Add(diag[diag.Count - 1] * count);
        diag.Add(diag[diag.Count - 1] + --count);
        int i = diag[Random.Range(diag.Count - diag.Count, diag.Count - 1)];
        diag = null;
        return i;
    }
    public bool IsAI()
    {
        return isStep;
    }
    public void Step(bool step)
    {
        isStep = step;
    }
    private void Update()
    {
        if (isStep)
        {
            Debug.Log("Шаг ИИ");
            isStep = false; 
            if (isFirstIteration)
            {
                gController.SetSymbStep(stepIndex, true);
                FindListStep(stepIndex);
                isFirstIteration = false;
            }
            else
            {
                //


            }
            
            

        }
    }
    //На основе этого индекса ищем подходящие массивы - комбинации.
    private void FindListStep(int number)
    {
        for (int i = 0; i < listData.Count; i++)
        {
            //
            for (int j = 0; j < listData[i].Length - 1; j++)
            {
                if (listData[i][j] == number)
                {
                    int[] arr = new int[listData[i].Length - 1];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr[k] = listData[i][k];
                    }
                    listCurrentData.Add(arr);
                }
            }
        }
        //Debug.Log("Длинна " + listCurrentData.Count);
        //for (int i = 0; i < listCurrentData.Count; i++)
        //{
        //    for (int j = 0; j < listCurrentData[i].Length; j++)
        //    {
        //        Debug.Log("Значение из массива " + listCurrentData[i][j]);
        //    }
        //}
    }
    //Удаляем комбинацию с совпавшим индексом чужого хода
    public void AlienSteps(int value)
    {
        List<int> listDeleted = new List<int>();
        for (int i = 0; i < listCurrentData.Count; i++)
        {
            for (int j = 0; j < listCurrentData[i].Length; j++)
            {
                if (listCurrentData[i][j] == value)
                {
                    listDeleted.Add(i);
                    break;
                }
            }
        }
        //Удаление найденных комбинаций-----
        List<int[]> temp = new List<int[]>();
        for (int i = 0; i < listCurrentData.Count; i++)
        {
            if (!Match(listDeleted, i))
            {
                int[] arr = new int[listCurrentData[i].Length];
                for (int k = 0; k < arr.Length; k++)
                {
                    arr[k] = listCurrentData[i][k];
                }
                temp.Add(arr);
            }
        }
        listCurrentData = null;
        listCurrentData = temp;
    }
    private bool Match(List<int> lDeleted, int value)
    {
        for (int i = 0; i < lDeleted.Count; i++)
        {
            if (lDeleted[i] == value)
                return true;
        }
        return false;
    }


}
