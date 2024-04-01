using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    int Amount = 3;
    public GameObject prefabsgreen;
    public GameObject prefabsred;
    public GameObject prefabsblack;
    public static int Count=0; 

    private void Update()
    {
        if(Count <= 0) {
            spawnApple();
        }
    }
    public void spawnApple()
    {
        for (int i = 0; i < Amount; i++)
        {
            Instantiate(prefabsgreen);
            Instantiate(prefabsred);
            Instantiate(prefabsblack);
        }
        Count += 9;
    }

}
