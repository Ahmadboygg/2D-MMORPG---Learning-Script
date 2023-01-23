using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMenu : MonoBehaviour
{
    private GameObject[] menu;
    private int currentMenu; // variable for change action menu object
    private int menuIndex; // variable for change action menu object
    void Start()
    {
        menu = GameObject.FindGameObjectsWithTag("Action Menu");
        foreach(GameObject Menus in menu){
            Menus.gameObject.SetActive(false); // default action menu object is set active false
        }
        currentMenu = 0;
    }

    void Update()
    {
        // logic for showing action menu and change showed action menu

        if(menu != null){
            for(int i = 0; i < menu.Length; i++)
            {
                menu[i].SetActive(i == currentMenu);
            }
        }
        else{
            return;
        }
    }

    public void MainMenu()
    {
        currentMenu = 0;
    }

    public void SkillMenu()
    {
        currentMenu = 1;
    }

    public void ItemMenu()
    {
        currentMenu = 2;
    }

}
