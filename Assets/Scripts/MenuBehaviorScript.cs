using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviorScript : MonoBehaviour
{
    public GameObject[] menuManager;
    public bool organiseMenus = true;
    // Start is called before the first frame update
    void Start()
    {
        if (organiseMenus && menuManager.Length > 0)
        {

            for (int i = 0; i < menuManager.Length; i++)
            {
                if (i == 0)
                {
                    menuManager[i].SetActive(true);
                }
                else menuManager[i].SetActive(false);
            }
        }
    }


    public void closeAllPages()
    {
        for (int i = 0; i < menuManager.Length; i++)
        {
            menuManager[i].SetActive(false);
        }
    }
}
