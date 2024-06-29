using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SetPlaceHolderTextScript : MonoBehaviour
{
    private TMP_InputField myInputField;
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
        myInputField = gameObject.GetComponent<TMP_InputField>();
    }

    public void setPlaceHolderText(string searchText)
    {
        myInputField.placeholder.GetComponent<TextMeshProUGUI>().text = searchText;
    }
}
