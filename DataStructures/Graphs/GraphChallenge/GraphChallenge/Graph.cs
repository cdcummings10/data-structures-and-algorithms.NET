using System;
using System.Collections.Generic;
using System.Text;

namespace GraphChallenge
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> newVertex = new Vertex<T>(value);
            AdjacencyList.Add(newVertex, new List<Edge<T>>());
            _size++;
            return newVertex;
        }
        public Edge<T> AddDirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            Edge<T> edge = new Edge<T>()
            {
                Vertex = destination,
                Weight = weight
            };
            AdjacencyList[source].Add(edge);
            return edge;
        }
        public void AddUndirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            AddDirectedEdge(source, destination, weight);
            AddDirectedEdge(destination, source, weight);
        }

        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();
            foreach(var item in AdjacencyList)
            {
                vertices.Add(item.Key)
            }
            return vertices;
        }

        public List<Edge<T>> GetAllNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        public int Size()
        {
            return _size;
        }
    }
}
