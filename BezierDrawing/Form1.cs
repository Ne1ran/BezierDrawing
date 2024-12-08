using System.Net;
using System.Windows.Forms;

namespace BezierDrawing
{
    public partial class LinesDrawing : Form
    {
        private Graphics _drawGraphics = null!; // Базовые компоненты для работы
        private Pen _pen = null!;
        private int _maxClicks; // Максимальное число кликов для считывания

        private readonly List<Point> _currentPoints = new(); // Список текущих строк

        public LinesDrawing() 
        {
            InitializeComponent();

            _drawGraphics = drawBox.CreateGraphics(); // Берем графику из PictureBox
            _maxClicks = 14; // Задаем максимальное количество кликов
        }

        private void closedLineButton_Click(object sender, EventArgs e) // Рисуем замкнутую ломаную
        {
            var pointCounts = _currentPoints.Count; // Если точек меньше двух, то не рисуем
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor()); // Генерируем цвет для рисования и создаем Pen
            var firstPoint = _currentPoints[0]; // Т.к. линия замкнута, то добавляем в конец списка первый элемент
            var pointsList = _currentPoints;
            pointsList.Add(firstPoint);
            ConnectAndDrawLine(pointsList); // Рисуем
            ClearClickPoints(); // Чистим клики
        }

        private void unclosedLineButton_Click(object sender, EventArgs e) // Рисуем незамкнутую ломанную
        {
            var pointCounts = _currentPoints.Count; // Все то же самое, что и выше
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            ConnectAndDrawLine(_currentPoints); // Рисуем незамкнутую ломанную
            ClearClickPoints();
        }

        private void closedCurveButton_Click(object sender, EventArgs e) // Рисуем замкнутый сплайн
        {
            var pointCounts = _currentPoints.Count; // Также нужно минимум 2 точки
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            float elasticity = 0f;
            float.TryParse(elasticityField.Text, out elasticity); // Парсим поле упругости. Если не получится, то будет 0
            _drawGraphics.DrawClosedCurve(_pen, _currentPoints.ToArray(), elasticity, System.Drawing.Drawing2D.FillMode.Alternate); // Рисуем сплайн
            ClearClickPoints(); // Чистим точки
        }

        private void unclosedCurveButton_Click(object sender, EventArgs e) // Рисуем незамкнутый сплайн
        {
            var pointCounts = _currentPoints.Count; // Также нужно минимум 2 точки
            if (pointCounts < 2)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            float elasticity = 0f;
            float.TryParse(elasticityField.Text, out elasticity); // Парсим поле упругости. Если не получится, то будет 0
            _drawGraphics.DrawCurve(_pen, _currentPoints.ToArray(), elasticity); // Рисуем замкнутый сплайн
            ClearClickPoints();  // Чистим точки
        }

        private void oneBezier_Click(object sender, EventArgs e) // Рисуем одну линию Безье
        {
            var pointCounts = _currentPoints.Count; // Точек уже должно быть минимум 4
            if (pointCounts < 4)
            {
                return;
            }

            Point startPoint = _currentPoints[0]; // Берем точки из списка
            Point controlPoint1 = _currentPoints[1];
            Point controlPoint2 = _currentPoints[2];
            Point endPoint = _currentPoints[3];
            _pen = new Pen(GenerateColor());

            _drawGraphics.DrawBezier(_pen,  startPoint, controlPoint1, controlPoint2, endPoint); // Рисуем линию Безье
            ClearClickPoints(); // Чистим точки
        }

        private void closedBezier_Click(object sender, EventArgs e)
        {
            var pointCounts = _currentPoints.Count; // Точек уже должно быть минимум 4 
            if (pointCounts < 4)
            {
                return;
            }

            _pen = new Pen(GenerateColor());

            var points = _currentPoints; // Т.к. линия замкнутая, то последняя точка = первой
            points.Add(_currentPoints[0]);

            _drawGraphics.DrawBeziers(_pen, points.ToArray()); // Рисуем линию Безье
            ClearClickPoints(); // Чистим точки
        }

        private void unclosedBezier_Click(object sender, EventArgs e)
        {
            var pointCounts = _currentPoints.Count; // Точек уже должно быть минимум 4 
            if (pointCounts < 4)
            {
                return;
            }

            _pen = new Pen(GenerateColor());
            _drawGraphics.DrawBeziers(_pen, _currentPoints.ToArray()); // Рисуем линию Безье
            ClearClickPoints(); // Чистим точки
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) // Считываем клики по PictureBox
        {
            if (_currentPoints.Count >= _maxClicks) // Если список больше максимума, то ничего не делаем
            {
                return;
            }

            var click_x = e.X; // Берем координаты кликов
            var click_y = e.Y;
            _currentPoints.Add(new Point(click_x, click_y)); // Добавляем поинты в список
            UpdateClickLabel(); // Обновляем панель вывода
        }

        private void cleanClickButton_Click(object sender, EventArgs e)
        {
            _drawGraphics.Clear(drawBox.BackColor); // Чистим поле по нажатию на кнопку
            ClearClickPoints();
        }

        private void ClearClickPoints() // Чистим только клики
        {
            _currentPoints.Clear();
            UpdateClickLabel();
        }

        private Color GenerateColor() // Генерируем цвет
        {
            Random random = new Random();
            var r = random.Next(0, 255);
            var g = random.Next(0, 255);
            var b = random.Next(0, 255);
            return Color.FromArgb(r, g, b);
        }

        private void UpdateClickLabel() // Обновляем текста кликов
        {
            var text = string.Empty;
            foreach (var point in _currentPoints) 
            {
                var str = $"X = {point.X}, Y = {point.Y};\n"; // Добавляем строку и Enter
                text += str;
            }

            clicksLabel.Text = text;
        }

        private void ConnectAndDrawLine(List<Point> points) // Рисуем ломанную линию по точкам 
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
