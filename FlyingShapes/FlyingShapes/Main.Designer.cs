namespace FlyingShapes
{
    using System.ComponentModel;
    using System.Windows.Forms;

    partial class Main
    {
        private PictureBox mainPicBox;
        private Button pauseBtn;
        private Button addRectangleBtn;
        private Button addTriangleBtn;
        private Button addCircleBtn;
        private Timer mainTimer;
        private Button clearBtn;
        private Button playBtn;
        private Button forwardBtn;
        private Button backwardBtn;
        private Button fastBackwardBtn;
        private Button fastForwardBtn;
        private Button saveBtn;
        private Button loadBtn;
        private BackgroundWorker backgroundWorker1;
        private Label saveLabel;
        private Label loadLabel;
        private Label squareLabel;
        private Label triangleLabel;
        private Label circleLabel;
        private Label fBackwardlabel;
        private Label backwardLabel;
        private Label playLabel;
        private Label forwardLabel;
        private Label fForwardLabel;
        private Label pauseLabel;
        private Label deleteLabel;
        private BindingSource bindingSource1;
        private Button langBtn;
        private ListBox langListBox;
        private Label langLabel;
        private GroupBox shapeGroupBox;
        private GroupBox fileGroupBox;
        private GroupBox playbeckGroupBox;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainPicBox = new System.Windows.Forms.PictureBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.addRectangleBtn = new System.Windows.Forms.Button();
            this.addTriangleBtn = new System.Windows.Forms.Button();
            this.addCircleBtn = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backwardBtn = new System.Windows.Forms.Button();
            this.fastBackwardBtn = new System.Windows.Forms.Button();
            this.fastForwardBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.triangleLabel = new System.Windows.Forms.Label();
            this.circleLabel = new System.Windows.Forms.Label();
            this.fBackwardlabel = new System.Windows.Forms.Label();
            this.backwardLabel = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.forwardLabel = new System.Windows.Forms.Label();
            this.fForwardLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.langBtn = new System.Windows.Forms.Button();
            this.langListBox = new System.Windows.Forms.ListBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.shapeGroupBox = new System.Windows.Forms.GroupBox();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.playbeckGroupBox = new System.Windows.Forms.GroupBox();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.removeEventLabel = new System.Windows.Forms.Label();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.evntGroupBox = new System.Windows.Forms.GroupBox();
            this.addEventLabel = new System.Windows.Forms.Label();
            this.removeEventBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.evntGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPicBox
            // 
            resources.ApplyResources(this.mainPicBox, "mainPicBox");
            this.mainPicBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainPicBox.Name = "mainPicBox";
            this.mainPicBox.TabStop = false;
            this.mainPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPicBoxPaint);
            // 
            // pauseBtn
            // 
            resources.ApplyResources(this.pauseBtn, "pauseBtn");
            this.pauseBtn.FlatAppearance.BorderSize = 0;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.PauseBtnClick);
            // 
            // addRectangleBtn
            // 
            resources.ApplyResources(this.addRectangleBtn, "addRectangleBtn");
            this.addRectangleBtn.FlatAppearance.BorderSize = 0;
            this.addRectangleBtn.Name = "addRectangleBtn";
            this.addRectangleBtn.UseVisualStyleBackColor = true;
            this.addRectangleBtn.Click += new System.EventHandler(this.AddRectangleBtnClick);
            // 
            // addTriangleBtn
            // 
            resources.ApplyResources(this.addTriangleBtn, "addTriangleBtn");
            this.addTriangleBtn.FlatAppearance.BorderSize = 0;
            this.addTriangleBtn.Name = "addTriangleBtn";
            this.addTriangleBtn.UseVisualStyleBackColor = true;
            this.addTriangleBtn.Click += new System.EventHandler(this.AddTriangleBtnClick);
            // 
            // addCircleBtn
            // 
            resources.ApplyResources(this.addCircleBtn, "addCircleBtn");
            this.addCircleBtn.FlatAppearance.BorderSize = 0;
            this.addCircleBtn.Name = "addCircleBtn";
            this.addCircleBtn.UseVisualStyleBackColor = true;
            this.addCircleBtn.Click += new System.EventHandler(this.AddCircleBtnClick);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimerTick);
            // 
            // clearBtn
            // 
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtnClick);
            // 
            // playBtn
            // 
            resources.ApplyResources(this.playBtn, "playBtn");
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.Name = "playBtn";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.PlayBtnClick);
            // 
            // forwardBtn
            // 
            resources.ApplyResources(this.forwardBtn, "forwardBtn");
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.ForwardBtnClick);
            // 
            // backwardBtn
            // 
            resources.ApplyResources(this.backwardBtn, "backwardBtn");
            this.backwardBtn.FlatAppearance.BorderSize = 0;
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.UseVisualStyleBackColor = true;
            this.backwardBtn.Click += new System.EventHandler(this.BackwardBtnClick);
            // 
            // fastBackwardBtn
            // 
            resources.ApplyResources(this.fastBackwardBtn, "fastBackwardBtn");
            this.fastBackwardBtn.FlatAppearance.BorderSize = 0;
            this.fastBackwardBtn.Name = "fastBackwardBtn";
            this.fastBackwardBtn.UseVisualStyleBackColor = true;
            this.fastBackwardBtn.Click += new System.EventHandler(this.FastBackwardBtnClick);
            // 
            // fastForwardBtn
            // 
            resources.ApplyResources(this.fastForwardBtn, "fastForwardBtn");
            this.fastForwardBtn.FlatAppearance.BorderSize = 0;
            this.fastForwardBtn.Name = "fastForwardBtn";
            this.fastForwardBtn.UseVisualStyleBackColor = true;
            this.fastForwardBtn.Click += new System.EventHandler(this.FastForwardBtnClick);
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // loadBtn
            // 
            resources.ApplyResources(this.loadBtn, "loadBtn");
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.LoadBtnClick);
            // 
            // saveLabel
            // 
            resources.ApplyResources(this.saveLabel, "saveLabel");
            this.saveLabel.Name = "saveLabel";
            // 
            // loadLabel
            // 
            resources.ApplyResources(this.loadLabel, "loadLabel");
            this.loadLabel.Name = "loadLabel";
            // 
            // squareLabel
            // 
            resources.ApplyResources(this.squareLabel, "squareLabel");
            this.squareLabel.Name = "squareLabel";
            // 
            // triangleLabel
            // 
            resources.ApplyResources(this.triangleLabel, "triangleLabel");
            this.triangleLabel.Name = "triangleLabel";
            // 
            // circleLabel
            // 
            resources.ApplyResources(this.circleLabel, "circleLabel");
            this.circleLabel.Name = "circleLabel";
            // 
            // fBackwardlabel
            // 
            resources.ApplyResources(this.fBackwardlabel, "fBackwardlabel");
            this.fBackwardlabel.Name = "fBackwardlabel";
            // 
            // backwardLabel
            // 
            resources.ApplyResources(this.backwardLabel, "backwardLabel");
            this.backwardLabel.Name = "backwardLabel";
            // 
            // playLabel
            // 
            resources.ApplyResources(this.playLabel, "playLabel");
            this.playLabel.Name = "playLabel";
            // 
            // forwardLabel
            // 
            resources.ApplyResources(this.forwardLabel, "forwardLabel");
            this.forwardLabel.Name = "forwardLabel";
            // 
            // fForwardLabel
            // 
            resources.ApplyResources(this.fForwardLabel, "fForwardLabel");
            this.fForwardLabel.Name = "fForwardLabel";
            // 
            // pauseLabel
            // 
            resources.ApplyResources(this.pauseLabel, "pauseLabel");
            this.pauseLabel.Name = "pauseLabel";
            // 
            // deleteLabel
            // 
            resources.ApplyResources(this.deleteLabel, "deleteLabel");
            this.deleteLabel.Name = "deleteLabel";
            // 
            // langBtn
            // 
            resources.ApplyResources(this.langBtn, "langBtn");
            this.langBtn.FlatAppearance.BorderSize = 0;
            this.langBtn.Name = "langBtn";
            this.langBtn.UseVisualStyleBackColor = true;
            this.langBtn.Click += new System.EventHandler(this.LangBtnClick);
            // 
            // langListBox
            // 
            resources.ApplyResources(this.langListBox, "langListBox");
            this.langListBox.BackColor = System.Drawing.SystemColors.Control;
            this.langListBox.FormattingEnabled = true;
            this.langListBox.Items.AddRange(new object[] {
            resources.GetString("langListBox.Items"),
            resources.GetString("langListBox.Items1"),
            resources.GetString("langListBox.Items2")});
            this.langListBox.Name = "langListBox";
            this.langListBox.SelectedIndexChanged += new System.EventHandler(this.LangListBoxSelectedIndexChanged);
            // 
            // langLabel
            // 
            resources.ApplyResources(this.langLabel, "langLabel");
            this.langLabel.Name = "langLabel";
            // 
            // shapeGroupBox
            // 
            resources.ApplyResources(this.shapeGroupBox, "shapeGroupBox");
            this.shapeGroupBox.Name = "shapeGroupBox";
            this.shapeGroupBox.TabStop = false;
            // 
            // fileGroupBox
            // 
            resources.ApplyResources(this.fileGroupBox, "fileGroupBox");
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.TabStop = false;
            // 
            // playbeckGroupBox
            // 
            resources.ApplyResources(this.playbeckGroupBox, "playbeckGroupBox");
            this.playbeckGroupBox.Name = "playbeckGroupBox";
            this.playbeckGroupBox.TabStop = false;
            // 
            // mainTreeView
            // 
            resources.ApplyResources(this.mainTreeView, "mainTreeView");
            this.mainTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.mainTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeViewAfterSelect);
            // 
            // removeEventLabel
            // 
            resources.ApplyResources(this.removeEventLabel, "removeEventLabel");
            this.removeEventLabel.Name = "removeEventLabel";
            // 
            // addEventBtn
            // 
            resources.ApplyResources(this.addEventBtn, "addEventBtn");
            this.addEventBtn.FlatAppearance.BorderSize = 0;
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.AddEventBtnClick);
            // 
            // evntGroupBox
            // 
            resources.ApplyResources(this.evntGroupBox, "evntGroupBox");
            this.evntGroupBox.Controls.Add(this.addEventLabel);
            this.evntGroupBox.Controls.Add(this.removeEventBtn);
            this.evntGroupBox.Name = "evntGroupBox";
            this.evntGroupBox.TabStop = false;
            // 
            // addEventLabel
            // 
            resources.ApplyResources(this.addEventLabel, "addEventLabel");
            this.addEventLabel.Name = "addEventLabel";
            // 
            // removeEventBtn
            // 
            resources.ApplyResources(this.removeEventBtn, "removeEventBtn");
            this.removeEventBtn.FlatAppearance.BorderSize = 0;
            this.removeEventBtn.Name = "removeEventBtn";
            this.removeEventBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.removeEventLabel);
            this.Controls.Add(this.mainTreeView);
            this.Controls.Add(this.langListBox);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.langBtn);
            this.Controls.Add(this.evntGroupBox);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.fForwardLabel);
            this.Controls.Add(this.forwardLabel);
            this.Controls.Add(this.backwardLabel);
            this.Controls.Add(this.fBackwardlabel);
            this.Controls.Add(this.circleLabel);
            this.Controls.Add(this.triangleLabel);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fastForwardBtn);
            this.Controls.Add(this.fastBackwardBtn);
            this.Controls.Add(this.backwardBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addCircleBtn);
            this.Controls.Add(this.addTriangleBtn);
            this.Controls.Add(this.addRectangleBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.mainPicBox);
            this.Controls.Add(this.shapeGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.playbeckGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.evntGroupBox.ResumeLayout(false);
            this.evntGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView mainTreeView;
        private Label removeEventLabel;
        private Button addEventBtn;
        private GroupBox evntGroupBox;
        private Button removeEventBtn;
        private Label addEventLabel;
    }
}

