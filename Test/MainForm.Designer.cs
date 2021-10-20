
namespace Test
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("land_records");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("build_records");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("construction_records");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("spatial_data");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("municipal_boundaries");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("zones_and_territories_boundaries");
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.openRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelObjects = new System.Windows.Forms.Label();
            this.objectRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelOpneFile = new System.Windows.Forms.Label();
            this.objectstTeeView = new System.Windows.Forms.TreeView();
            this.openFileButton = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.clearingObjectRichBox = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.openRichTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelObjects, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.objectRichTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOpneFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.objectstTeeView, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.227941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.77206F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 5);
            this.label1.MaximumSize = new System.Drawing.Size(135, 13);
            this.label1.MinimumSize = new System.Drawing.Size(117, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cодержимое объекта(ов)";
            // 
            // openRichTextBox
            // 
            this.openRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openRichTextBox.Location = new System.Drawing.Point(3, 27);
            this.openRichTextBox.Name = "openRichTextBox";
            this.openRichTextBox.ReadOnly = true;
            this.openRichTextBox.Size = new System.Drawing.Size(390, 545);
            this.openRichTextBox.TabIndex = 0;
            this.openRichTextBox.Text = "";
            // 
            // labelObjects
            // 
            this.labelObjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelObjects.AutoSize = true;
            this.labelObjects.Location = new System.Drawing.Point(468, 5);
            this.labelObjects.MaximumSize = new System.Drawing.Size(53, 13);
            this.labelObjects.MinimumSize = new System.Drawing.Size(53, 13);
            this.labelObjects.Name = "labelObjects";
            this.labelObjects.Size = new System.Drawing.Size(53, 13);
            this.labelObjects.TabIndex = 4;
            this.labelObjects.Text = "Объекты";
            // 
            // objectRichTextBox
            // 
            this.objectRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectRichTextBox.Location = new System.Drawing.Point(597, 27);
            this.objectRichTextBox.Name = "objectRichTextBox";
            this.objectRichTextBox.ReadOnly = true;
            this.objectRichTextBox.Size = new System.Drawing.Size(391, 545);
            this.objectRichTextBox.TabIndex = 2;
            this.objectRichTextBox.Text = "";
            // 
            // labelOpneFile
            // 
            this.labelOpneFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOpneFile.Location = new System.Drawing.Point(180, 5);
            this.labelOpneFile.MaximumSize = new System.Drawing.Size(36, 13);
            this.labelOpneFile.MinimumSize = new System.Drawing.Size(36, 13);
            this.labelOpneFile.Name = "labelOpneFile";
            this.labelOpneFile.Size = new System.Drawing.Size(36, 13);
            this.labelOpneFile.TabIndex = 3;
            this.labelOpneFile.Text = "Файл";
            this.labelOpneFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objectstTeeView
            // 
            this.objectstTeeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectstTeeView.Location = new System.Drawing.Point(399, 27);
            this.objectstTeeView.Name = "objectstTeeView";
            treeNode7.Checked = true;
            treeNode7.Name = "land_records";
            treeNode7.Text = "land_records";
            treeNode8.Name = "build_records";
            treeNode8.Text = "build_records";
            treeNode9.Name = "construction_records";
            treeNode9.Text = "construction_records";
            treeNode10.Name = "spatial_data";
            treeNode10.Text = "spatial_data";
            treeNode11.Name = "municipal_boundaries";
            treeNode11.Text = "municipal_boundaries";
            treeNode12.Name = "zones_and_territories_boundaries";
            treeNode12.Text = "zones_and_territories_boundaries";
            this.objectstTeeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.objectstTeeView.Size = new System.Drawing.Size(192, 545);
            this.objectstTeeView.TabIndex = 0;
            this.objectstTeeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.objectstTeeView_NodeMouseDoubleClick_1);
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFileButton.Location = new System.Drawing.Point(4, 581);
            this.openFileButton.MaximumSize = new System.Drawing.Size(75, 28);
            this.openFileButton.MinimumSize = new System.Drawing.Size(75, 28);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 28);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savebtn.Location = new System.Drawing.Point(85, 581);
            this.savebtn.MaximumSize = new System.Drawing.Size(208, 28);
            this.savebtn.MinimumSize = new System.Drawing.Size(193, 28);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(208, 28);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Сохранить содержимое объекта(ов)";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(299, 581);
            this.button1.MaximumSize = new System.Drawing.Size(192, 28);
            this.button1.MinimumSize = new System.Drawing.Size(192, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить содержимое объекта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addObjBtn_Click);
            // 
            // clearingObjectRichBox
            // 
            this.clearingObjectRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearingObjectRichBox.Location = new System.Drawing.Point(497, 581);
            this.clearingObjectRichBox.MaximumSize = new System.Drawing.Size(195, 28);
            this.clearingObjectRichBox.MinimumSize = new System.Drawing.Size(195, 28);
            this.clearingObjectRichBox.Name = "clearingObjectRichBox";
            this.clearingObjectRichBox.Size = new System.Drawing.Size(195, 28);
            this.clearingObjectRichBox.TabIndex = 4;
            this.clearingObjectRichBox.Text = "Очистить содержимое объекта(ов)";
            this.clearingObjectRichBox.UseVisualStyleBackColor = true;
            this.clearingObjectRichBox.Click += new System.EventHandler(this.clearingObjectRichBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 621);
            this.Controls.Add(this.clearingObjectRichBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(925, 653);
            this.Name = "MainForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox openRichTextBox;
        private System.Windows.Forms.RichTextBox objectRichTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelOpneFile;
        private System.Windows.Forms.Label labelObjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView objectstTeeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearingObjectRichBox;
    }
}

