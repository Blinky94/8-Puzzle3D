using UnityEngine;

public class MoovePalet : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 mousePos;
    private float distance;
    private float UD, LR;
    private bool Left, Right, Up, Down;
    private float startTime;
    private Transform StartPos, EndPos;
    private bool isLerping;
    private int huit, quinze;
  
    void OnMouseDown()
    {      
        mousePos = Input.mousePosition;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, screenPoint.z));
    }

    void GetDragDirection()
    {
        //Haut,droite,bas,gauche...
        if (UD >= 0.5) { Up = true; Down = false; Left = false; Right = false; }     
        else if (LR >= 0.5) { Up = false; Down = false; Left = false; Right = true; }                
        else if (UD <= -0.5) { Up = false; Down = true; Left = false; Right = false;}                         
        else if (LR <= 0.5) {  Up = false; Down = false;Left = true;  Right = false;}

        //Get direction
        if (Up)
        {
            //Test if dest plaque is free
            string name = GetComponent<PlaqueName>().plaqueName.transform.name.ToString();

                  if (ObjType.listPlaques.Count == huit)
                  {
                        switch (name)
                        {
                              case "plaque4":
                                    if (!ObjType.listPlaques[0].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[0].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque5":
                                    if (!ObjType.listPlaques[1].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[1].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[2].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[2].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque7":
                                    if (!ObjType.listPlaques[3].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[3].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque8":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque9":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
                  else if(ObjType.listPlaques.Count == quinze)
                  {
                        switch (name)
                        {
                              case "plaque5":
                                    if (!ObjType.listPlaques[0].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[0].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[1].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[1].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque7":
                                    if (!ObjType.listPlaques[2].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[2].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque8":
                                    if (!ObjType.listPlaques[3].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[3].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque9":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque10":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque11":
                                    if (!ObjType.listPlaques[6].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[6].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque12":
                                    if (!ObjType.listPlaques[7].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[7].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque13":
                                    if (!ObjType.listPlaques[8].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[8].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque14":
                                    if (!ObjType.listPlaques[9].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[9].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque15":
                                    if (!ObjType.listPlaques[10].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[10].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque16":
                                    if (!ObjType.listPlaques[11].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[11].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
           
        }
        else if (Down)
        {
            //Test if dest plaque is free
            string name = GetComponent<PlaqueName>().plaqueName.transform.name.ToString();

            if (ObjType.listPlaques.Count == huit)
                  {
                        switch (name)
                        {
                              case "plaque1":
                                    if (!ObjType.listPlaques[3].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[3].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque2":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque3":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque4":
                                    if (!ObjType.listPlaques[6].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[6].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque5":
                                    if (!ObjType.listPlaques[7].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[7].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[8].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[8].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
                  else if (ObjType.listPlaques.Count == quinze)
                  {
                        switch (name)
                        {
                              case "plaque1":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque2":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque3":
                                    if (!ObjType.listPlaques[6].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[6].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque4":
                                    if (!ObjType.listPlaques[7].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[7].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque5":
                                    if (!ObjType.listPlaques[8].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[8].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[9].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[9].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque7":
                                    if (!ObjType.listPlaques[10].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[10].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque8":
                                    if (!ObjType.listPlaques[11].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[11].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque9":
                                    if (!ObjType.listPlaques[12].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[12].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque10":
                                    if (!ObjType.listPlaques[13].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[13].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque11":
                                    if (!ObjType.listPlaques[14].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[14].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque12":
                                    if (!ObjType.listPlaques[15].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[15].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
            }
        else if (Left)
        {
            //Test if dest plaque is free
            string name = GetComponent<PlaqueName>().plaqueName.transform.name.ToString();

                  if (ObjType.listPlaques.Count == huit)
                  {
                        switch (name)
                        {
                              case "plaque2":
                                    if (!ObjType.listPlaques[0].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[0].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque3":
                                    if (!ObjType.listPlaques[1].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[1].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque5":
                                    if (!ObjType.listPlaques[3].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[3].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque8":
                                    if (!ObjType.listPlaques[6].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[6].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque9":
                                    if (!ObjType.listPlaques[7].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[7].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
                  if (ObjType.listPlaques.Count == quinze)
                  {
                        switch (name)
                        {
                              case "plaque2":
                                    if (!ObjType.listPlaques[0].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[0].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque3":
                                    if (!ObjType.listPlaques[1].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[1].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque4":
                                    if (!ObjType.listPlaques[2].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[2].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque7":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque8":
                                    if (!ObjType.listPlaques[6].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[6].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque10":
                                    if (!ObjType.listPlaques[8].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[8].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque11":
                                    if (!ObjType.listPlaques[9].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[9].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque12":
                                    if (!ObjType.listPlaques[10].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[10].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque14":
                                    if (!ObjType.listPlaques[12].GetComponent<PaletName>().AsCollider)
                                    {
                                        startTime = Time.time;
                                        StartPos = transform;
                                        EndPos = ObjType.listPlaques[12].GetComponent<PaletName>().transform;
                                        isLerping = true;
                                    }
                                    break;
                              case "plaque15":
                                    if (!ObjType.listPlaques[13].GetComponent<PaletName>().AsCollider)
                                    {
                                        startTime = Time.time;
                                        StartPos = transform;
                                        EndPos = ObjType.listPlaques[13].GetComponent<PaletName>().transform;
                                        isLerping = true;
                                    }
                                    break;
                              case "plaque16":
                                    if (!ObjType.listPlaques[14].GetComponent<PaletName>().AsCollider)
                                    {
                                        startTime = Time.time;
                                        StartPos = transform;
                                        EndPos = ObjType.listPlaques[14].GetComponent<PaletName>().transform;
                                        isLerping = true;
                                    }
                                    break;
                        }
                  }
            }
        else if (Right)
        {
            //Test if dest plaque is free
            string name = GetComponent<PlaqueName>().plaqueName.transform.name.ToString();
                  if (ObjType.listPlaques.Count == huit)
                  {
                        switch (name)
                        {
                              case "plaque1":
                                    if (!ObjType.listPlaques[1].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[1].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque2":
                                    if (!ObjType.listPlaques[2].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[2].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque4":
                                    if (!ObjType.listPlaques[4].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[4].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque5":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque7":
                                    if (!ObjType.listPlaques[7].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[7].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque8":
                                    if (!ObjType.listPlaques[8].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[8].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
                  if (ObjType.listPlaques.Count == quinze)
                  {
                        switch (name)
                        {
                              case "plaque1":
                                    if (!ObjType.listPlaques[1].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[1].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque2":
                                    if (!ObjType.listPlaques[2].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[2].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque3":
                                    if (!ObjType.listPlaques[3].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[3].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque5":
                                    if (!ObjType.listPlaques[5].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[5].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque6":
                                    if (!ObjType.listPlaques[6].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[6].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque7":
                                    if (!ObjType.listPlaques[7].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[7].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque9":
                                    if (!ObjType.listPlaques[9].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[9].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque10":
                                    if (!ObjType.listPlaques[10].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[10].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque11":
                                    if (!ObjType.listPlaques[11].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[11].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque13":
                                    if (!ObjType.listPlaques[13].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[13].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque14":
                                    if (!ObjType.listPlaques[14].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[14].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                              case "plaque15":
                                    if (!ObjType.listPlaques[15].GetComponent<PaletName>().AsCollider)
                                    {
                                          startTime = Time.time;
                                          StartPos = transform;
                                          EndPos = ObjType.listPlaques[15].GetComponent<PaletName>().transform;
                                          isLerping = true;
                                    }
                                    break;
                        }
                  }
            }      
    }

    void OnMouseDrag()
    {
        Vector3 mouseDir = Input.mousePosition - mousePos;
        mouseDir.Normalize();

        UD = Vector3.Dot(mouseDir, Vector3.up);
        LR = Vector3.Dot(mouseDir, Vector3.right);

        GetDragDirection();
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

    void Start()
    {
        Up = false;
        Right = false;
        Down = false;
        Left = false;

        huit = 9;
        quinze = 16;
    }

    void FixedUpdate()
    {
        if (isLerping)
        {
            distance = Vector3.Distance(StartPos.position, EndPos.position);
            float distCovered = Time.time - startTime;
            float fracJourney = (distCovered / distance) * 2.0f;

            transform.position = Vector3.Lerp(StartPos.position, EndPos.position, fracJourney);

            if (fracJourney >= 1.0f)
            {
                isLerping = false;
  
                Up = false;
                Down = false;
                Left = false;
                Right = false;
            }
        }      
    }
}
