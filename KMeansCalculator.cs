using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k_means.DataClasses;

namespace k_means
{
    internal class KMeansCalculator
    {
        private List<Sample> samples;
        private List<Cluster> clusters;
        private double? prevWCSS;
        private double? WCSS;
        private bool IsAlgorithmDone;

        public KMeansCalculator()
        {
            samples = new List<Sample>();
            clusters = new List<Cluster>();
            ResetAlgorithm();
        }

        public void AddSample(Sample sample)
        {
            ResetAlgorithm();
            samples.Add(sample);
        }

        public void AddCluster(Cluster cluster) 
        {
            ResetAlgorithm();
            clusters.Add(cluster);
        }

        public int GetNextClusterId()
        {
            return clusters.Count + 1;
        }

        public List<Sample> GetSamples()
        {
            return new List<Sample>(samples);
        }

        public List<Cluster> GetClusters() 
        {
            return new List<Cluster>(clusters);
        }

        public void RemoveSamples()
        {
            ResetAlgorithm();
            samples.Clear();
        }

        public void RemoveClusters() 
        {
            ResetAlgorithm();
            clusters.Clear();
        }

        public int GetClustersCount()
        {
            return clusters.Count();
        }

        public int GetSamplesCount()
        {
            return samples.Count();
        }

        private double CalculateDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y,2));
        }

        public string DoNextStep() 
        {
            if (!IsAlgorithmDone)
            {
                if (samples.Any(x => x.ClusterID == null))
                {
                    CalculateClusters();
                    return "Вычеслены кластеры";
                }
                if (samples.All(x => x.ClusterID != null))
                {
                    CalculateNewCentroids();
                    CalculateWCSS();
                    SetAlgorithmStatus();
                    return "Вычислены новые центроиды\nИ вычислен WCSS";
                }
            }
            return "Алгоритм закончил работу";
        }

        public double? getWCSS()
        {
            return WCSS;
        }

        private void CalculateClusters()
        {
            foreach (var sample in samples)
            {
                FindNearCluster(sample);
            }
        }

        private void FindNearCluster(Sample sample)
        {
            if (clusters.Count == 0)
                return;

            var minDistance = clusters.Min(x => CalculateDistance(x.Position, sample.Position));

            foreach (var cluster in clusters) 
            { 
                if (CalculateDistance(cluster.Position, sample.Position) == minDistance)
                {
                    sample.Color = cluster.Color;
                    sample.ClusterID = cluster.Id;
                }
            }
        }

        private void CalculateNewCentroids() 
        {
            foreach (var cluster in clusters) 
            {
                FindNewCentroid(cluster);
            }
        }

        private void FindNewCentroid(Cluster cluster)
        {
            var samplesInCluster = samples.Where(x => x.ClusterID == cluster.Id).ToList();
            if (samplesInCluster.Count == 0)
                return;

            cluster.Position = new Point
            {
                X = samplesInCluster.Sum(x => x.Position.X) / samplesInCluster.Count,
                Y = samplesInCluster.Sum(x => x.Position.Y) / samplesInCluster.Count,
            };
        }

        private void CalculateWCSS()
        {
            prevWCSS = WCSS;
            WCSS = 0;

            foreach (var cluster in clusters)
            {
                WCSS += CalculateWCSSInCluster(cluster);
            }

            samples.Select(x => { x.ClusterID = null; return x; }).ToList();
        }

        private double CalculateWCSSInCluster(Cluster cluster)
        {
            var result = 0.0;
            var samplesInCluster = samples.Where(x => x.ClusterID == cluster.Id).ToList();

            foreach (var sample in samplesInCluster)
            {
                result += Math.Pow(sample.Position.X - cluster.Position.X, 2) + Math.Pow(sample.Position.Y - cluster.Position.Y, 2);
            }
            return result;
        }

        private void ResetAlgorithm()
        {
            WCSS = null;
            prevWCSS = null;
            IsAlgorithmDone = false;
        }

        private void SetAlgorithmStatus()
        {
            if (WCSS == null || prevWCSS == null)
            {
                IsAlgorithmDone = false;
                return;
            }

            IsAlgorithmDone = WCSS == prevWCSS;
        }

        public bool GetAlgorithmStatus()
        {
            return IsAlgorithmDone;
        }
    }
}
