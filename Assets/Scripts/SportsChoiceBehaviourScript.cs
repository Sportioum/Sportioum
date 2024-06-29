using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsChoiceBehaviourScript : MonoBehaviour
{
    public GameObject popup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if(PlayerPrefs.HasKey("hasLoggedInBefore_Fan")==false)
        {
            popup.SetActive(true);
            StartCoroutine(turnOffPopUps());
        }
    }

    IEnumerator turnOffPopUps()
    {
        yield return new WaitForSeconds(2);
        popup.SetActive(false);
    }
}
