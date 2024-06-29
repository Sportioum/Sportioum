using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AuthenticationManagerScript : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public bool isAuthenticated = false;
    public GameObject sportsSelectionPage;
    public GameObject createProfilePage;
    public bool isPro = false;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void signIn()
    {
        if(isAuthenticated)
        {
            sportsSelectionPage.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void signUp()
    {
        //authenticate a signUp
        //if pref doesn't exist
        if(isAuthenticated && PlayerPrefs.HasKey("loggedInBefore_Pro")==false && isPro)  //its the first login, go to the create profile page
        {
            createProfilePage.SetActive(true);
            gameObject.SetActive(false);
        }else if(isAuthenticated && isPro==false)
        {
            sportsSelectionPage.SetActive(true);
            gameObject.SetActive(false);
        }
      


    }

    public void setUserType(int i)
    {
        if(i==1)
        {
            isPro = false;
        }else if(i==2)
        {
            isPro = true;
        }
    }
}
