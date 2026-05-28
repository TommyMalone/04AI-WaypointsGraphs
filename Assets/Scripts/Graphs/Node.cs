using System.Collections.Generic;
using UnityEngine;

namespace Graphs
{
    public class Node
    {
        public List<Edge> Edges = new List<Edge>();
        public Node Path = null;
        private GameObject _id;


        public float f, g, h;
        public Node CameFrom;
    
        public Node(GameObject id)
        {
            _id = id;
        }
    
        public GameObject GetId()
        {
            return _id;
        }

    }
}
