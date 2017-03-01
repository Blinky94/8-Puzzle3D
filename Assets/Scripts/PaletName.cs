using UnityEngine;

public class PaletName : MonoBehaviour 
{
    public Collider paletName;
    public bool AsCollider;

    void Start()
    {
        AsCollider = false;
    }

    void OnCollisionEnter(Collision obj)
    {
        paletName = obj.collider;
        AsCollider = true;
    }

    void OnCollisionExit(Collision obj)
    {
        paletName = null;
        AsCollider = false;
    }
}
