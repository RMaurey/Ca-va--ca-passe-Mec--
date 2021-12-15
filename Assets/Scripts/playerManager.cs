using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerManager : MonoBehaviour
{
    public int playerInt;
    [SerializeField] Sprite Quentin1;
    [SerializeField] Sprite Quentin2;
    [SerializeField] Sprite Quentin3;
    [SerializeField] Sprite Quentin4;

    public void pressForm1(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Quentin1;
        playerInt = 0;
    }
    public void pressForm2(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Quentin2;
        playerInt = 1;
    }
    public void pressForm3(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Quentin3;
        playerInt = 2;
    }
    public void pressForm4(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Quentin4;
        playerInt = 3;
    }
}
