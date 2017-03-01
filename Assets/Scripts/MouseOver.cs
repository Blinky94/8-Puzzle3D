using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public bool isMouseOver;
    public bool isDoubleClick;

    void OnMouseOver()
    {
        isMouseOver = true;
    } 

    void OnMouseExit()
    {
        isMouseOver = false;       
    }
}
