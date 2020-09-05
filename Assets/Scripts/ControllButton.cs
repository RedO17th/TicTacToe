using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllButton : MonoBehaviour
{
    [SerializeField]
    private int tailsNumber;
    [SerializeField]
    private Transform gController;



    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(LoadTails);
    }
    private void LoadTails()
    {
        gController.GetComponent<GController>().GetCountTail(tailsNumber);
    }
}
