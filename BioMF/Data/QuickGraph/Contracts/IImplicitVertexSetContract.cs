﻿using System.Diagnostics.Contracts;

namespace QuickGraph.Contracts
{
    [ContractClassFor(typeof(IImplicitVertexSet<>))]
    abstract class IImplicitVertexSetContract<TVertex>
        : IImplicitVertexSet<TVertex>
    {
        
        bool IImplicitVertexSet<TVertex>.ContainsVertex(TVertex vertex)
        {
            IImplicitVertexSet<TVertex> ithis = this;
            Contract.Requires(vertex != null);

            return default(bool);
        }
    }
}
