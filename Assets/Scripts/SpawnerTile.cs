using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerTile : MonoBehaviour
{
    [SerializeField]
    private GameObject prefTile;
    private List<Button> listOfTail = new List<Button>();
    private GController gController;

    public void Spawn(int countTiles)
    {
        DeleteTile();
        GetComponent<GridLayoutGroup>().constraintCount = countTiles;

        for (int i = 0; i < countTiles * countTiles; i++)
        {
            GameObject tile = Instantiate(prefTile, transform);
            tile.GetComponent<Tile>().SetNumber(i);
            listOfTail.Add(tile.GetComponent<Button>());
        }
    }
    public void StopGame()
    {
        foreach (Button btn in listOfTail)
        {
            btn.onClick.RemoveAllListeners();
        }
    }
    //ВЫключение определенной кнопки
    public void OffButton(int index, string symbol)
    {
        listOfTail[index].GetComponent<Tile>().SetStepSymbol(symbol);
    }
    private void DeleteTile()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Destroy(child.gameObject);
        }
    }
    public void ToPlayWithAI()
    {
        foreach (Button btn in listOfTail)
        {
            btn.GetComponent<Tile>().WithAI();
        }
    }
}
