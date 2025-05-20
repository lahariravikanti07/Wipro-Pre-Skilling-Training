using System;

class Dijkstra
{
    static int V;

    // Find the vertex with the minimum distance value
    static int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    // Print the shortest path from source to j using parent[]
    static void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1)
        {
            Console.Write(j + " ");
            return;
        }

        PrintPath(parent, parent[j]);
        Console.Write(j + " ");
    }

    // Print distances and paths
    static void PrintSolution(int[] dist, int[] parent, int src)
    {
        Console.WriteLine("Vertex\t Distance\tPath");
        for (int i = 0; i < V; i++)
        {
            Console.Write($"{src} -> {i}\t {dist[i]}\t\t");
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }

    // Dijkstra’s algorithm
    static void DijkstraAlgo(int[,] graph, int src)
    {
        int[] dist = new int[V]; // Shortest distances from src
        bool[] visited = new bool[V]; // Visited vertices
        int[] parent = new int[V]; // To store paths

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    parent[v] = u;
                }
            }
        }

        PrintSolution(dist, parent, src);
    }

    // Main method with test case
    static void Main()
    {
        Console.Write("Enter number of vertices: ");
        V = int.Parse(Console.ReadLine());

        int[,] graph = new int[V, V];
        Console.WriteLine("Enter the adjacency matrix (row by row):");

        for (int i = 0; i < V; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < V; j++)
            {
                graph[i, j] = int.Parse(row[j]);
            }
        }

        Console.Write("Enter the source vertex (0 to {0}): ", V - 1);
        int src = int.Parse(Console.ReadLine());

        DijkstraAlgo(graph, src);
    }
}
