namespace Доставим_за_15_минут_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.grandma1 = new System.Windows.Forms.PictureBox();
            this.grandma2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandma2)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg1.BackgroundImage")));
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.InitialImage = null;
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(840, 650);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(300, 407);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 192);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bg2
            // 
            this.bg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg2.BackgroundImage")));
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(0, -650);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(840, 650);
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // grandma1
            // 
            this.grandma1.BackColor = System.Drawing.Color.Transparent;
            this.grandma1.Image = ((System.Drawing.Image)(resources.GetObject("grandma1.Image")));
            this.grandma1.Location = new System.Drawing.Point(154, -160);
            this.grandma1.Name = "grandma1";
            this.grandma1.Size = new System.Drawing.Size(135, 151);
            this.grandma1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grandma1.TabIndex = 3;
            this.grandma1.TabStop = false;
            // 
            // grandma2
            // 
            this.grandma2.BackColor = System.Drawing.Color.Transparent;
            this.grandma2.Image = ((System.Drawing.Image)(resources.GetObject("grandma2.Image")));
            this.grandma2.Location = new System.Drawing.Point(526, -400);
            this.grandma2.Name = "grandma2";
            this.grandma2.Size = new System.Drawing.Size(135, 151);
            this.grandma2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grandma2.TabIndex = 4;
            this.grandma2.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Transparent;
            this.labelLose.Font = new System.Drawing.Font("Castellar", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.ForeColor = System.Drawing.Color.DeepPink;
            this.labelLose.Location = new System.Drawing.Point(135, 253);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(582, 77);
            this.labelLose.TabIndex = 5;
            this.labelLose.Text = "ВЫ ПРОИГРАЛИ!";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Gray;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(242, 333);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(343, 41);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "ПЕРЕЗАПУСТИТЬ";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.player);
            this.Controls.Add(this.grandma2);
            this.Controls.Add(this.grandma1);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доставим за 15 минут!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandma2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox grandma1;
        private System.Windows.Forms.PictureBox grandma2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button btnRestart;
    }
}

