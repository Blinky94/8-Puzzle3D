using UnityEngine;
using System.Collections.Generic;

    public static class ObjType
    {
        public static GameObject Plaque;
        public static GameObject Haut, Bas, Gauche, Droit, Fond;
        public static List<GameObject> listPalets,listPlaques;   
        public static GameObject Timer;
 
        public static void LoadObjectInScene()
        {
            listPlaques = new List<GameObject>();
            listPalets = new List<GameObject>();

            Plaque = GameObject.Find("Plaque");

            int plaqueNbre = Plaque.transform.childCount;
            int paletNbre = Plaque.transform.childCount-1;

            for (int i = 1; i <= plaqueNbre; i++)
            {
                  GameObject _gObj = GameObject.Find("plaque" + i);
                  listPlaques.Add(_gObj);
            }

            for (int j = 1; j <= paletNbre; j++)
            {
                  GameObject _gObj = GameObject.Find(j.ToString());
                  listPalets.Add(_gObj);
            }
   
            Haut = GameObject.Find("Haut");
            Bas = GameObject.Find("Bas");
            Gauche = GameObject.Find("Gauche");
            Droit = GameObject.Find("Droit");
            Fond = GameObject.Find("Fond");
            Timer = GameObject.Find("Timer");     
        }
    }
