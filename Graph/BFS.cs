using System;
using System.Collections.Generic;

public class Graph
{
    private int[,] adjacencyMatrix;
    private int numVertices;

    public Graph(int numVertices)
    {
        this.numVertices = numVertices;
        adjacencyMatrix = new int[numVertices, numVertices];
    }

    public void AddEdge(int source, int destination)
    {
        adjacencyMatrix[source, destination] = 1;
        // adjacencyMatrix[destination, source] = 1; // Assuming an undirected graph
    }

    public void Display()
    {
        Console.WriteLine("Adjacency Matrix Representation:");
        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                Console.Write(adjacencyMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void BFS(int startVertex)
    {
        bool[] visited = new bool[numVertices];

        Queue<int> queue = new Queue<int>();
        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count != 0)
        {
            int currentVertex = queue.Dequeue();
            Console.Write(currentVertex + " ");

            for (int i = 0; i < numVertices; i++)
            {
                if (adjacencyMatrix[currentVertex, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numVertices = 5;
        Graph graph = new Graph(numVertices);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 4);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);

        graph.Display();
        int startVertex = 0;
        Console.WriteLine("BFS Traversal:");
        graph.BFS(startVertex);
    }
}
