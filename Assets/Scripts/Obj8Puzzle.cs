using UnityEngine;
using System.Collections.Generic;

public static class Obj8Puzzle
{  
    public static GameObject Plaque;
    public static GameObject plaque1, plaque2, plaque3, plaque4, plaque5, plaque6, plaque7, plaque8, plaque9;
    public static GameObject Palet1, Palet2, Palet3, Palet4, Palet5, Palet6, Palet7, Palet8;
    public static GameObject Haut, Bas, Gauche, Droit, Fond;
    public static List<GameObject> listPalets;
 
    public static void LoadObjectInScene()
    {
        Plaque = GameObject.Find("Plaque");

        plaque1 = GameObject.Find("plaque1");
        plaque2 = GameObject.Find("plaque2");
        plaque3 = GameObject.Find("plaque3");
        plaque4 = GameObject.Find("plaque4");
        plaque5 = GameObject.Find("plaque5");
        plaque6 = GameObject.Find("plaque6");
        plaque7 = GameObject.Find("plaque7");
        plaque8 = GameObject.Find("plaque8");
        plaque9 = GameObject.Find("plaque9");

        Palet1 = GameObject.Find("Palet 1");
        Palet2 = GameObject.Find("Palet 2");
        Palet3 = GameObject.Find("Palet 3");
        Palet4 = GameObject.Find("Palet 4");
        Palet5 = GameObject.Find("Palet 5");
        Palet6 = GameObject.Find("Palet 6");
        Palet7 = GameObject.Find("Palet 7");
        Palet8 = GameObject.Find("Palet 8");

        listPalets = new List<GameObject>() { Palet1, Palet2, Palet3, Palet4, Palet5, Palet6, Palet7, Palet8 };

        Haut = GameObject.Find("Haut");
        Bas = GameObject.Find("Bas");
        Gauche = GameObject.Find("Gauche");
        Droit = GameObject.Find("Droit");
        Fond = GameObject.Find("Fond");
    }
}
