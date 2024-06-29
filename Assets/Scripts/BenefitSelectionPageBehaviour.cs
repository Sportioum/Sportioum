using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;
using UnityEngine.UI;

public class BenefitSelectionPageBehaviour : MonoBehaviour
{
    public GameObject benefit1;
    public GameObject benefit2;
    public GameObject benefit3;
    public GameObject benefit1_text;
    public GameObject benefit2_text;
    public GameObject benefit3_text;
    //public VerticalLayoutGroup vertical;
    //private float distance;
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
       // distance = vertical.spacing;
    }

    public void showTextForBenefit(int benefitNum)
    {
        if(benefitNum==1)
        {
            if(benefit1_text.activeSelf==true)
            {
                benefit1_text.SetActive(false);
               // vertical.spacing = vertical.spacing - 300f;
            }else
            {
                benefit1_text.SetActive(true);
            }


        }else if(benefitNum==2)
        {
            if (benefit2_text.activeSelf == true)
            {
                benefit2_text.SetActive(false);
            }
            else
            {
                benefit2_text.SetActive(true);
            }
        }
        else if(benefitNum==3)
        {
            if (benefit3_text.activeSelf == true)
            {
                benefit3_text.SetActive(false);
            }
            else
            {
                benefit3_text.SetActive(true);
            }
        }

    }
}
