using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateProfileBehaviourScript : MonoBehaviour
{
    public TMP_InputField name_Pro;
    public TMP_InputField DOB;
    public TMP_InputField nationality;
    public TMP_InputField currentTeam;
    public TMP_InputField bio;
    public TMP_InputField awards;

    private GameObject profilePicContainer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveProfileData()
    {
        //localise strings
        string name = name_Pro.text;
        string date = DOB.text;
        string from = nationality.text;
        string team = currentTeam.text;
        string about = bio.text;
        string experience = awards.text;

        //get authenticated username(currently logged in)
        //save data to server

        

    }
}
