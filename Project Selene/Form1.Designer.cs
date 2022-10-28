namespace Project_Selene
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WeAreDevsButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.EasyExploitButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScriptTab = new System.Windows.Forms.PictureBox();
            this.MINIMIZE = new System.Windows.Forms.PictureBox();
            this.CLOSE = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ScriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.KrnlButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.topmost = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Supreme", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "FULLY SKIDDED EXECUTOR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.topmost);
            this.panel2.Controls.Add(this.KrnlButton);
            this.panel2.Controls.Add(this.WeAreDevsButton);
            this.panel2.Controls.Add(this.EasyExploitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-10, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 48);
            this.panel2.TabIndex = 2;
            // 
            // WeAreDevsButton
            // 
            this.WeAreDevsButton.AutoSize = true;
            this.WeAreDevsButton.Checked = true;
            this.WeAreDevsButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WeAreDevsButton.CheckedState.BorderThickness = 0;
            this.WeAreDevsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WeAreDevsButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.WeAreDevsButton.CheckedState.InnerOffset = -4;
            this.WeAreDevsButton.Font = new System.Drawing.Font("Supreme", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeAreDevsButton.ForeColor = System.Drawing.Color.White;
            this.WeAreDevsButton.Location = new System.Drawing.Point(534, 16);
            this.WeAreDevsButton.Name = "WeAreDevsButton";
            this.WeAreDevsButton.Size = new System.Drawing.Size(113, 19);
            this.WeAreDevsButton.TabIndex = 10;
            this.WeAreDevsButton.TabStop = true;
            this.WeAreDevsButton.Text = "WeAreDevs API";
            this.WeAreDevsButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.WeAreDevsButton.UncheckedState.BorderThickness = 2;
            this.WeAreDevsButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.WeAreDevsButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.WeAreDevsButton.UseVisualStyleBackColor = true;
            // 
            // EasyExploitButton
            // 
            this.EasyExploitButton.AutoSize = true;
            this.EasyExploitButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EasyExploitButton.CheckedState.BorderThickness = 0;
            this.EasyExploitButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EasyExploitButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.EasyExploitButton.CheckedState.InnerOffset = -4;
            this.EasyExploitButton.Font = new System.Drawing.Font("Supreme", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyExploitButton.ForeColor = System.Drawing.Color.White;
            this.EasyExploitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EasyExploitButton.Location = new System.Drawing.Point(418, 16);
            this.EasyExploitButton.Name = "EasyExploitButton";
            this.EasyExploitButton.Size = new System.Drawing.Size(110, 19);
            this.EasyExploitButton.TabIndex = 9;
            this.EasyExploitButton.Text = "EasyExploit API";
            this.EasyExploitButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EasyExploitButton.UncheckedState.BorderThickness = 2;
            this.EasyExploitButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.EasyExploitButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.EasyExploitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Supreme", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "S";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project_Selene.Properties.Resources.INJECT;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(58, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_Selene.Properties.Resources.EXECUTE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(662, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScriptTab);
            this.panel1.Controls.Add(this.MINIMIZE);
            this.panel1.Controls.Add(this.CLOSE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 38);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ScriptTab
            // 
            this.ScriptTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ScriptTab.Image = global::Project_Selene.Properties.Resources.ScriptTab;
            this.ScriptTab.Location = new System.Drawing.Point(40, 0);
            this.ScriptTab.Name = "ScriptTab";
            this.ScriptTab.Size = new System.Drawing.Size(89, 38);
            this.ScriptTab.TabIndex = 9;
            this.ScriptTab.TabStop = false;
            this.ScriptTab.Click += new System.EventHandler(this.ScriptTab_Click);
            this.ScriptTab.MouseEnter += new System.EventHandler(this.ScriptTab_MouseEnter);
            this.ScriptTab.MouseLeave += new System.EventHandler(this.ScriptTab_MouseLeave);
            // 
            // MINIMIZE
            // 
            this.MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MINIMIZE.Image = global::Project_Selene.Properties.Resources.MINIMIZE;
            this.MINIMIZE.Location = new System.Drawing.Point(600, 0);
            this.MINIMIZE.Name = "MINIMIZE";
            this.MINIMIZE.Size = new System.Drawing.Size(50, 38);
            this.MINIMIZE.TabIndex = 8;
            this.MINIMIZE.TabStop = false;
            this.MINIMIZE.Click += new System.EventHandler(this.MINIMIZE_Click);
            this.MINIMIZE.MouseEnter += new System.EventHandler(this.MINIMIZE_MouseEnter);
            this.MINIMIZE.MouseLeave += new System.EventHandler(this.MINIMIZE_MouseLeave);
            // 
            // CLOSE
            // 
            this.CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CLOSE.Image = global::Project_Selene.Properties.Resources.EXIT;
            this.CLOSE.Location = new System.Drawing.Point(650, 0);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(50, 38);
            this.CLOSE.TabIndex = 7;
            this.CLOSE.TabStop = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            this.CLOSE.MouseEnter += new System.EventHandler(this.CLOSE_MouseEnter);
            this.CLOSE.MouseLeave += new System.EventHandler(this.CLOSE_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Project_Selene.Properties.Resources.HOME;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // ScriptBox
            // 
            this.ScriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.ScriptBox.AutoScrollMinSize = new System.Drawing.Size(147, 17);
            this.ScriptBox.BackBrush = null;
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScriptBox.BookmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScriptBox.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScriptBox.CharHeight = 17;
            this.ScriptBox.CharWidth = 8;
            this.ScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScriptBox.IsReplaceMode = false;
            this.ScriptBox.LineInterval = 3;
            this.ScriptBox.LineNumberColor = System.Drawing.Color.White;
            this.ScriptBox.Location = new System.Drawing.Point(0, 88);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptBox.ServiceColors")));
            this.ScriptBox.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScriptBox.Size = new System.Drawing.Size(700, 312);
            this.ScriptBox.TabIndex = 4;
            this.ScriptBox.Text = "--Skid go brrrr";
            this.ScriptBox.TextAreaBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ScriptBox.Zoom = 100;
            // 
            // KrnlButton
            // 
            this.KrnlButton.AutoSize = true;
            this.KrnlButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KrnlButton.CheckedState.BorderThickness = 0;
            this.KrnlButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KrnlButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.KrnlButton.CheckedState.InnerOffset = -4;
            this.KrnlButton.Font = new System.Drawing.Font("Supreme", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KrnlButton.ForeColor = System.Drawing.Color.White;
            this.KrnlButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KrnlButton.Location = new System.Drawing.Point(342, 16);
            this.KrnlButton.Name = "KrnlButton";
            this.KrnlButton.Size = new System.Drawing.Size(70, 19);
            this.KrnlButton.TabIndex = 11;
            this.KrnlButton.Text = "Krnl API";
            this.KrnlButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.KrnlButton.UncheckedState.BorderThickness = 2;
            this.KrnlButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.KrnlButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.KrnlButton.UseVisualStyleBackColor = true;
            // 
            // topmost
            // 
            this.topmost.AutoSize = true;
            this.topmost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topmost.CheckedState.BorderRadius = 2;
            this.topmost.CheckedState.BorderThickness = 0;
            this.topmost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.topmost.Font = new System.Drawing.Font("Supreme", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topmost.ForeColor = System.Drawing.Color.White;
            this.topmost.Location = new System.Drawing.Point(132, 18);
            this.topmost.Name = "topmost";
            this.topmost.Size = new System.Drawing.Size(78, 19);
            this.topmost.TabIndex = 12;
            this.topmost.Text = "Top Most";
            this.topmost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topmost.UncheckedState.BorderRadius = 2;
            this.topmost.UncheckedState.BorderThickness = 0;
            this.topmost.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topmost.UseVisualStyleBackColor = true;
            this.topmost.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINIMIZE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox CLOSE;
        private System.Windows.Forms.PictureBox MINIMIZE;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ScriptTab;
        private Guna.UI2.WinForms.Guna2RadioButton WeAreDevsButton;
        private Guna.UI2.WinForms.Guna2RadioButton EasyExploitButton;
        private Guna.UI2.WinForms.Guna2RadioButton KrnlButton;
        private Guna.UI2.WinForms.Guna2CheckBox topmost;
    }
}

