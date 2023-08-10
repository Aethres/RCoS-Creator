namespace WindowsFormsApp1
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
            System.Windows.Forms.ComboBox comboBox1;
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.events = new System.Windows.Forms.RichTextBox();
            this.timerEvents = new System.Windows.Forms.RichTextBox();
            this.devIO = new System.Windows.Forms.RichTextBox();
            this.devCom = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.eventsCount = new System.Windows.Forms.NumericUpDown();
            this.timerEventsCount = new System.Windows.Forms.NumericUpDown();
            this.devIOCount = new System.Windows.Forms.NumericUpDown();
            this.devComCount = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            this.debugName = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.debugPortsLabel = new System.Windows.Forms.Label();
            this.debugPorts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emreKarabekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çağrıHocaoğluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerEventsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devIOCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] {
            "CyPress PSOC4",
            "CyPress PSOC6",
            "Renesas RA2",
            "NXP ke02",
            "NXP ke04",
            "NXP ke14",
            "NXP ke15",
            "NXP ke16",
            "AVR",
            "Sinowealth"});
            comboBox1.Location = new System.Drawing.Point(30, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            comboBox1.Size = new System.Drawing.Size(234, 24);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Please Select MCU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(466, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 77);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(145, 24);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "#Process Count";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(30, 122);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(145, 24);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "Choosen Process";
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(30, 167);
            this.events.Multiline = false;
            this.events.Name = "events";
            this.events.ReadOnly = true;
            this.events.Size = new System.Drawing.Size(145, 24);
            this.events.TabIndex = 11;
            this.events.Text = "Events";
            // 
            // timerEvents
            // 
            this.timerEvents.Location = new System.Drawing.Point(30, 210);
            this.timerEvents.Multiline = false;
            this.timerEvents.Name = "timerEvents";
            this.timerEvents.ReadOnly = true;
            this.timerEvents.Size = new System.Drawing.Size(145, 24);
            this.timerEvents.TabIndex = 12;
            this.timerEvents.Text = "Timer Events";
            // 
            // devIO
            // 
            this.devIO.Location = new System.Drawing.Point(30, 250);
            this.devIO.Multiline = false;
            this.devIO.Name = "devIO";
            this.devIO.ReadOnly = true;
            this.devIO.Size = new System.Drawing.Size(145, 24);
            this.devIO.TabIndex = 13;
            this.devIO.Text = "DevIO";
            // 
            // devCom
            // 
            this.devCom.Location = new System.Drawing.Point(30, 294);
            this.devCom.Multiline = false;
            this.devCom.Name = "devCom";
            this.devCom.ReadOnly = true;
            this.devCom.Size = new System.Drawing.Size(145, 24);
            this.devCom.TabIndex = 14;
            this.devCom.Text = "DevCom";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 77);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 22);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(181, 122);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(83, 22);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // eventsCount
            // 
            this.eventsCount.Location = new System.Drawing.Point(181, 169);
            this.eventsCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(83, 22);
            this.eventsCount.TabIndex = 17;
            this.eventsCount.ValueChanged += new System.EventHandler(this.eventsCount_ValueChanged);
            // 
            // timerEventsCount
            // 
            this.timerEventsCount.Location = new System.Drawing.Point(181, 211);
            this.timerEventsCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.timerEventsCount.Name = "timerEventsCount";
            this.timerEventsCount.Size = new System.Drawing.Size(83, 22);
            this.timerEventsCount.TabIndex = 18;
            this.timerEventsCount.ValueChanged += new System.EventHandler(this.timerEventsCount_ValueChanged);
            // 
            // devIOCount
            // 
            this.devIOCount.Location = new System.Drawing.Point(181, 252);
            this.devIOCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.devIOCount.Name = "devIOCount";
            this.devIOCount.Size = new System.Drawing.Size(83, 22);
            this.devIOCount.TabIndex = 19;
            this.devIOCount.ValueChanged += new System.EventHandler(this.devIOCount_ValueChanged);
            // 
            // devComCount
            // 
            this.devComCount.Location = new System.Drawing.Point(181, 296);
            this.devComCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.devComCount.Name = "devComCount";
            this.devComCount.Size = new System.Drawing.Size(83, 22);
            this.devComCount.TabIndex = 20;
            this.devComCount.ValueChanged += new System.EventHandler(this.devComCount_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(30, 324);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(234, 42);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset Process";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // debugName
            // 
            this.debugName.Location = new System.Drawing.Point(430, 210);
            this.debugName.Name = "debugName";
            this.debugName.Size = new System.Drawing.Size(374, 22);
            this.debugName.TabIndex = 25;
            this.debugName.TextChanged += new System.EventHandler(this.debugName_TextChanged);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(430, 36);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(374, 22);
            this.author.TabIndex = 26;
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(430, 76);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(374, 109);
            this.description.TabIndex = 27;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // debugPortsLabel
            // 
            this.debugPortsLabel.AutoSize = true;
            this.debugPortsLabel.BackColor = System.Drawing.Color.Transparent;
            this.debugPortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debugPortsLabel.Location = new System.Drawing.Point(305, 252);
            this.debugPortsLabel.Name = "debugPortsLabel";
            this.debugPortsLabel.Size = new System.Drawing.Size(129, 80);
            this.debugPortsLabel.TabIndex = 28;
            this.debugPortsLabel.Text = "Debug Port\r\nNames\r\n(Use \",\" for \r\nmultiple entries)";
            // 
            // debugPorts
            // 
            this.debugPorts.Location = new System.Drawing.Point(430, 252);
            this.debugPorts.Name = "debugPorts";
            this.debugPorts.Size = new System.Drawing.Size(374, 22);
            this.debugPorts.TabIndex = 29;
            this.debugPorts.TextChanged += new System.EventHandler(this.debugPorts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(305, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Debug Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(305, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(305, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.test3ToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.test3ToolStripMenuItem.Text = "Test3";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem2,
            this.test2ToolStripMenuItem2,
            this.test3ToolStripMenuItem2});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // test1ToolStripMenuItem2
            // 
            this.test1ToolStripMenuItem2.Name = "test1ToolStripMenuItem2";
            this.test1ToolStripMenuItem2.Size = new System.Drawing.Size(126, 26);
            this.test1ToolStripMenuItem2.Text = "Test1";
            // 
            // test2ToolStripMenuItem2
            // 
            this.test2ToolStripMenuItem2.Name = "test2ToolStripMenuItem2";
            this.test2ToolStripMenuItem2.Size = new System.Drawing.Size(126, 26);
            this.test2ToolStripMenuItem2.Text = "Test2";
            // 
            // test3ToolStripMenuItem2
            // 
            this.test3ToolStripMenuItem2.Name = "test3ToolStripMenuItem2";
            this.test3ToolStripMenuItem2.Size = new System.Drawing.Size(126, 26);
            this.test3ToolStripMenuItem2.Text = "Test3";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem1,
            this.test2ToolStripMenuItem1,
            this.versionToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // test1ToolStripMenuItem1
            // 
            this.test1ToolStripMenuItem1.Name = "test1ToolStripMenuItem1";
            this.test1ToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.test1ToolStripMenuItem1.Text = "Test1";
            // 
            // test2ToolStripMenuItem1
            // 
            this.test2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByToolStripMenuItem,
            this.emreKarabekToolStripMenuItem,
            this.çağrıHocaoğluToolStripMenuItem});
            this.test2ToolStripMenuItem1.Name = "test2ToolStripMenuItem1";
            this.test2ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.test2ToolStripMenuItem1.Text = "About";
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.Enabled = false;
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            this.versionToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.versionToolStripMenuItem1.Text = "V. 1.0";
            // 
            // madeByToolStripMenuItem
            // 
            this.madeByToolStripMenuItem.Enabled = false;
            this.madeByToolStripMenuItem.Name = "madeByToolStripMenuItem";
            this.madeByToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.madeByToolStripMenuItem.Text = "Made By";
            // 
            // emreKarabekToolStripMenuItem
            // 
            this.emreKarabekToolStripMenuItem.Enabled = false;
            this.emreKarabekToolStripMenuItem.Name = "emreKarabekToolStripMenuItem";
            this.emreKarabekToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.emreKarabekToolStripMenuItem.Text = "Emre Karabek";
            // 
            // çağrıHocaoğluToolStripMenuItem
            // 
            this.çağrıHocaoğluToolStripMenuItem.Enabled = false;
            this.çağrıHocaoğluToolStripMenuItem.Name = "çağrıHocaoğluToolStripMenuItem";
            this.çağrıHocaoğluToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çağrıHocaoğluToolStripMenuItem.Text = "Çağrı Hocaoğlu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 912);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debugPorts);
            this.Controls.Add(this.debugPortsLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.author);
            this.Controls.Add(this.debugName);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.devComCount);
            this.Controls.Add(this.devIOCount);
            this.Controls.Add(this.timerEventsCount);
            this.Controls.Add(this.eventsCount);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.devCom);
            this.Controls.Add(this.devIO);
            this.Controls.Add(this.timerEvents);
            this.Controls.Add(this.events);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerEventsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devIOCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox events;
        private System.Windows.Forms.RichTextBox timerEvents;
        private System.Windows.Forms.RichTextBox devIO;
        private System.Windows.Forms.RichTextBox devCom;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown eventsCount;
        private System.Windows.Forms.NumericUpDown timerEventsCount;
        private System.Windows.Forms.NumericUpDown devIOCount;
        private System.Windows.Forms.NumericUpDown devComCount;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox debugName;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label debugPortsLabel;
        private System.Windows.Forms.TextBox debugPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem madeByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emreKarabekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çağrıHocaoğluToolStripMenuItem;
    }
}

