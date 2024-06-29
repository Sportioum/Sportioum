using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePageBehaviourScript : MonoBehaviour
{
    public GameObject bronzeSupportText;
    public GameObject silverSupportText;
    public GameObject goldSupportText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSupportLevel(int supportLevel)
    {
        if(supportLevel==1)
        {
            bronzeSupportText.SetActive(true);
            silverSupportText.SetActive(false);
            goldSupportText.SetActive(false);

        }else if(supportLevel==2)
        {
            bronzeSupportText.SetActive(false);
            silverSupportText.SetActive(true);
            goldSupportText.SetActive(false);
        }
        else if(supportLevel==3)
        {
            bronzeSupportText.SetActive(false);
            silverSupportText.SetActive(false);
            goldSupportText.SetActive(true);
        }
    }
}
