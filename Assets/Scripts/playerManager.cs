using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerManager : MonoBehaviour
{
    public int playerInt;
    [SerializeField] Sprite Sprite1;
    [SerializeField] Sprite Sprite2;
    [SerializeField] Sprite Sprite3;
    [SerializeField] Sprite Sprite4;

    public void pressForm1(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite1;
        playerInt = 0;
    }
    public void pressForm2(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite2;
        playerInt = 1;
    }
    public void pressForm3(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite3;
        playerInt = 2;
    }
    public void pressForm4(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite4;
        playerInt = 3;
    }
}
