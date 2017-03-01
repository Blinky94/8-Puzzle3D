using UnityEngine;
using System.Collections.Generic;

class PossibleMooves
{
    public static int NullPosition(List<Collider> list)
    {
        int index = 0;

        for (int i = 0; i < list.Count; i++)
            if (list[i] == null)
                index = i + 1;

        return index;
    }

    public static Node GetActualListOrder(List<Collider> list)
    {        
        foreach (var obj in ObjType.Plaque.GetComponentsInChildren<PaletName>())
        {
            Collider palet = obj.GetComponent<Collider>().GetComponent<PaletName>().paletName;
            list.Add(palet);
        }

        Node newNode = new Node(list);

        return newNode;
    }

    public static List<List<Collider>> ListOfMooves(int inch, int nullPos, List<Collider> currentList)
    {
        List<List<Collider>> listOfPossibles = new List<List<Collider>>();

        if (inch == 9)
        {
            switch (nullPos)
            {
                case 1:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[1],null,currentList[2],
                              currentList[3], currentList[4], currentList[5],
                              currentList[6], currentList[7], currentList[8]                        
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[3],currentList[1],currentList[2],
                              null, currentList[4], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });
                    break;
                case 2:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              null,currentList[0],currentList[2],
                              currentList[3], currentList[4], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[4],currentList[2],
                              currentList[3], null, currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[2],null,
                              currentList[3], currentList[4], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });
                    break;
                case 3:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],null,currentList[1],
                              currentList[3], currentList[4], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[5],
                              currentList[3], currentList[4], null,
                              currentList[6], currentList[7], currentList[8]
                        });
                    break;
                case 4:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              null,currentList[1],currentList[2],
                              currentList[0], currentList[4], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[4], null, currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[6], currentList[4], currentList[5],
                              null, currentList[7], currentList[8]
                        });
                    break;
                case 5:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],null,currentList[2],
                              currentList[3], currentList[1], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[5], null,
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[7], currentList[5],
                              currentList[6], null, currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              null, currentList[3], currentList[5],
                              currentList[6], currentList[7], currentList[8]
                        });
                    break;
                case 6:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],null,
                              currentList[3], currentList[4], currentList[2],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], null, currentList[4],
                              currentList[6], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[4], currentList[8],
                              currentList[6], currentList[7], null
                        });
                    break;
                case 7:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              null, currentList[4], currentList[5],
                              currentList[3], currentList[7], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[4], currentList[5],
                              currentList[7], null, currentList[8]
                        });
                    break;
                case 8:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], null, currentList[5],
                              currentList[6], currentList[4], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[4], currentList[5],
                              null, currentList[6], currentList[8]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[4], currentList[5],
                              currentList[6], currentList[8], null
                        });
                    break;
                case 9:
                    listOfPossibles.Clear();

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[4], currentList[5],
                              currentList[6], null, currentList[7]
                        });

                    listOfPossibles.Add(new List<Collider>()
                        {
                              currentList[0],currentList[1],currentList[2],
                              currentList[3], currentList[4], null,
                              currentList[6], currentList[7], currentList[5]
                        });
                    break;
            }
        }

        else if(inch == 16)
        {

        }
       
        return listOfPossibles;
    }
}
