using System;

public class DijkstraAlgorithm
{
    private int numVertices;
    private int[,] adjacencyMatrix;

    public DijkstraAlgorithm(int numVertices)
    {
        this.numVertices = numVertices;
        adjacencyMatrix = new int[numVertices, numVertices];
    }

    public void AddEdge(int source, int destination, int weight)
    {
        adjacencyMatrix[source, destination] = weight;
    }

    public void Dijkstra(int source)
    {
        int[] distance = new int[numVertices];
        bool[] shortestPathTreeSet = new bool[numVertices];

        for (int i = 0; i < numVertices; i++)
        {
            distance[i] = int.MaxValue;
            shortestPathTreeSet[i] = false;
        }

        distance[source] = 0;

        for (int count = 0; count < numVertices - 1; count++)
        {
            int u = MinimumDistanceVertex(distance, shortestPathTreeSet);
            shortestPathTreeSet[u] = true;

            for (int v = 0; v < numVertices; v++)
            {
                if (!shortestPathTreeSet[v] && adjacencyMatrix[u, v] != 0 &&
                    distance[u] != int.MaxValue && distance[u] + adjacencyMatrix[u, v] < distance[v])
                {
                    distance[v] = distance[u] + adjacencyMatrix[u, v];
                }
            }
        }

        PrintSolution(distance);
    }

    private int MinimumDistanceVertex(int[] distance, bool[] shortestPathTreeSet)
    {
        int minDistance = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < numVertices; v++)
        {
            if (!shortestPathTreeSet[v] && distance[v] <= minDistance)
            {
                minDistance = distance[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] distance)
    {
        Console.WriteLine("Vertex \t Distance from Source");
        for (int i = 0; i < numVertices; i++)
        {
            Console.WriteLine("\t" + i + " \t\t\t " + distance[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numVertices = 6;
        DijkstraAlgorithm dijkstra = new DijkstraAlgorithm(numVertices);

        dijkstra.AddEdge(0, 1, 4);
        dijkstra.AddEdge(0, 2, 8);
        dijkstra.AddEdge(1, 2, 1);
        dijkstra.AddEdge(1, 3, 3);
        dijkstra.AddEdge(2, 3, 1);
        dijkstra.AddEdge(3, 4, 7);
        dijkstra.AddEdge(4, 5, 2);
        dijkstra.AddEdge(2, 4, 2);

        int source = 0;
        Console.WriteLine($"Shortest distances from source vertex {source} using Dijkstra's algorithm:");
        dijkstra.Dijkstra(source);
    }
}
