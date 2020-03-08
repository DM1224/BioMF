﻿namespace QuickGraph.Algorithms
{
    public interface IVertexTimeStamperAlgorithm<TVertex,TEdge>
        where TEdge : IEdge<TVertex>
    {
        event VertexAction<TVertex> DiscoverVertex;
        event VertexAction<TVertex> FinishVertex;
    }
    public interface IVertexTimeStamperAlgorithm<TVertex>
    {
        event VertexAction<TVertex> DiscoverVertex;
        event VertexAction<TVertex> FinishVertex;
    }
}
