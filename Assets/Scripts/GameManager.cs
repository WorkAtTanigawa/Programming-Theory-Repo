using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]Text messageArea;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowMessage( string messageText ){
        messageArea.text = messageText;
    }
    public void ErrorMessage(string messageText){
        messageArea.color = Color.red;
        ShowMessage(messageText);
    }

    public void InfoMessage( string messageText){
        messageArea.color = Color.black;
        ShowMessage(messageText);
    }
}
