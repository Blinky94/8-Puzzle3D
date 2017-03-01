using UnityEngine;

public class MouseSelect : MonoBehaviour 
{
    public bool isSelected;
    void OnMouseDown()
    {
        isSelected = true;
    }

    void OnMouseUp()
    {
        isSelected = false;
    }
}
