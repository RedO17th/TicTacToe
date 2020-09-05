using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New Game Data", menuName = "Game Data", order = 51)]
public class DataThree : MonoBehaviour
{
    //Необходим двойной набор одинаковых матриц. Чтобы не затирать поля с баллами друг у друга.
    //FP----------------------------------------------------------
    private int[] arrayFO = new int[] { 0, 1, 2, 0 };
    private int[] arrayFT = new int[] { 2, 1, 0, 0 };
    private int[] arrayFTh = new int[] { 0, 3, 6, 0 };
    private int[] arrayFFour = new int[] { 6, 3, 0, 0 };
    private int[] arrayFFife = new int[] { 2, 5, 8, 0 };
    private int[] arrayFSix = new int[] { 8, 5, 2, 0 };
    private int[] arrayFSeven = new int[] { 6, 7, 8, 0 };
    private int[] arrayFEight = new int[] { 8, 7, 6, 0 };
    private int[] arrayFNn = new int[] { 5, 4, 3, 0 };
    private int[] arrayFTn = new int[] { 3, 4, 5, 0 };
    private int[] arrayFElvn = new int[] { 1, 4, 7, 0 };
    private int[] arrayFTwlv = new int[] { 7, 4, 1, 0 };
    //D:
    private int[] arrayFDOne = new int[] { 0, 4, 8, 0 };
    private int[] arrayFDTwo = new int[] { 8, 4, 0, 0 };
    private int[] arrayFDThree = new int[] { 2, 4, 6, 0 };
    private int[] arrayFDFour = new int[] { 6, 4, 2, 0 };
    //SP----------------------------------------------------------
    private int[] arraySO = new int[] { 0, 1, 2, 0 };
    private int[] arrayST = new int[] { 2, 1, 0, 0 };
    private int[] arraySTh = new int[] { 0, 3, 6, 0 };
    private int[] arraySFour = new int[] { 6, 3, 0, 0 };
    private int[] arraySFife = new int[] { 2, 5, 8, 0 };
    private int[] arraySSix = new int[] { 8, 5, 2, 0 };
    private int[] arraySSeven = new int[] { 6, 7, 8, 0 };
    private int[] arraySEight = new int[] { 8, 7, 6, 0 };
    private int[] arraySNn = new int[] { 5, 4, 3, 0 };
    private int[] arraySTn = new int[] { 3, 4, 5, 0 };
    private int[] arraySElvn = new int[] { 1, 4, 7, 0 };
    private int[] arraySTwlv = new int[] { 7, 4, 1, 0 };
    //D:
    private int[] arraySDOne = new int[] { 0, 4, 8, 0 };
    private int[] arraySDTwo = new int[] { 8, 4, 0, 0 };
    private int[] arraySDThree = new int[] { 2, 4, 6, 0 };
    private int[] arraySDFour = new int[] { 6, 4, 2, 0 };

    private List<int[]> listFirst = new List<int[]>();
    private List<int[]> listSecond = new List<int[]>();

    private void Awake()
    {
        CopyOne();
        CopyTwo();
    }
    private void CopyOne()
    {
        listFirst.Add(arrayFO);
        listFirst.Add(arrayFT);
        listFirst.Add(arrayFTh);
        listFirst.Add(arrayFFour);
        listFirst.Add(arrayFFife);
        listFirst.Add(arrayFSix);
        listFirst.Add(arrayFSeven);
        listFirst.Add(arrayFEight);
        listFirst.Add(arrayFNn);
        listFirst.Add(arrayFTn);
        listFirst.Add(arrayFElvn);
        listFirst.Add(arrayFTwlv);
        listFirst.Add(arrayFDOne);
        listFirst.Add(arrayFDTwo);
        listFirst.Add(arrayFDThree);
        listFirst.Add(arrayFDFour);
    }
    private void CopyTwo()
    {
        listSecond.Add(arraySO);
        listSecond.Add(arrayST);
        listSecond.Add(arraySTh);
        listSecond.Add(arraySFour);
        listSecond.Add(arraySFife);
        listSecond.Add(arraySSix);
        listSecond.Add(arraySSeven);
        listSecond.Add(arraySEight);
        listSecond.Add(arraySNn);
        listSecond.Add(arraySTn);
        listSecond.Add(arraySElvn);
        listSecond.Add(arraySTwlv);
        listSecond.Add(arraySDOne);
        listSecond.Add(arraySDTwo);
        listSecond.Add(arraySDThree);
        listSecond.Add(arraySDFour);
    }
    public void ClearLists()
    {
        Clear(listFirst);
        Clear(listSecond);   
    }
    private void Clear(List<int[]> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int[] array = list[i];
            array[array.Length - 1] = 0;
            list[i] = array;
        }
    }
    public List<int[]> Copy(bool isSecond = true)
    {
        if (isSecond)
            return listSecond;
        else
            return listFirst;
    }

}
