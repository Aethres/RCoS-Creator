namespace WindowsFormsApp1
{
    partial class CreatorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatorWindow));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.test3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emreKarabekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çağrıHocaoğluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rCoSSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledBlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buzzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflexGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcelikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FreeRTOSButton = new System.Windows.Forms.Button();
            this.AIButton = new System.Windows.Forms.Button();
            this.CodeSizeButton = new System.Windows.Forms.Button();
            this.SecureButton = new System.Windows.Forms.Button();
            this.ClassBButton = new System.Windows.Forms.Button();
            this.CodeSize = new System.Windows.Forms.Button();
            this.devCpxCount = new System.Windows.Forms.NumericUpDown();
            this.devCpx = new System.Windows.Forms.RichTextBox();
            this.devMemCount = new System.Windows.Forms.NumericUpDown();
            this.devMem = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerEventsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devIOCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCpxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 126);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Please Select MCU";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(343, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 157);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(110, 20);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "#Process Count";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(30, 181);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(110, 20);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "Choosen Process";
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(30, 205);
            this.events.Margin = new System.Windows.Forms.Padding(2);
            this.events.Multiline = false;
            this.events.Name = "events";
            this.events.ReadOnly = true;
            this.events.Size = new System.Drawing.Size(110, 20);
            this.events.TabIndex = 11;
            this.events.Text = "Events";
            // 
            // timerEvents
            // 
            this.timerEvents.Location = new System.Drawing.Point(30, 229);
            this.timerEvents.Margin = new System.Windows.Forms.Padding(2);
            this.timerEvents.Multiline = false;
            this.timerEvents.Name = "timerEvents";
            this.timerEvents.ReadOnly = true;
            this.timerEvents.Size = new System.Drawing.Size(110, 20);
            this.timerEvents.TabIndex = 12;
            this.timerEvents.Text = "Timer Events";
            // 
            // devIO
            // 
            this.devIO.Location = new System.Drawing.Point(30, 253);
            this.devIO.Margin = new System.Windows.Forms.Padding(2);
            this.devIO.Multiline = false;
            this.devIO.Name = "devIO";
            this.devIO.ReadOnly = true;
            this.devIO.Size = new System.Drawing.Size(110, 20);
            this.devIO.TabIndex = 13;
            this.devIO.Text = "DevIO";
            // 
            // devCom
            // 
            this.devCom.Location = new System.Drawing.Point(30, 277);
            this.devCom.Margin = new System.Windows.Forms.Padding(2);
            this.devCom.Multiline = false;
            this.devCom.Name = "devCom";
            this.devCom.ReadOnly = true;
            this.devCom.Size = new System.Drawing.Size(110, 20);
            this.devCom.TabIndex = 14;
            this.devCom.Text = "DevCom";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(143, 157);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(143, 181);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // eventsCount
            // 
            this.eventsCount.Location = new System.Drawing.Point(143, 207);
            this.eventsCount.Margin = new System.Windows.Forms.Padding(2);
            this.eventsCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(62, 20);
            this.eventsCount.TabIndex = 17;
            this.eventsCount.ValueChanged += new System.EventHandler(this.eventsCount_ValueChanged);
            // 
            // timerEventsCount
            // 
            this.timerEventsCount.Location = new System.Drawing.Point(143, 230);
            this.timerEventsCount.Margin = new System.Windows.Forms.Padding(2);
            this.timerEventsCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.timerEventsCount.Name = "timerEventsCount";
            this.timerEventsCount.Size = new System.Drawing.Size(62, 20);
            this.timerEventsCount.TabIndex = 18;
            this.timerEventsCount.ValueChanged += new System.EventHandler(this.timerEventsCount_ValueChanged);
            // 
            // devIOCount
            // 
            this.devIOCount.Location = new System.Drawing.Point(143, 255);
            this.devIOCount.Margin = new System.Windows.Forms.Padding(2);
            this.devIOCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.devIOCount.Name = "devIOCount";
            this.devIOCount.Size = new System.Drawing.Size(62, 20);
            this.devIOCount.TabIndex = 19;
            this.devIOCount.ValueChanged += new System.EventHandler(this.devIOCount_ValueChanged);
            // 
            // devComCount
            // 
            this.devComCount.Location = new System.Drawing.Point(143, 279);
            this.devComCount.Margin = new System.Windows.Forms.Padding(2);
            this.devComCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.devComCount.Name = "devComCount";
            this.devComCount.Size = new System.Drawing.Size(62, 20);
            this.devComCount.TabIndex = 20;
            this.devComCount.ValueChanged += new System.EventHandler(this.devComCount_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(30, 357);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(176, 34);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset Process";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // debugName
            // 
            this.debugName.Location = new System.Drawing.Point(315, 269);
            this.debugName.Margin = new System.Windows.Forms.Padding(2);
            this.debugName.Name = "debugName";
            this.debugName.Size = new System.Drawing.Size(282, 20);
            this.debugName.TabIndex = 25;
            this.debugName.TextChanged += new System.EventHandler(this.debugName_TextChanged);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(315, 128);
            this.author.Margin = new System.Windows.Forms.Padding(2);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(282, 20);
            this.author.TabIndex = 26;
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(315, 160);
            this.description.Margin = new System.Windows.Forms.Padding(2);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(282, 89);
            this.description.TabIndex = 27;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // debugPortsLabel
            // 
            this.debugPortsLabel.AutoSize = true;
            this.debugPortsLabel.BackColor = System.Drawing.Color.Gray;
            this.debugPortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debugPortsLabel.Location = new System.Drawing.Point(222, 303);
            this.debugPortsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugPortsLabel.Name = "debugPortsLabel";
            this.debugPortsLabel.Size = new System.Drawing.Size(80, 17);
            this.debugPortsLabel.TabIndex = 28;
            this.debugPortsLabel.Text = "Debug Port\r\n";
            // 
            // debugPorts
            // 
            this.debugPorts.ForeColor = System.Drawing.Color.Gray;
            this.debugPorts.Location = new System.Drawing.Point(315, 303);
            this.debugPorts.Margin = new System.Windows.Forms.Padding(2);
            this.debugPorts.Name = "debugPorts";
            this.debugPorts.Size = new System.Drawing.Size(282, 20);
            this.debugPorts.TabIndex = 29;
            this.debugPorts.Text = "Use \",\" for multiple entries";
            this.debugPorts.TextChanged += new System.EventHandler(this.debugPorts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(222, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Debug Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(222, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(222, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(45, 16);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.rCoSSiteToolStripMenuItem,
            this.examplesToolStripMenuItem,
            this.arcelikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.test3ToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // test3ToolStripMenuItem
            // 
            this.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem";
            this.test3ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.test3ToolStripMenuItem.Text = "Test3";
            this.test3ToolStripMenuItem.Click += new System.EventHandler(this.test3ToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem2,
            this.importToolStripMenuItem2,
            this.test3ToolStripMenuItem2});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // test1ToolStripMenuItem2
            // 
            this.test1ToolStripMenuItem2.Name = "test1ToolStripMenuItem2";
            this.test1ToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.test1ToolStripMenuItem2.Text = "Import";
            this.test1ToolStripMenuItem2.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem2
            // 
            this.importToolStripMenuItem2.Name = "importToolStripMenuItem2";
            this.importToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem2.Text = "Test2";
            // 
            // test3ToolStripMenuItem2
            // 
            this.test3ToolStripMenuItem2.Name = "test3ToolStripMenuItem2";
            this.test3ToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.test3ToolStripMenuItem2.Text = "Test3";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem1,
            this.test2ToolStripMenuItem1,
            this.versionToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // test1ToolStripMenuItem1
            // 
            this.test1ToolStripMenuItem1.Name = "test1ToolStripMenuItem1";
            this.test1ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.test1ToolStripMenuItem1.Text = "RCoS Help";
            this.test1ToolStripMenuItem1.Click += new System.EventHandler(this.test1ToolStripMenuItem1_Click);
            // 
            // test2ToolStripMenuItem1
            // 
            this.test2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByToolStripMenuItem,
            this.emreKarabekToolStripMenuItem,
            this.çağrıHocaoğluToolStripMenuItem});
            this.test2ToolStripMenuItem1.Name = "test2ToolStripMenuItem1";
            this.test2ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.test2ToolStripMenuItem1.Text = "About";
            // 
            // madeByToolStripMenuItem
            // 
            this.madeByToolStripMenuItem.Enabled = false;
            this.madeByToolStripMenuItem.Name = "madeByToolStripMenuItem";
            this.madeByToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.madeByToolStripMenuItem.Text = "Made By";
            // 
            // emreKarabekToolStripMenuItem
            // 
            this.emreKarabekToolStripMenuItem.Enabled = false;
            this.emreKarabekToolStripMenuItem.Name = "emreKarabekToolStripMenuItem";
            this.emreKarabekToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.emreKarabekToolStripMenuItem.Text = "Emre Karabek";
            // 
            // çağrıHocaoğluToolStripMenuItem
            // 
            this.çağrıHocaoğluToolStripMenuItem.Enabled = false;
            this.çağrıHocaoğluToolStripMenuItem.Name = "çağrıHocaoğluToolStripMenuItem";
            this.çağrıHocaoğluToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.çağrıHocaoğluToolStripMenuItem.Text = "Çağrı Hocaoğlu";
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.Enabled = false;
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            this.versionToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.versionToolStripMenuItem1.Text = "version";
            // 
            // rCoSSiteToolStripMenuItem
            // 
            this.rCoSSiteToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rCoSSiteToolStripMenuItem.Name = "rCoSSiteToolStripMenuItem";
            this.rCoSSiteToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.rCoSSiteToolStripMenuItem.Text = "rcossdk.com";
            this.rCoSSiteToolStripMenuItem.Click += new System.EventHandler(this.rCoSSiteToolStripMenuItem_Click);
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledBlinkToolStripMenuItem,
            this.buzzerToolStripMenuItem,
            this.encoderToolStripMenuItem,
            this.reflexGameToolStripMenuItem});
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.examplesToolStripMenuItem.Text = "Examples";
            // 
            // ledBlinkToolStripMenuItem
            // 
            this.ledBlinkToolStripMenuItem.Name = "ledBlinkToolStripMenuItem";
            this.ledBlinkToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ledBlinkToolStripMenuItem.Text = "Single Blink";
            this.ledBlinkToolStripMenuItem.Click += new System.EventHandler(this.ledBlinkToolStripMenuItem_Click);
            // 
            // buzzerToolStripMenuItem
            // 
            this.buzzerToolStripMenuItem.Name = "buzzerToolStripMenuItem";
            this.buzzerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.buzzerToolStripMenuItem.Text = "Buzzer";
            this.buzzerToolStripMenuItem.Click += new System.EventHandler(this.buzzerToolStripMenuItem_Click);
            // 
            // encoderToolStripMenuItem
            // 
            this.encoderToolStripMenuItem.Name = "encoderToolStripMenuItem";
            this.encoderToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.encoderToolStripMenuItem.Text = "Encoder";
            this.encoderToolStripMenuItem.Click += new System.EventHandler(this.encoderToolStripMenuItem_Click);
            // 
            // reflexGameToolStripMenuItem
            // 
            this.reflexGameToolStripMenuItem.Name = "reflexGameToolStripMenuItem";
            this.reflexGameToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.reflexGameToolStripMenuItem.Text = "Reflex Game";
            this.reflexGameToolStripMenuItem.Click += new System.EventHandler(this.reflexGameToolStripMenuItem_Click);
            // 
            // arcelikToolStripMenuItem
            // 
            this.arcelikToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.arcelikToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arcelikToolStripMenuItem.Image")));
            this.arcelikToolStripMenuItem.Name = "arcelikToolStripMenuItem";
            this.arcelikToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.arcelikToolStripMenuItem.Text = "Arcelik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 278);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(219, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 278);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.Control;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(94, 25);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(62, 62);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 43;
            this.Logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(160, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 51);
            this.label4.TabIndex = 44;
            this.label4.Text = "RCoS+ Creator";
            // 
            // FreeRTOSButton
            // 
            this.FreeRTOSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FreeRTOSButton.Location = new System.Drawing.Point(2, 88);
            this.FreeRTOSButton.Margin = new System.Windows.Forms.Padding(2);
            this.FreeRTOSButton.Name = "FreeRTOSButton";
            this.FreeRTOSButton.Size = new System.Drawing.Size(106, 31);
            this.FreeRTOSButton.TabIndex = 45;
            this.FreeRTOSButton.Text = "FreeRTOS";
            this.FreeRTOSButton.UseVisualStyleBackColor = true;
            this.FreeRTOSButton.Click += new System.EventHandler(this.FreeRTOSButton_Click);
            // 
            // AIButton
            // 
            this.AIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AIButton.Location = new System.Drawing.Point(331, 88);
            this.AIButton.Margin = new System.Windows.Forms.Padding(2);
            this.AIButton.Name = "AIButton";
            this.AIButton.Size = new System.Drawing.Size(58, 31);
            this.AIButton.TabIndex = 48;
            this.AIButton.Text = "AI";
            this.AIButton.UseVisualStyleBackColor = true;
            this.AIButton.Click += new System.EventHandler(this.AIButton_Click);
            // 
            // CodeSizeButton
            // 
            this.CodeSizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CodeSizeButton.Location = new System.Drawing.Point(393, 88);
            this.CodeSizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.CodeSizeButton.Name = "CodeSizeButton";
            this.CodeSizeButton.Size = new System.Drawing.Size(185, 31);
            this.CodeSizeButton.TabIndex = 49;
            this.CodeSizeButton.Text = "Estimated Code Size";
            this.CodeSizeButton.UseVisualStyleBackColor = true;
            // 
            // SecureButton
            // 
            this.SecureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecureButton.Location = new System.Drawing.Point(112, 88);
            this.SecureButton.Margin = new System.Windows.Forms.Padding(2);
            this.SecureButton.Name = "SecureButton";
            this.SecureButton.Size = new System.Drawing.Size(106, 31);
            this.SecureButton.TabIndex = 50;
            this.SecureButton.Text = "Secure";
            this.SecureButton.UseVisualStyleBackColor = true;
            this.SecureButton.Click += new System.EventHandler(this.SecureButton_Click);
            // 
            // ClassBButton
            // 
            this.ClassBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClassBButton.Location = new System.Drawing.Point(223, 88);
            this.ClassBButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClassBButton.Name = "ClassBButton";
            this.ClassBButton.Size = new System.Drawing.Size(106, 31);
            this.ClassBButton.TabIndex = 51;
            this.ClassBButton.Text = "Class B";
            this.ClassBButton.UseVisualStyleBackColor = true;
            this.ClassBButton.Click += new System.EventHandler(this.ClassBButton_Click);
            // 
            // CodeSize
            // 
            this.CodeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CodeSize.Location = new System.Drawing.Point(573, 88);
            this.CodeSize.Margin = new System.Windows.Forms.Padding(2);
            this.CodeSize.Name = "CodeSize";
            this.CodeSize.Size = new System.Drawing.Size(62, 31);
            this.CodeSize.TabIndex = 52;
            this.CodeSize.Text = "0 KB";
            this.CodeSize.UseVisualStyleBackColor = true;
            // 
            // devCpxCount
            // 
            this.devCpxCount.Location = new System.Drawing.Point(143, 301);
            this.devCpxCount.Margin = new System.Windows.Forms.Padding(2);
            this.devCpxCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.devCpxCount.Name = "devCpxCount";
            this.devCpxCount.Size = new System.Drawing.Size(62, 20);
            this.devCpxCount.TabIndex = 54;
            // 
            // devCpx
            // 
            this.devCpx.Location = new System.Drawing.Point(30, 301);
            this.devCpx.Margin = new System.Windows.Forms.Padding(2);
            this.devCpx.Multiline = false;
            this.devCpx.Name = "devCpx";
            this.devCpx.ReadOnly = true;
            this.devCpx.Size = new System.Drawing.Size(110, 20);
            this.devCpx.TabIndex = 53;
            this.devCpx.Text = "DevCpx";
            // 
            // devMemCount
            // 
            this.devMemCount.Location = new System.Drawing.Point(143, 325);
            this.devMemCount.Margin = new System.Windows.Forms.Padding(2);
            this.devMemCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.devMemCount.Name = "devMemCount";
            this.devMemCount.Size = new System.Drawing.Size(62, 20);
            this.devMemCount.TabIndex = 56;
            // 
            // devMem
            // 
            this.devMem.Location = new System.Drawing.Point(30, 325);
            this.devMem.Margin = new System.Windows.Forms.Padding(2);
            this.devMem.Multiline = false;
            this.devMem.Name = "devMem";
            this.devMem.ReadOnly = true;
            this.devMem.Size = new System.Drawing.Size(110, 20);
            this.devMem.TabIndex = 55;
            this.devMem.Text = "DevMem";
            // 
            // CreatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 845);
            this.Controls.Add(this.devMemCount);
            this.Controls.Add(this.devMem);
            this.Controls.Add(this.devCpxCount);
            this.Controls.Add(this.devCpx);
            this.Controls.Add(this.ClassBButton);
            this.Controls.Add(this.SecureButton);
            this.Controls.Add(this.CodeSizeButton);
            this.Controls.Add(this.AIButton);
            this.Controls.Add(this.FreeRTOSButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Logo);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CodeSize);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreatorWindow";
            this.Text = "RCoS+ Creator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerEventsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devIOCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCpxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemCount)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem test3ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem madeByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emreKarabekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çağrıHocaoğluToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem rCoSSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledBlinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buzzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encoderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflexGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FreeRTOSButton;
        private System.Windows.Forms.Button AIButton;
        private System.Windows.Forms.Button CodeSizeButton;
        private System.Windows.Forms.Button SecureButton;
        private System.Windows.Forms.Button ClassBButton;
        private System.Windows.Forms.Button CodeSize;
        private System.Windows.Forms.NumericUpDown devCpxCount;
        private System.Windows.Forms.RichTextBox devCpx;
        private System.Windows.Forms.NumericUpDown devMemCount;
        private System.Windows.Forms.RichTextBox devMem;
        private System.Windows.Forms.ToolStripMenuItem arcelikToolStripMenuItem;
    }
}

