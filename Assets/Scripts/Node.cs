using UnityEngine;
using System.Collections.Generic;

public class Node
{
      private List<Collider> listColliders;
      private int g;
      private int h;
      private int f;
      private Node parent;

      public List<Collider> ListColliders { get { return listColliders; } set { this.listColliders = value; } }
      public int F { get { return f; } set { f = value; } }
      public int G { get { return g; } set { g = value; } }
      public int H { get { return h; } set { h = value; } }    
      public Node Parent { get { return parent; } set { parent = value; } }

      public Node(List<Collider> listColliders)
      {
            this.listColliders = listColliders;
            this.G = 0;
            this.H = 0;
            this.F = this.G + this.H;
            this.Parent = null;
      }      
}
