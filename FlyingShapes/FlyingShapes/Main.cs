namespace FlyingShapes
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    using FlyingShapes.Logic;
    using FlyingShapes.Models;

    public partial class Main : Form
    {
        private readonly ShapeManager shapeManager;

        private readonly TreeNode shapeNode;

        private Thread myThread;

        public Main()
        {
            shapeManager = new ShapeManager();
            InitializeComponent();
            InitializeTreeView();
            mainTimer.Start();
            shapeNode = mainTreeView.Nodes[0];
            mainTreeView.ExpandAll();
            myThread = new Thread(MoveShapes);
            myThread.Start();

            while (!myThread.IsAlive)
            {
            }
        }

        private void AddCircleBtnClick(object sender, EventArgs e)
        {
            var circle = new Circle();
            AddShape(circle);
        }

        private void AddEventBtnClick(object sender, EventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;

            if (selectedNode == null | shapeNode.IsSelected)
            {
                shapeManager.AddKickEvent();
            }
            else if (shapeNode.Nodes.Contains(selectedNode))
            {
                var shapes = shapeManager.GetShapes(selectedNode.Text);
                shapeManager.AddKickEvent(shapes);
            }
            else
            {
                var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);
                shapeManager.AddKickEvent(shape);
            }
        }

        private void AddRectangleBtnClick(object sender, EventArgs e)
        {
            var rectangle = new Square();
            AddShape(rectangle);
        }

        private void AddShape<T>(T shape) where T : Shape
        {
            shapeManager.AddShape(shape, mainPicBox);
            mainPicBox.Invalidate();
            AddShapeToTreeView(shape);
            mainTreeView.ExpandAll();
        }

        private void AddShapeToTreeView<T>(T shape) where T : Shape
        {
            InitializeTreeView();

            var node = new TreeNode(Text = shape.GetType().Name)
                           {
                               ForeColor = shape.Color, 
                               NodeFont =
                                   new Font(
                                   "Microsoft Sans Serif", 
                                   8, 
                                   FontStyle.Regular)
                           };

            switch (shape.GetType().Name)
            {
                case "Square":
                    mainTreeView.Nodes[0].Nodes[0].Nodes.Add(node);
                    break;
                case "Triangle":
                    mainTreeView.Nodes[0].Nodes[1].Nodes.Add(node);
                    break;
                case "Circle":
                    mainTreeView.Nodes[0].Nodes[2].Nodes.Add(node);
                    break;
            }

            mainTreeView.ExpandAll();
        }

        private void AddTriangleBtnClick(object sender, EventArgs e)
        {
            var triangle = new Triangle();
            AddShape(triangle);
        }

        private void BackwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(-5);
            ShowPauseButton();
        }

        private void ChangeLanguage(string lang)
        {
            var resources = new ComponentResourceManager(GetType());
            foreach (Control control in Controls)
            {
                resources.ApplyResources(control, control.Name, new CultureInfo(lang));
            }
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;

            if (selectedNode == null | shapeNode.IsSelected)
            {
                shapeNode.Nodes.Cast<TreeNode>().ToList().ForEach(n => n.Nodes.Clear());
                shapeManager.RemoveShapes();
            }
            else if (shapeNode.Nodes.Contains(selectedNode))
            {
                selectedNode.Nodes.Clear();
                shapeManager.RemoveShapes(selectedNode.Text);
            }
            else
            {
                var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);
                mainTreeView.Nodes.Remove(selectedNode);
                shapeManager.RemoveShape(shape);
            }

            mainPicBox.Refresh();
        }

        private void FastBackwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(-10);
            ShowPauseButton();
        }

        private void FastForwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(10);
            ShowPauseButton();
        }

        private void ForwardBtnClick(object sender, EventArgs e)
        {
            mainTimer.Start();
            shapeManager.ChangeShapesSpeed(5);
            ShowPauseButton();
        }

        private void InitializeTreeView()
        {
            if (mainTreeView.Nodes.Count == 0)
            {
                mainTreeView.Nodes.Add(new TreeNode("Shapes"));
                mainTreeView.Nodes[0].Nodes.Add(new TreeNode("Squares"));
                mainTreeView.Nodes[0].Nodes.Add(new TreeNode("Triangles"));
                mainTreeView.Nodes[0].Nodes.Add(new TreeNode("Circles"));

                mainTreeView.ExpandAll();
            }
        }

        private void LangBtnClick(object sender, EventArgs e)
        {
            langLabel.Visible = false;
            langListBox.Visible = true;
        }

        private void LangListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLanguageIndex = langListBox.SelectedIndex;

            switch (selectedLanguageIndex)
            {
                case 0:
                    ChangeLanguage("en");
                    break;
                case 1:
                    ChangeLanguage("ru");
                    break;
                case 2:
                    ChangeLanguage("uk");
                    break;
                default:
                    ChangeLanguage("en");
                    break;
            }

            langLabel.Visible = true;
            langListBox.Visible = false;
        }

        private void LoadBtnClick(object sender, EventArgs e)
        {
            var shapes = ShapeSerializer.DeserializeFromBinary();

            // var shapes = ShapeSerializer.DeserializeFromXml();
            // var shapes = ShapeSerializer.DeserializeFromJson();
            shapeManager.ShapeList = shapes;
            mainTreeView.Nodes.Clear();
            shapes.ForEach(AddShapeToTreeView);
            mainPicBox.Invalidate();
        }

        private void MainPicBoxPaint(object sender, PaintEventArgs e)
        {
            shapeManager.DrawShapes(e.Graphics);
        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            mainPicBox.Invalidate();
        }

        private void MainTreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = mainTreeView.SelectedNode;
            shapeManager.UnfillShapes();

            if (selectedNode == null | shapeNode.IsSelected)
            {
                shapeManager.FillShapes();
            }
            else if (shapeNode.Nodes.Contains(selectedNode))
            {
                shapeManager.FillShapes(selectedNode.Text);
            }
            else
            {
                var shape = shapeManager.GetShape(selectedNode.Parent.Text, selectedNode.Index);
                shapeManager.FillShape(shape);
            }

            mainPicBox.Refresh();
        }

        private void MoveShapes()
        {
            while (!playBtn.Visible)
            {
                shapeManager.MoveShapes(mainPicBox);
                Thread.Sleep(10);
            }
        }

        private void PauseBtnClick(object sender, EventArgs e)
        {
            mainTimer.Stop();
            ShowPlayButton();
            myThread?.Abort();
        }

        private void PlayBtnClick(object sender, EventArgs e)
        {
            myThread = new Thread(MoveShapes);
            mainTimer.Start();
            ShowPauseButton();

            myThread.Start();

            while (!myThread.IsAlive)
            {
            }
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            var shapes = shapeManager.ShapeList;
            ShapeSerializer.SerializeToBinary(shapes);
            ShapeSerializer.SerializeToXml(shapes);
            ShapeSerializer.SerializeToJson(shapes);
        }

        private void ShowPauseButton()
        {
            playBtn.Visible = false;
            playLabel.Visible = false;
            pauseBtn.Visible = true;
            pauseLabel.Visible = true;
        }

        private void ShowPlayButton()
        {
            playBtn.Visible = true;
            playLabel.Visible = true;
            pauseBtn.Visible = false;
            pauseLabel.Visible = false;
        }
    }
}