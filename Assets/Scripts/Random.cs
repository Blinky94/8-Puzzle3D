using UnityEngine;
using System.Collections.Generic;

public class Random : MonoBehaviour
{
    private List<Transform> liste;
    private System.Random rnd;
    private bool isEmpty;

    void InitializeRandomPosition(List<Vector3> rndListe)
    {         
            for (int i = 0; i < rndListe.Count-1; i++)
                  ObjType.listPalets[i].transform.position = rndListe[i];
    }

    void Initialize () 
    {
        List<Vector3> rndListe = new List<Vector3>();
        rnd = new System.Random();
        int random = 0;
           
         liste = new List<Transform>();

        foreach(Transform child in ObjType.Plaque.transform)
            liste.Add(child);        

        isEmpty = false;
        int count = 0;

        while (isEmpty == false)
        {
            count = liste.Count;

            if (count == 0)
                isEmpty = true;
            else
            {
                random = rnd.Next(0, count);
                rndListe.Add(liste[random].transform.position);
                liste.RemoveAt(random);
            }
        }
        InitializeRandomPosition(rndListe);
	}

    void Start()
    {
        ChargeObjects.IntializeObjects();
        Initialize();
    }

    void Update()
    {
        Counter.UpdateTimer();
    }
}
