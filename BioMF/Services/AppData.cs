using System.Collections.Generic;
using System.Text;
using BlazorInputFile;
using ParaMODA.Impl;
using QuickGraph;

/// <summary>
/// This class is a singleton service meant to provide the data gathered from
/// the algorithm to all pages.
/// </summary>
namespace BioMF.Services
{
    public class AppData
    {
        public string[] Network { get; set; } //since we cant use system io, having a string of networks can start the process
        public int SubgraphSize { get; set; } = 3; //default value is 3

        public int NumLines { get; set; } = 0;

        public StringBuilder sb = new StringBuilder(""); //paramoda uses a stringbuilder for the output
        
        public List<string> SubgraphResults = new List<string>(); //Used to output in results
        public int Mappings { get; set; } = 0;
        public IFileListEntry NetworkFile { get; set; }
        public UndirectedGraph<int> InputGraph { get; set; }
        public Dictionary<QueryGraph, ICollection<Mapping>> FrequentSubgraphs { get; set; }
    }
}