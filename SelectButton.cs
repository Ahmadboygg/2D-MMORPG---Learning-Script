using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    private Button[] button;
    private int currentButton;
    private int currentActiveMenu;

    void Start()
    {
        currentButton = 0; //default button selected value = 0
        button = GetComponentsInChildren<Button>();
    }
    void Update()
    {
        if(button != null){

            button[currentButton].Select();

            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(currentButton > 0)
                {
                    currentButton --;
                }
                else if(currentButton <= 0)
                {
                    currentButton = button.Length -1;
                }
            }
            else if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                if(currentButton < button.Length -1)
                {
                    currentButton ++;
                }
                else if(currentButton >= button.Length -1)
                {
                    currentButton = 0;
                }
            }

            if(Input.GetKeyDown(KeyCode.Return))
            {
                button[currentButton].onClick.Invoke();
            }

            if(Input.GetKeyDown(KeyCode.Escape))
            {
                ActionMenu actionMenu = GameObject.Find("Player Action Menu(Clone)").GetComponent<ActionMenu>();
                actionMenu.MainMenu();
            }
        }
        else
        {
            return;
        }
    }
}
