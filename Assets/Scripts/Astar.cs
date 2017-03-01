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

      private Node SelectMinF(List<Node> list)
      {
            List<Node> listOrdered = list;
            bool IsFinish = false;

            //listOrdered = list.OrderBy(c => c.F).ToList();

            if (list.Count > 1)
            {
                  do
                  {
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                              if (list[i].F > list[i + 1].F)
                              {
                                    Node tmp = list[i];
                                    list[i] = list[i + 1];
                                    list[i + 1] = tmp;

                                    IsFinish = true;
                              }
                        }
                  } while (IsFinish == false);                
            }

            foreach (var elem in list)
                  Debug.Log("F value " + elem.F);
          
            return null;
      }

      private int Heuristic(List<Collider> currentList, List<Collider> goalList)
      {
            counter = 0;

            for (int i = 0; i < currentList.Count; i++)
            {
                  if (currentList[i] != goalList[i])
                        counter++;
            }          
        
            return counter;         
      }

      public Astar(Node currentList,Node goalList)
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

                  if (Heuristic(curList, list) == 0)
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

      private List<Node> RewardPathFromEndToStart(Node fromGoal,Node toStart)
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
            bool stop = false;
            Node startNode = openList[0];

            while (stop == false)
            {
                  Debug.Log("------------------------BOUCLE PRINCIPALE-------------------------- ");
                                    
                  Node currentNode = SelectMinF(openList);

                  if (Heuristic(currentNode.ListColliders, goalList.ListColliders) == 0)
                  {
                        RewardPathFromEndToStart(currentNode, startNode);
                        stop = true;
                  }
                  else if (openList.Count == 0)
                  {
                        stop = true;
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
                                    currentNod.H = Heuristic(currentNod.ListColliders, goalList.ListColliders);
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
                                                      currentNod.H = Heuristic(currentNod.ListColliders, goalList.ListColliders);
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
            }
                   
      }
}    

