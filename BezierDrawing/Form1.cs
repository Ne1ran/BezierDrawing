using System.Net;
using System.Windows.Forms;

namespace BezierDrawing
{
    public partial class LinesDrawing : Form
    {
        private Graphics _drawGraphics = null!; // ������� ���������� ��� ������
        private Pen _pen = null!;
        private int _maxClicks; // ������������ ����� ������ ��� ����������

        private readonly List<Point> _currentPoints = new(); // ������ ������� �����

        public LinesDrawing() 
        {
            InitializeComponent();

            _drawGraphics = drawBox.CreateGraphics(); // ����� ������� �� PictureBox
            _maxClicks = 14; // ������ ������������ ���������� ������
        }

        private void closedLineButton_Click(object sender, EventArgs e) // ������ ��������� �������
        {
            var pointCounts = _currentPoints.Count; // ���� ����� ������ ����, �� �� ������
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor()); // ���������� ���� ��� ��������� � ������� Pen
            var firstPoint = _currentPoints[0]; // �.�. ����� ��������, �� ��������� � ����� ������ ������ �������
            var pointsList = _currentPoints;
            pointsList.Add(firstPoint);
            ConnectAndDrawLine(pointsList); // ������
            ClearClickPoints(); // ������ �����
        }

        private void unclosedLineButton_Click(object sender, EventArgs e) // ������ ����������� ��������
        {
            var pointCounts = _currentPoints.Count; // ��� �� �� �����, ��� � ����
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            ConnectAndDrawLine(_currentPoints); // ������ ����������� ��������
            ClearClickPoints();
        }

        private void closedCurveButton_Click(object sender, EventArgs e) // ������ ��������� ������
        {
            var pointCounts = _currentPoints.Count; // ����� ����� ������� 2 �����
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            float elasticity = 0f;
            float.TryParse(elasticityField.Text, out elasticity); // ������ ���� ���������. ���� �� ���������, �� ����� 0
            _drawGraphics.DrawClosedCurve(_pen, _currentPoints.ToArray(), elasticity, System.Drawing.Drawing2D.FillMode.Alternate); // ������ ������
            ClearClickPoints(); // ������ �����
        }

        private void unclosedCurveButton_Click(object sender, EventArgs e) // ������ ����������� ������
        {
            var pointCounts = _currentPoints.Count; // ����� ����� ������� 2 �����
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            float elasticity = 0f;
            float.TryParse(elasticityField.Text, out elasticity); // ������ ���� ���������. ���� �� ���������, �� ����� 0
            _drawGraphics.DrawCurve(_pen, _currentPoints.ToArray(), elasticity); // ������ ��������� ������
            ClearClickPoints();  // ������ �����
        }

        private void oneBezier_Click(object sender, EventArgs e) // ������ ���� ����� �����
        {
            var pointCounts = _currentPoints.Count; // ����� ��� ������ ���� ������� 4
            if (pointCounts < 4)
            {
                return;
            }

            Point startPoint = _currentPoints[0]; // ����� ����� �� ������
            Point controlPoint1 = _currentPoints[1];
            Point controlPoint2 = _currentPoints[2];
            Point endPoint = _currentPoints[3];
            _pen = new Pen(GenerateColor());

            _drawGraphics.DrawBezier(_pen,  startPoint, controlPoint1, controlPoint2, endPoint); // ������ ����� �����
            ClearClickPoints(); // ������ �����
        }

        private void closedBezier_Click(object sender, EventArgs e)
        {
            var pointCounts = _currentPoints.Count; // ����� ��� ������ ���� ������� 4 
            if (pointCounts < 4)
            {
                return;
            }

            _pen = new Pen(GenerateColor());

            var points = _currentPoints; // �.�. ����� ���������, �� ��������� ����� = ������
            points.Add(_currentPoints[0]);

            _drawGraphics.DrawBeziers(_pen, points.ToArray()); // ������ ����� �����
            ClearClickPoints(); // ������ �����
        }

        private void unclosedBezier_Click(object sender, EventArgs e)
        {
            var pointCounts = _currentPoints.Count; // ����� ��� ������ ���� ������� 4 
            if (pointCounts < 4)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            _drawGraphics.DrawBeziers(_pen, _currentPoints.ToArray()); // ������ ����� �����
            ClearClickPoints(); // ������ �����
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) // ��������� ����� �� PictureBox
        {
            if (_currentPoints.Count >= _maxClicks) // ���� ������ ������ ���������, �� ������ �� ������
            {
                return;
            }

            var click_x = e.X; // ����� ���������� ������
            var click_y = e.Y;
            _currentPoints.Add(new Point(click_x, click_y)); // ��������� ������ � ������
            UpdateClickLabel(); // ��������� ������ ������
        }

        private void cleanClickButton_Click(object sender, EventArgs e)
        {
            _drawGraphics.Clear(drawBox.BackColor); // ������ ���� �� ������� �� ������
            ClearClickPoints();
        }

        private void ClearClickPoints() // ������ ������ �����
        {
            _currentPoints.Clear();
            UpdateClickLabel();
        }

        private Color GenerateColor() // ���������� ����
        {
            Random random = new Random();
            var r = random.Next(0, 255);
            var g = random.Next(0, 255);
            var b = random.Next(0, 255);
            return Color.FromArgb(r, g, b);
        }

        private void UpdateClickLabel() // ��������� ������ ������
        {
            var text = string.Empty;
            foreach (var point in _currentPoints) 
            {
                var str = $"X = {point.X}, Y = {point.Y};\n"; // ��������� ������ � Enter
                text += str;
            }

            clicksLabel.Text = text;
        }

        private void ConnectAndDrawLine(List<Point> points) // ������ �������� ����� �� ������ 
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                Point point1 = points[i];
                Point point2 = points[i + 1];
                _drawGraphics.DrawLine(_pen, point1, point2);
            }
        }
    }
}
