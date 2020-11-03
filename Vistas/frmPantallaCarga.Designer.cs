namespace Vistas
{
    partial class frmPantallaCarga
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
            this.timerAparecer = new System.Windows.Forms.Timer(this.components);
            this.timerDesaparecer = new System.Windows.Forms.Timer(this.components);
            this.cajitaAnimada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.barraProgreso = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.cajitaAnimada)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAparecer
            // 
            this.timerAparecer.Interval = 150;
            this.timerAparecer.Tick += new System.EventHandler(this.timerAparecer_Tick);
            // 
            // timerDesaparecer
            // 
            this.timerDesaparecer.Interval = 75;
            this.timerDesaparecer.Tick += new System.EventHandler(this.timerDesaparecer_Tick);
            // 
            // cajitaAnimada
            // 
            this.cajitaAnimada.Image = global::Vistas.Properties.Resources.Shaco_Carga;
            this.cajitaAnimada.Location = new System.Drawing.Point(211, 150);
            this.cajitaAnimada.Name = "cajitaAnimada";
            this.cajitaAnimada.Size = new System.Drawing.Size(163, 200);
            this.cajitaAnimada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cajitaAnimada.TabIndex = 2;
            this.cajitaAnimada.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loading . . .";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Black;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(177, 116);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 21);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // barraProgreso
            // 
            this.barraProgreso.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.barraProgreso.AnimationSpeed = 500;
            this.barraProgreso.BackColor = System.Drawing.Color.Transparent;
            this.barraProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barraProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraProgreso.ForeColor = System.Drawing.Color.White;
            this.barraProgreso.InnerColor = System.Drawing.Color.Black;
            this.barraProgreso.InnerMargin = 2;
            this.barraProgreso.InnerWidth = -1;
            this.barraProgreso.Location = new System.Drawing.Point(0, 0);
            this.barraProgreso.MarqueeAnimationSpeed = 1000;
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.OuterColor = System.Drawing.Color.Black;
            this.barraProgreso.OuterMargin = -25;
            this.barraProgreso.OuterWidth = 26;
            this.barraProgreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barraProgreso.ProgressWidth = 30;
            this.barraProgreso.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.barraProgreso.Size = new System.Drawing.Size(585, 585);
            this.barraProgreso.StartAngle = 270;
            this.barraProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgreso.SubscriptColor = System.Drawing.Color.White;
            this.barraProgreso.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.barraProgreso.SubscriptText = "";
            this.barraProgreso.SuperscriptColor = System.Drawing.Color.White;
            this.barraProgreso.SuperscriptMargin = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.barraProgreso.SuperscriptText = "%";
            this.barraProgreso.TabIndex = 5;
            this.barraProgreso.Text = "0";
            this.barraProgreso.TextMargin = new System.Windows.Forms.Padding(12, 120, 0, 0);
            this.barraProgreso.Value = 68;
            // 
            // frmPantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(585, 585);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cajitaAnimada);
            this.Controls.Add(this.barraProgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaCarga";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPantallaCarga";
            this.Load += new System.EventHandler(this.frmPantallaCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cajitaAnimada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAparecer;
        private System.Windows.Forms.Timer timerDesaparecer;
        private System.Windows.Forms.PictureBox cajitaAnimada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private CircularProgressBar.CircularProgressBar barraProgreso;


    }
}