using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BaseShape : MonoBehaviour , IPointerClickHandler
{
    protected string messageText;
    protected GameManager gameManager;
    private const float minSpeed = 5 ;
    private float speed = minSpeed ;
    public float Speed{
        get => speed ;
        set{
            if( value >= minSpeed ){
                speed = value;
            }else{
                gameManager.ErrorMessage($"Value of Speed  set to {minSpeed} or heigher.");
            }
        }
    }

    private Color color ;

    protected Color MaterialColor{
        get=> color ;
        set{
            if( value != color ){
                // Debug.Log( "Change Color!!");
                color = value;
                GetComponent<Renderer>().material.color = color ;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        MaterialColor = new Color( 0.8f, 0.8f,0.8f, 1.0f);
        Initialize();
        ShowMessage();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( Vector3.up*Speed*Time.deltaTime ,Space.World);
    }
    public void OnPointerClick( PointerEventData eventData ){
        ShapeClicked();
        MovingShape();
        ShowMessage();
    }

    protected void ShowMessage(){
        gameManager.InfoMessage( messageText);
        messageText = string.Empty;
    }

    protected virtual void Initialize(){
        Speed = 10f ;
    }

    public virtual void ShapeClicked(){
        Debug.Log( Time.deltaTime);
        messageText = $"{nameof(ShapeClicked)} of {this.name}'s parent class\r\n";
    }

    protected virtual void MovingShape(){
        messageText += $"{nameof(MovingShape)} of {this.name}'s parent class\r\n" ;
        transform.Translate( Vector3.up*Speed*Time.deltaTime , Space.World);
        // transform.Rotate( Vector3.right*Speed );
    }

}
