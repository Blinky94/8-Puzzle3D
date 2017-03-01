using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Astar
{
      private int D;
      private List<Node> openList;
      private List<Node> closedList;
      private Node goalList;
      private int inch;
      private int counter;
      private List<Node> listOrdered;

      private List<Node> SelectMinF(List<Node> list)
      {
            listOrdered.Clear();
            listOrdered = list;

            if (list.Count > 1)
            {
                  int longueur = list.Count;
                  bool permut;

                  do
                  {
                        // hypothèse : le tableau est trié
                        permut = false;
                        for (int i = 0; i < longueur - 1; i++)
                        {
                              // Teste si 2 éléments successifs sont dans le bon ordre ou non
                              if (list[i].F > list[i + 1].F)
                              {
                                    Node tmp = list[i];
                                    list[i] = list[i + 1];
                                    list[i + 1] = tmp;
                                    permut = true;
                              }
                        }
                  }
                  while (permut);
            }
         
            return listOrdered;
      }

      private int CalculBadPaletNumbers(List<Collider> currentList, List<Collider> goalList)
      {
            counter = 0;

            for (int i = 0; i < currentList.Count; i++)
            {
                  if (currentList[i] != goalList[i])
                        counter++;
            }

            return counter;
      }

      public Astar(Node currentList, Node goalList)
      {
            inch = currentList.ListColliders.Count;
            D = 1;
            this.goalList = goalList;

            Node newNode = new Node(currentList.ListColliders);

            openList = new List<Node>();
            closedList = new List<Node>();

            newNode.G = 0;
            newNode.H = 0;
            newNode.F = newNode.G + newNode.H;

            openList.Add(newNode);

            listOrdered = new List<Node>();
      }

      private bool IsCurrentNodeInTheList(Node currentNode, List<Node> currentList)
      {
            bool equal = false;

            List<Collider> curList = new List<Collider>();
            curList = currentNode.ListColliders;

            foreach (Node node in currentList)
            {
                  List<Collider> list = new List<Collider>();
                  list = node.ListColliders;

                  if (CalculBadPaletNumbers(curList, list) == 0)
                        equal = true;
                  else
                        equal = false;
            }

            return equal;
      }

      private List<Node> GetAdjacentsNodes(Node current)
      {
            List<Node> listAdjacents = new List<Node>();

            return listAdjacents;
      }

      private List<Node> RewardPathFromEndToStart(Node fromGoal, Node toStart)
      {
            List<Node> listPath = new List<Node>();
            Node current = fromGoal;

            while (current != toStart)
            {
                  listPath.Add(current);
                  current = current.Parent;
            }

            return listPath;
      }

      private Node currentNode;

      public void Search()
      {
            bool stop = false;
              Node startNode = openList[0];
            currentNode = startNode;
            do
            {
                  Debug.Log("------------------------BOUCLE PRINCIPALE-------------------------- ");

                  List<Node> orderedListNode = SelectMinF(openList);

                  if (orderedListNode.Count > 0)
                  {
                        currentNode = new Node(orderedListNode[0].ListColliders);
                        currentNode.F = orderedListNode[0].F;
                        currentNode.G = orderedListNode[0].G;
                        currentNode.H = orderedListNode[0].H;
                        currentNode.Parent = orderedListNode[0].Parent;
                  }
                  Debug.Log(CalculBadPaletNumbers(currentNode.ListColliders, goalList.ListColliders));
                  if (CalculBadPaletNumbers(currentNode.ListColliders, goalList.ListColliders) == 0)
                  {
                        Debug.Log("reward OK !");
                        RewardPathFromEndToStart(currentNode, startNode);
                  }
                  else if (openList.Count == 0)
                  {
                        break;
                  }
                  else
                  {
                        if (IsCurrentNodeInTheList(currentNode, openList))
                        {
                              openList.Remove(currentNode);
                              closedList.Add(currentNode);
                        }

                        int nullPos = PossibleMooves.NullPosition(currentNode.ListColliders);
                        Debug.Log("------------------------BOUCLE ADJACENTS-------------------------- ");
                        foreach (List<Collider> adjList in PossibleMooves.ListOfMooves(inch, nullPos, currentNode.ListColliders))
                        {
                              Node currentNod = new Node(adjList);

                              if (IsCurrentNodeInTheList(currentNod, closedList))
                              {
                                    continue;
                              }
                              else if (!IsCurrentNodeInTheList(currentNod, openList))
                              {
                                    currentNod.G = currentNode.G + D;
                                    currentNod.H = CalculBadPaletNumbers(currentNod.ListColliders, goalList.ListColliders);
                                    currentNod.F = currentNod.G + currentNod.H;
                                    currentNod.Parent = currentNode;
                                    openList.Add(currentNod);
                              }
                              else if (IsCurrentNodeInTheList(currentNod, openList))
                              {
                                    MonoBehaviour.print("------------------------BOUCLE OPENLIST-------------------------- ");
                                    foreach (Node nodeInlist in openList)
                                    {
                                          if (nodeInlist == currentNod)
                                          {
                                                currentNod.G = currentNode.G + D;
                                                if (currentNod.G < nodeInlist.G)
                                                {
                                                      currentNod.H = CalculBadPaletNumbers(currentNod.ListColliders, goalList.ListColliders);
                                                      currentNod.F = currentNod.G + currentNod.H;
                                                      currentNod.Parent = currentNode;
                                                      openList.Remove(nodeInlist);
                                                      openList.Add(currentNod);
                                                }
                                          }
                                    }
                              }
                        }
                  }
            } while (CalculBadPaletNumbers(currentNode.ListColliders, goalList.ListColliders) != 0);
      }
}
  