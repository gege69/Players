namespace Player
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.MidiaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.somAmbienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chamdaInstanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horóscopoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comerciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institucionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.blocosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MidiaPlayerChamada = new AxWMPLib.AxWindowsMediaPlayer();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.imagemSom = new System.Windows.Forms.PictureBox();
            this.btnChamada = new System.Windows.Forms.Button();
            this.imagemFundo = new System.Windows.Forms.PictureBox();
            this.lblLocucao = new System.Windows.Forms.Label();
            this.timerLocucao = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MidiaPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MidiaPlayerChamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemSom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // MidiaPlayer
            // 
            this.MidiaPlayer.Enabled = true;
            this.MidiaPlayer.Location = new System.Drawing.Point(12, 54);
            this.MidiaPlayer.Name = "MidiaPlayer";
            this.MidiaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MidiaPlayer.OcxState")));
            this.MidiaPlayer.Size = new System.Drawing.Size(436, 285);
            this.MidiaPlayer.TabIndex = 0;
            this.MidiaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MidiaPlayer_PlayStateChange);
            this.MidiaPlayer.Enter += new System.EventHandler(this.MidiaPlayer_Enter);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.BackColor = System.Drawing.Color.Black;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStop.Location = new System.Drawing.Point(459, 557);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 40);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.BackColor = System.Drawing.Color.Black;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPause.Location = new System.Drawing.Point(378, 557);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(72, 40);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(1052, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(149, 511);
            this.listBox.TabIndex = 6;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.BackColor = System.Drawing.Color.Black;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnList.Location = new System.Drawing.Point(1052, 557);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(149, 40);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Selecionar Lista";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(297, 557);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(542, 557);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 40);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Próxima";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnt.BackColor = System.Drawing.Color.Black;
            this.btnAnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnt.Location = new System.Drawing.Point(214, 557);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(72, 40);
            this.btnAnt.TabIndex = 9;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btn_ant_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somAmbienteToolStripMenuItem,
            this.chamadasToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1204, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // somAmbienteToolStripMenuItem
            // 
            this.somAmbienteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.somAmbienteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.somAmbienteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.somAmbienteToolStripMenuItem.Name = "somAmbienteToolStripMenuItem";
            this.somAmbienteToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.somAmbienteToolStripMenuItem.Text = "Som Ambiente";
            // 
            // chamadasToolStripMenuItem
            // 
            this.chamadasToolStripMenuItem.AutoToolTip = true;
            this.chamadasToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.chamadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietárioToolStripMenuItem,
            this.testeToolStripMenuItem1,
            this.chamdaInstanToolStripMenuItem,
            this.horóscopoToolStripMenuItem,
            this.comerciaisToolStripMenuItem,
            this.institucionaisToolStripMenuItem,
            this.programetesToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.chamadasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.chamadasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.chamadasToolStripMenuItem.Name = "chamadasToolStripMenuItem";
            this.chamadasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.chamadasToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.chamadasToolStripMenuItem.Text = "Chamadas";
            // 
            // proprietárioToolStripMenuItem
            // 
            this.proprietárioToolStripMenuItem.Name = "proprietárioToolStripMenuItem";
            this.proprietárioToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.proprietárioToolStripMenuItem.Text = "Proprietário de Veículo";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.testeToolStripMenuItem1.Text = "Funcionários";
            this.testeToolStripMenuItem1.Click += new System.EventHandler(this.testeToolStripMenuItem1_Click);
            // 
            // chamdaInstanToolStripMenuItem
            // 
            this.chamdaInstanToolStripMenuItem.Name = "chamdaInstanToolStripMenuItem";
            this.chamdaInstanToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.chamdaInstanToolStripMenuItem.Text = "Chamda Instantâneas";
            // 
            // horóscopoToolStripMenuItem
            // 
            this.horóscopoToolStripMenuItem.Name = "horóscopoToolStripMenuItem";
            this.horóscopoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.horóscopoToolStripMenuItem.Text = "Horóscopo";
            // 
            // comerciaisToolStripMenuItem
            // 
            this.comerciaisToolStripMenuItem.Name = "comerciaisToolStripMenuItem";
            this.comerciaisToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.comerciaisToolStripMenuItem.Text = "Comerciais";
            // 
            // institucionaisToolStripMenuItem
            // 
            this.institucionaisToolStripMenuItem.Name = "institucionaisToolStripMenuItem";
            this.institucionaisToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.institucionaisToolStripMenuItem.Text = "Institucionais";
            // 
            // programetesToolStripMenuItem
            // 
            this.programetesToolStripMenuItem.Name = "programetesToolStripMenuItem";
            this.programetesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.programetesToolStripMenuItem.Text = "Programetes";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.AutoToolTip = true;
            this.configuraçõesToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem2,
            this.blocosToolStripMenuItem,
            this.noBreakToolStripMenuItem,
            this.downloadsToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.ToolTipText = "Configurações";
            // 
            // testeToolStripMenuItem2
            // 
            this.testeToolStripMenuItem2.Name = "testeToolStripMenuItem2";
            this.testeToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.testeToolStripMenuItem2.Text = "Gêneros";
            // 
            // blocosToolStripMenuItem
            // 
            this.blocosToolStripMenuItem.Name = "blocosToolStripMenuItem";
            this.blocosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.blocosToolStripMenuItem.Text = "Blocos";
            // 
            // noBreakToolStripMenuItem
            // 
            this.noBreakToolStripMenuItem.Name = "noBreakToolStripMenuItem";
            this.noBreakToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.noBreakToolStripMenuItem.Text = "No-Break";
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.AutoToolTip = true;
            this.relatóriosToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.ToolTipText = "Relatórios";
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.AutoToolTip = true;
            this.atendimentoToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.atendimentoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.atendimentoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.ToolTipText = "Atendimento";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.desconectarToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.desconectarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // MidiaPlayerChamada
            // 
            this.MidiaPlayerChamada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MidiaPlayerChamada.Enabled = true;
            this.MidiaPlayerChamada.Location = new System.Drawing.Point(264, 239);
            this.MidiaPlayerChamada.Name = "MidiaPlayerChamada";
            this.MidiaPlayerChamada.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MidiaPlayerChamada.OcxState")));
            this.MidiaPlayerChamada.Size = new System.Drawing.Size(75, 23);
            this.MidiaPlayerChamada.TabIndex = 13;
            this.MidiaPlayerChamada.Visible = false;
            this.MidiaPlayerChamada.Enter += new System.EventHandler(this.MidiaPlayerChamada_Enter);
            // 
            // trbVolume
            // 
            this.trbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbVolume.Location = new System.Drawing.Point(882, 557);
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(164, 45);
            this.trbVolume.TabIndex = 14;
            this.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // imagemSom
            // 
            this.imagemSom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemSom.BackColor = System.Drawing.Color.Black;
            this.imagemSom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagemSom.Image = global::Player.Properties.Resources.som1;
            this.imagemSom.Location = new System.Drawing.Point(861, 557);
            this.imagemSom.Name = "imagemSom";
            this.imagemSom.Size = new System.Drawing.Size(27, 23);
            this.imagemSom.TabIndex = 15;
            this.imagemSom.TabStop = false;
            // 
            // btnChamada
            // 
            this.btnChamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChamada.AutoEllipsis = true;
            this.btnChamada.BackColor = System.Drawing.Color.Transparent;
            this.btnChamada.BackgroundImage = global::Player.Properties.Resources.mic1;
            this.btnChamada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChamada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamada.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChamada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnChamada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnChamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamada.Image = global::Player.Properties.Resources.mic1;
            this.btnChamada.Location = new System.Drawing.Point(12, 475);
            this.btnChamada.Name = "btnChamada";
            this.btnChamada.Size = new System.Drawing.Size(52, 76);
            this.btnChamada.TabIndex = 12;
            this.btnChamada.Text = "Chamada";
            this.btnChamada.UseVisualStyleBackColor = false;
            this.btnChamada.Click += new System.EventHandler(this.btnChamada_Click);
            // 
            // imagemFundo
            // 
            this.imagemFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemFundo.BackgroundImage = global::Player.Properties.Resources.som_arte;
            this.imagemFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagemFundo.Location = new System.Drawing.Point(12, 43);
            this.imagemFundo.Name = "imagemFundo";
            this.imagemFundo.Size = new System.Drawing.Size(1034, 508);
            this.imagemFundo.TabIndex = 10;
            this.imagemFundo.TabStop = false;
            // 
            // lblLocucao
            // 
            this.lblLocucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocucao.AutoSize = true;
            this.lblLocucao.BackColor = System.Drawing.Color.Transparent;
            this.lblLocucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLocucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocucao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocucao.Location = new System.Drawing.Point(70, 507);
            this.lblLocucao.Name = "lblLocucao";
            this.lblLocucao.Size = new System.Drawing.Size(90, 13);
            this.lblLocucao.TabIndex = 18;
            this.lblLocucao.Text = "Parar Locução";
            this.lblLocucao.Visible = false;
            this.lblLocucao.Click += new System.EventHandler(this.lblLocucao_Click);
            // 
            // timerLocucao
            // 
            this.timerLocucao.Interval = 1000;
            this.timerLocucao.Tick += new System.EventHandler(this.timerLocucao_Tick);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1204, 694);
            this.Controls.Add(this.lblLocucao);
            this.Controls.Add(this.imagemSom);
            this.Controls.Add(this.trbVolume);
            this.Controls.Add(this.btnChamada);
            this.Controls.Add(this.imagemFundo);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.MidiaPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MidiaPlayerChamada);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player - Rádio";
            ((System.ComponentModel.ISupportInitialize)(this.MidiaPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MidiaPlayerChamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemSom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MidiaPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somAmbienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem blocosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private System.Windows.Forms.PictureBox imagemFundo;
        private System.Windows.Forms.ToolStripMenuItem proprietárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chamdaInstanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horóscopoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comerciaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institucionaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.Button btnChamada;
        private AxWMPLib.AxWindowsMediaPlayer MidiaPlayerChamada;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.PictureBox imagemSom;
        private System.Windows.Forms.Label lblLocucao;
        private System.Windows.Forms.Timer timerLocucao;
    }
}

