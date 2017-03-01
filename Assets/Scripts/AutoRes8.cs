using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class AutoRes8 : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
      private List<Collider> listRandom;
      private List<Collider> listOrdered;
      private Node currentNode, goalNode;


      void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
      {
            ObjType.LoadObjectInScene();

            transform.GetComponent<UnityEngine.UI.Image>().color = Color.green;
            transform.GetComponentInChildren<UnityEngine.UI.Text>().color = Color.red;
            listRandom.Clear();  
     
            currentNode = PossibleMooves.GetActualListOrder(listRandom);                   
      }


      void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
      {
            transform.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            transform.GetComponentInChildren<UnityEngine.UI.Text>().color = Color.blue;

            //Astar ast = new Astar(currentNode, goalNode);
            Astar2 ast = new Astar2(currentNode, goalNode);
            ast.Search();

            print("sorti");
      }


      private void Start()
      {
            listRandom = new List<Collider>();
            listOrdered = new List<Collider>();

            foreach (GameObject obj in ObjType.listPalets)
            {                 
                Collider palet = obj.GetComponent<Collider>();
                //print(palet);
                listOrdered.Add(palet);
            }
          
          listOrdered.Add(null);        
          goalNode = new Node(listOrdered);
      }
}
