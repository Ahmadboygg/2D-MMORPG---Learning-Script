using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMenuPosition : MonoBehaviour
{
    [SerializeField] private GameObject actionMenu;
    [SerializeField] private RectTransform[] actionMenuPoint; // array for action menu position
    public int currentActiveMenu;
    void Start()
    {
        if(actionMenu != null || actionMenuPoint != null){
            foreach(RectTransform actionMenuPoints in actionMenuPoint){
                Instantiate(actionMenu,actionMenuPoints);
                actionMenuPoints.gameObject.SetActive(false);
            }
        }
        else
        {
            return;
        }
    }

    void Update()
    {
        for(int i = 0; i < actionMenuPoint.Length; i++)
        {
            actionMenuPoint[i].gameObject.SetActive(i == currentActiveMenu);
        }
    }

    
}