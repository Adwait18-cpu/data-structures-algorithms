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

    public void vertexWiseDisplay(){
        Console.WriteLine("Adjacency Matrix Representation:");

        for (int i = 0; i < numVertices; i++)
        {
            Console.WriteLine("Adjacent Elements of Vetex {0}: ", i);
            for (int j = 0; j < numVertices; j++)
            {
                if (adjacencyMatrix[i][j] == 1)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
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

        graph.vertexWiseDisplay();
    }
}
