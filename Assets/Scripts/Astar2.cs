using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Astar2
{
      private int D;
      private Node currentNode;
      private List<Node> openList;
      private List<Node> closedList;
      private Node goal;
      private int inch;
      private int counter;

      private List<Node> SortMinToMaxF(List<Node> list)
      {
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

            return list;
      }

      private int NumberOfDifferences(List<Collider> currentList, List<Collider> goalList)
      {
            counter = 0;

            for (int i = 0; i < currentList.Count; i++)
            {
                  if (currentList[i] != goalList[i])
                        counter++;
            }

            return counter;
      }

      public Astar2(Node start, Node goal)
      {
            inch = start.ListColliders.Count;
            D = 1;

            this.goal = new Node(goal.ListColliders);
            this.goal.F = 0;
            this.goal.F = 0;
            this.goal.H = 0;
            this.goal.Parent = null;
           
            currentNode = new Node(start.ListColliders);
            currentNode.G = 0;
            currentNode.H = NumberOfDifferences(start.ListColliders, goal.ListColliders);
            currentNode.F = 0;
            currentNode.Parent = null;

            openList = new List<Node>();
            closedList = new List<Node>();
         
            closedList.Add(currentNode);
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

                  if (NumberOfDifferences(curList, list) == 0)
                        equal = true;
                  else
                        equal = false;
            }

            return equal;
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

      public void Search()
      {             
           do
           {
                  int nullPos = PossibleMooves.NullPosition(currentNode.ListColliders);

                  foreach(List<Collider> subList in PossibleMooves.ListOfMooves(inch, nullPos, currentNode.ListColliders))
                  {
                        Node nodeAdj = new Node(subList);

                        if (IsCurrentNodeInTheList(nodeAdj, closedList))
                        {
                              continue;
                        }
                        else if (IsCurrentNodeInTheList(currentNode, openList))
                        {                            
                              foreach (Node nodeInlist in openList)
                              {
                                    if (nodeInlist == nodeAdj)
                                    {
                                          nodeAdj.G = currentNode.G + D;
                                          if (nodeAdj.G < nodeInlist.G)
                                          {
                                                nodeAdj.H = NumberOfDifferences(nodeAdj.ListColliders, goal.ListColliders);
                                                nodeAdj.F = nodeAdj.G + nodeAdj.H;
                                                nodeAdj.Parent = currentNode;
                                                openList.Remove(nodeInlist);
                                                openList.Add(nodeAdj);
                                          }
                                    }
                              }                                                           
                        }
                        else
                        {
                              nodeAdj.G = currentNode.G + D;
                              nodeAdj.H = NumberOfDifferences(nodeAdj.ListColliders, goal.ListColliders);
                              nodeAdj.F = nodeAdj.G + nodeAdj.H;
                              nodeAdj.Parent = currentNode;
                              openList.Add(nodeAdj);
                        }
                  }

                  if (openList.Count == 0)
                  {
                        break;
                  }
     
                  SortMinToMaxF(openList);                       
                  currentNode = openList[0];                                     

                  openList.RemoveAt(0);
                  closedList.Add(currentNode);

            } while (NumberOfDifferences(currentNode.ListColliders, goal.ListColliders) != 0);
      }
}
