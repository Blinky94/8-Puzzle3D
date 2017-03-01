using UnityEngine;

public class PlaqueName : MonoBehaviour 
{
    public Collider plaqueName;

	void Start () 
    {
        plaqueName = null;
	}

    void Update()
    {        
        foreach(Transform child in ObjType.Plaque.transform)
        {
            if (child.GetComponent<PaletName>().paletName == transform.GetComponent<Collider>())
                plaqueName = child.GetComponent<Collider>();
        }       
    }   
}
