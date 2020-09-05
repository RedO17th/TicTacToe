using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataFive : MonoBehaviour
{
    //FP----------------------------------------------------------
    private int[] arrayOne = new int[] { 0, 1, 2, 3, 4, 0};
    private int[] arrayOneBack = new int[] { 4, 3, 2, 1, 0, 0 };
    private int[] arrayTwo = new int[] { 5, 6, 7, 8, 9, 0 };
    private int[] arrayTwoBack = new int[] { 9, 8, 7, 6, 5, 0 };
    private int[] arrayThree = new int[] { 10, 11, 12, 13, 14, 0 };
    private int[] arrayThreeBack = new int[] { 14, 13, 12, 11, 10, 0 };
    private int[] arrayFour = new int[] { 15, 16, 17, 18, 19, 0 };
    private int[] arrayFourBack = new int[] { 19, 18, 17, 16, 15, 0 };
    private int[] arrayFive = new int[] { 20, 21, 22, 23, 24, 0 };
    private int[] arrayFiveBack = new int[] { 24, 23, 22, 21, 20, 0 };

    private int[] arraySix = new int[] { 0, 5, 10, 15, 20, 0 };
    private int[] arraySixBack = new int[] { 20, 15, 10, 5, 0, 0 };
    private int[] arraySeven = new int[] { 1, 6, 11, 16, 21, 0 };
    private int[] arraySevenBack = new int[] { 21, 16, 11, 6, 1, 0 };
    private int[] arrayEight = new int[] { 2, 7, 12, 17, 22, 0 };
    private int[] arrayEightBack = new int[] { 22, 17, 12, 7, 2, 0 };
    private int[] arrayNine = new int[] { 3, 8, 13, 18, 23, 0 };
    private int[] arrayNineBack = new int[] { 23, 18, 13, 8, 3, 0 };
    private int[] arrayTen = new int[] { 4, 9, 14, 19, 24, 0 };
    private int[] arrayTenBack = new int[] { 24, 19, 14, 9, 4, 0 };
    //D:
    private int[] arrayEleven = new int[] { 0, 6, 12, 18, 24, 0 };
    private int[] arrayElevenBack = new int[] { 24, 18, 12, 6, 0, 0 };
    private int[] arrayTwelve = new int[] { 4, 8, 12, 16, 20, 0 };
    private int[] arrayTwelveBack = new int[] { 20, 16, 12, 8, 4, 0 };
    //SP----------------------------------------------------------
    private int[] sArrayOne = new int[] { 0, 1, 2, 3, 4, 0 };
    private int[] sArrayOneBack = new int[] { 4, 3, 2, 1, 0, 0 };
    private int[] sArrayTwo = new int[] { 5, 6, 7, 8, 9, 0 };
    private int[] sArrayTwoBack = new int[] { 9, 8, 7, 6, 5, 0 };
    private int[] sArrayThree = new int[] { 10, 11, 12, 13, 14, 0 };
    private int[] sArrayThreeBack = new int[] { 14, 13, 12, 11, 10, 0 };
    private int[] sArrayFour = new int[] { 15, 16, 17, 18, 19, 0 };
    private int[] sArrayFourBack = new int[] { 19, 18, 17, 16, 15, 0 };
    private int[] sArrayFive = new int[] { 20, 21, 22, 23, 24, 0 };
    private int[] sArrayFiveBack = new int[] { 24, 23, 22, 21, 20, 0 };

    private int[] sArraySix = new int[] { 0, 5, 10, 15, 20, 0 };
    private int[] sArraySixBack = new int[] { 20, 15, 10, 5, 0, 0 };
    private int[] sArraySeven = new int[] { 1, 6, 11, 16, 21, 0 };
    private int[] sArraySevenBack = new int[] { 21, 16, 11, 6, 1, 0 };
    private int[] sArrayEight = new int[] { 2, 7, 12, 17, 22, 0 };
    private int[] sArrayEightBack = new int[] { 22, 17, 12, 7, 2, 0 };
    private int[] sArrayNine = new int[] { 3, 8, 13, 18, 23, 0 };
    private int[] sArrayNineBack = new int[] { 23, 18, 13, 8, 3, 0 };
    private int[] sArrayTen = new int[] { 4, 9, 14, 19, 24, 0 };
    private int[] sArrayTenBack = new int[] { 24, 19, 14, 9, 4, 0 };
    //D:
    private int[] sArrayEleven = new int[] { 0, 6, 12, 18, 24, 0 };
    private int[] sArrayElevenBack = new int[] { 24, 18, 12, 6, 0, 0 };
    private int[] sArrayTwelve = new int[] { 4, 8, 12, 16, 20, 0 };
    private int[] sArrayTwelveBack = new int[] { 20, 16, 12, 8, 4, 0 };

    private List<int[]> listFirst = new List<int[]>();
    private List<int[]> listSecond = new List<int[]>();

    private void Awake()
    {
        CopyOne();
        CopyTwo();
    }
    private void CopyOne()
    {
        listFirst.Add(arrayOne);
        listFirst.Add(arrayOneBack);
        listFirst.Add(arrayTwo);
        listFirst.Add(arrayTwoBack);
        listFirst.Add(arrayThree);
        listFirst.Add(arrayThreeBack);
        listFirst.Add(arrayFour);
        listFirst.Add(arrayFourBack);
        listFirst.Add(arrayFive);
        listFirst.Add(arrayFiveBack);
        listFirst.Add(arraySix);
        listFirst.Add(arraySixBack);
        listFirst.Add(arraySeven);
        listFirst.Add(arraySevenBack);
        listFirst.Add(arrayEight);
        listFirst.Add(arrayEightBack);
        listFirst.Add(arrayNine);
        listFirst.Add(arrayNineBack);
        listFirst.Add(arrayTen);
        listFirst.Add(arrayTenBack);

        listFirst.Add(arrayEleven);
        listFirst.Add(arrayElevenBack);
        listFirst.Add(arrayTwelve);
        listFirst.Add(arrayTwelveBack);
    }
    private void CopyTwo()
    {
        listSecond.Add(sArrayOne);
        listSecond.Add(sArrayOneBack);
        listSecond.Add(sArrayTwo);
        listSecond.Add(sArrayTwoBack);
        listSecond.Add(sArrayThree);
        listSecond.Add(sArrayThreeBack);
        listSecond.Add(sArrayFour);
        listSecond.Add(sArrayFourBack);
        listSecond.Add(sArrayFive);
        listSecond.Add(sArrayFiveBack);
        listSecond.Add(sArraySix);
        listSecond.Add(sArraySixBack);
        listSecond.Add(sArraySeven);
        listSecond.Add(sArraySevenBack);
        listSecond.Add(sArrayEight);
        listSecond.Add(sArrayEightBack);
        listSecond.Add(sArrayNine);
        listSecond.Add(sArrayNineBack);
        listSecond.Add(sArrayTen);
        listSecond.Add(sArrayTenBack);

        listSecond.Add(sArrayEleven);
        listSecond.Add(sArrayElevenBack);
        listSecond.Add(sArrayTwelve);
        listSecond.Add(sArrayTwelveBack);
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

    //public void CopyDataFirst(List<int[]> listArrays)
    //{
    //    listArrays.Add(arrayOne);
    //    listArrays.Add(arrayOneBack);
    //    listArrays.Add(arrayTwo);
    //    listArrays.Add(arrayTwoBack);
    //    listArrays.Add(arrayThree);
    //    listArrays.Add(arrayThreeBack);
    //    listArrays.Add(arrayFour);
    //    listArrays.Add(arrayFourBack);
    //    listArrays.Add(arrayFive);
    //    listArrays.Add(arrayFiveBack);
    //    listArrays.Add(arraySix);
    //    listArrays.Add(arraySixBack);
    //    listArrays.Add(arraySeven);
    //    listArrays.Add(arraySevenBack);
    //    listArrays.Add(arrayEight);
    //    listArrays.Add(arrayEightBack);
    //    listArrays.Add(arrayNine);
    //    listArrays.Add(arrayNineBack);
    //    listArrays.Add(arrayTen);
    //    listArrays.Add(arrayTenBack);

    //    listArrays.Add(arrayEleven);
    //    listArrays.Add(arrayElevenBack);
    //    listArrays.Add(arrayTwelve);
    //    listArrays.Add(arrayTwelveBack);
    //}
    //public void CopyDataSecond(List<int[]> listArrays)
    //{
    //    listArrays.Add(sArrayOne);
    //    listArrays.Add(sArrayOneBack);
    //    listArrays.Add(sArrayTwo);
    //    listArrays.Add(sArrayTwoBack);
    //    listArrays.Add(sArrayThree);
    //    listArrays.Add(sArrayThreeBack);
    //    listArrays.Add(sArrayFour);
    //    listArrays.Add(sArrayFourBack);
    //    listArrays.Add(sArrayFive);
    //    listArrays.Add(sArrayFiveBack);
    //    listArrays.Add(sArraySix);
    //    listArrays.Add(sArraySixBack);
    //    listArrays.Add(sArraySeven);
    //    listArrays.Add(sArraySevenBack);
    //    listArrays.Add(sArrayEight);
    //    listArrays.Add(sArrayEightBack);
    //    listArrays.Add(sArrayNine);
    //    listArrays.Add(sArrayNineBack);
    //    listArrays.Add(sArrayTen);
    //    listArrays.Add(sArrayTenBack);

    //    listArrays.Add(sArrayEleven);
    //    listArrays.Add(sArrayElevenBack);
    //    listArrays.Add(sArrayTwelve);
    //    listArrays.Add(sArrayTwelveBack);
}
