using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    private int numberButton;
    private Button btn;
    private Text textBtn;
    //
    private GController gController;
    public bool isAI = false;

    private void Awake()
    {
        textBtn = transform.GetChild(0).GetComponent<Text>();
        btn = transform.gameObject.GetComponent<Button>();
        //
        btn.onClick.AddListener(HitAtBtn);
    }
    private void Start()
    {
        gController = transform.parent.GetComponent<GController>();
    }
    public void SetNumber(int number)
    {
        numberButton = number;
    }

    public void WithAI()
    {
        isAI = true;
    }
    private void HitAtBtn()
    {
        if(!isAI)
            SetStepSymbol(gController.SetSymbStep(numberButton));
        //Эта ветка идет в методах скрипта AI, но на его ход, и нам так же нужно делать ход с имеющихся кнопок
        else
            gController.SetSymbStep(numberButton, true);
    }
    public void SetStepSymbol(string symbol)
    {
        textBtn.text = symbol;
        btn.onClick.RemoveAllListeners();
    }


}
