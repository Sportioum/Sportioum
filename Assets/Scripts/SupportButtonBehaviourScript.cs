using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportButtonBehaviourScript : MonoBehaviour
{
    public int supportLevel = 0;
    public GameObject purchasePage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToPurchasePage(int supportLevel)
    {
        purchasePage.SetActive(true);
        //get the purchasePageManagerScript

    }
}
