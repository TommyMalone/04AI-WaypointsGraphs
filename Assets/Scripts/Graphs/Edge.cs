using Graphs;

public class Edge
{
    public Node StartNode; 
    public Node EndNode;
    
    public Edge(Node from, Node to)
    {
        StartNode = from;
        EndNode = to;
    }
}
