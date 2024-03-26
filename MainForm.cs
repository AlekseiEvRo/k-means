using k_means.DataClasses;
using System.Drawing;
using System.Windows.Forms;

namespace k_means
{
    public partial class MainForm : Form
    {
        private KMeansCalculator _kMeansCalculator;
        private int _width = 10;
        private int _height = 10;
        private Color _backgroundColor = Color.Gray;

        public MainForm()
        {
            InitializeComponent();
            _kMeansCalculator = new KMeansCalculator();

            if (pictureBox1.Image == null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(_backgroundColor);
                }
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CreateNewPoint(e.Location);
            }

            if (e.Button == MouseButtons.Right)
            {
                CreateNewCluster(e.Location);
            }
        }

        private void Draw—ircle(Point location, Color Brushcolor, Color penColor)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                var brush = new SolidBrush(Brushcolor);
                var pen = new Pen(penColor);

                g.FillEllipse(brush, location.X - _width / 2, location.Y - _height / 2, _width, _height);
                g.DrawEllipse(pen, location.X - _width / 2, location.Y - _height / 2, _width, _height);

                brush.Dispose();
                pen.Dispose();
                pictureBox1.Invalidate();
            }
        }

        private void DrawCross(Point location, Color color)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                var pen = new Pen(color, 3);

                var topLeft = new Point(location.X - _width / 2, location.Y - _height / 2);
                var bottomRight = new Point(location.X + _width / 2 , location.Y + _height / 2);
                var topRight = new Point(location.X + _width / 2, location.Y - _height / 2);
                var bottomLeft = new Point(location.X - _width / 2, location.Y + _height / 2);

                g.DrawLine(pen, topLeft, bottomRight);
                g.DrawLine(pen, bottomLeft, topRight);

                pictureBox1.Invalidate();
                pen.Dispose();
            }
        }

        private void ClearPoints()
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                var points = _kMeansCalculator.GetSamples().ToList();

                foreach (var point in points)
                {
                    Draw—ircle(point.Position, _backgroundColor, _backgroundColor);
                }

                pictureBox1.Invalidate();
            }
        }

        private void ClearClusters()
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                var crosses = _kMeansCalculator.GetClusters().ToList();

                foreach (var cross in crosses)
                {
                    DrawCross(cross.Position, _backgroundColor);
                }
            }
        }

        private void ClearPointsButton_Click(object sender, EventArgs e)
        {
            ClearPoints();
            _kMeansCalculator.RemoveSamples();
            PointsCountLabel.Text = _kMeansCalculator.GetSamplesCount().ToString();
        }

        private void ClearClustersButton_Click(object sender, EventArgs e)
        {
            ClearClusters();
            _kMeansCalculator.RemoveClusters();
            ClustersCountLabel.Text = _kMeansCalculator.GetClustersCount().ToString();
        }

        private void SetPoinstAutomaticallyButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            var pointsCount = r.Next(10, 30);
            for (int i = 0; i < pointsCount; i++)
            {
                var location = new Point
                {
                    X = r.Next(Convert.ToInt32(pictureBox1.Width * 0.1), Convert.ToInt32(pictureBox1.Width * 0.9)),
                    Y = r.Next(Convert.ToInt32(pictureBox1.Height * 0.1), Convert.ToInt32(pictureBox1.Height * 0.9)),
                };

                CreateNewPoint(location);
            }
        }

        private void SetClustersAutomatically_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            var clusterCount = r.Next(1, 5);
            for (int i = 0; i < clusterCount; i++)
            {
                var location = new Point
                {
                    X = r.Next(Convert.ToInt32(pictureBox1.Width * 0.1), Convert.ToInt32(pictureBox1.Width * 0.9)),
                    Y = r.Next(Convert.ToInt32(pictureBox1.Height * 0.1), Convert.ToInt32(pictureBox1.Height * 0.9)),
                };

                CreateNewCluster(location);
            }
        }

        private void CreateNewPoint(Point location)
        {
            var sample = new Sample
            {
                Position = location,
                Color = Color.White,
                ClusterID = null
            };
            _kMeansCalculator.AddSample(sample);
            PointsCountLabel.Text = _kMeansCalculator.GetSamplesCount().ToString();
            this.Draw—ircle(location, sample.Color, Color.Black);
        }

        private void CreateNewCluster(Point location)
        {
            Random r = new Random();
            var cluster = new Cluster
            {
                Id = _kMeansCalculator.GetNextClusterId(),
                //TODO ÔÓ‡·ÓÚ‡Ú¸ Ò „ÂÌÂ‡ˆËÂÈ ˆ‚ÂÚÓ‚, Ì‡ ·ÂÎÓÏ ÙÓÌÂ ÌÂÍÓÚÓ˚Â ˆ‚ÂÚ‡ Ó˜ÂÌ¸ ÔÓıÓÊË
                Color = Color.FromArgb(255, r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)),
                Position = location,
            };
            _kMeansCalculator.AddCluster(cluster);
            ClustersCountLabel.Text = _kMeansCalculator.GetClustersCount().ToString();
            this.DrawCross(location, cluster.Color);
        }

        private void RunStepButton_Click(object sender, EventArgs e)
        {
            ClearPoints();
            ClearClusters();

            Status.Text = _kMeansCalculator.DoNextStep();
            WCSSLabel.Text = _kMeansCalculator.getWCSS().ToString();

            foreach (var sample in _kMeansCalculator.GetSamples())
            {
                this.Draw—ircle(sample.Position, sample.Color, Color.Black);
            }

            foreach (var cluster in _kMeansCalculator.GetClusters())
            {
                this.DrawCross(cluster.Position, cluster.Color);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            ClearPoints();
            ClearClusters();

            while (!_kMeansCalculator.GetAlgorithmStatus()) 
            {
                _kMeansCalculator.DoNextStep();
            }
            WCSSLabel.Text = _kMeansCalculator.getWCSS().ToString();
            Status.Text = "¿Î„ÓËÚÏ Á‡ÍÓÌ˜ËÎ ‡·ÓÚÛ";


            foreach (var sample in _kMeansCalculator.GetSamples())
            {
                this.Draw—ircle(sample.Position, sample.Color, Color.Black);
            }

            foreach (var cluster in _kMeansCalculator.GetClusters())
            {
                this.DrawCross(cluster.Position, cluster.Color);
            }
        }
    }
}