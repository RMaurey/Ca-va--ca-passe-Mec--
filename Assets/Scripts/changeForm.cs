using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class changeForm : MonoBehaviour
{
    [SerializeField] Sprite square;
    [SerializeField] Sprite circle;

    public void pressForm1 (InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = square;
        Debug.Log("carré");
    }
    public void pressForm2(InputAction.CallbackContext ctx)
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = circle;
        Debug.Log("cercle");
    }
}
