namespace pryGalizziMeteorologia
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.krDtpFecha = new Krypton.Toolkit.KryptonDateTimePicker();
            this.krLsvTemperaturas = new Krypton.Toolkit.KryptonListView();
            this.colTmpMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTmpMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.krTvwUbicaciones = new Krypton.Toolkit.KryptonTreeView();
            this.krLblUbicaciones = new Krypton.Toolkit.KryptonLabel();
            this.krLblFecha = new Krypton.Toolkit.KryptonLabel();
            this.krSstSeleccion = new Krypton.Toolkit.KryptonStatusStrip();
            this.krLblTemperaturas = new Krypton.Toolkit.KryptonLabel();
            this.lblProvincia = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLocalidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.krSstSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // krDtpFecha
            // 
            this.krDtpFecha.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Form;
            this.krDtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.krDtpFecha.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.krDtpFecha.Location = new System.Drawing.Point(115, 32);
            this.krDtpFecha.Name = "krDtpFecha";
            this.krDtpFecha.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            this.krDtpFecha.Size = new System.Drawing.Size(104, 25);
            this.krDtpFecha.TabIndex = 0;
            this.krDtpFecha.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.krDtpFecha.ValueChanged += new System.EventHandler(this.krDtpFecha_ValueChanged);
            // 
            // krLsvTemperaturas
            // 
            this.krLsvTemperaturas.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnSheet;
            this.krLsvTemperaturas.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.krLsvTemperaturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTmpMin,
            this.colTmpMax});
            this.krLsvTemperaturas.HideSelection = false;
            this.krLsvTemperaturas.Location = new System.Drawing.Point(333, 110);
            this.krLsvTemperaturas.Name = "krLsvTemperaturas";
            this.krLsvTemperaturas.Size = new System.Drawing.Size(362, 131);
            this.krLsvTemperaturas.TabIndex = 1;
            this.krLsvTemperaturas.View = System.Windows.Forms.View.Details;
            this.krLsvTemperaturas.Click += new System.EventHandler(this.krLsvTemperaturas_Click);
            // 
            // colTmpMin
            // 
            this.colTmpMin.Text = "Temp. Mínima";
            this.colTmpMin.Width = 150;
            // 
            // colTmpMax
            // 
            this.colTmpMax.Text = "Temp. Máxima";
            this.colTmpMax.Width = 150;
            // 
            // krTvwUbicaciones
            // 
            this.krTvwUbicaciones.BackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.krTvwUbicaciones.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderColumnList;
            this.krTvwUbicaciones.Location = new System.Drawing.Point(41, 110);
            this.krTvwUbicaciones.Name = "krTvwUbicaciones";
            this.krTvwUbicaciones.Size = new System.Drawing.Size(245, 371);
            this.krTvwUbicaciones.TabIndex = 2;
            this.krTvwUbicaciones.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.krTvwUbicaciones_AfterSelect);
            // 
            // krLblUbicaciones
            // 
            this.krLblUbicaciones.Location = new System.Drawing.Point(41, 80);
            this.krLblUbicaciones.Name = "krLblUbicaciones";
            this.krLblUbicaciones.Size = new System.Drawing.Size(93, 24);
            this.krLblUbicaciones.TabIndex = 3;
            this.krLblUbicaciones.Values.Text = "Ubicaciones";
            // 
            // krLblFecha
            // 
            this.krLblFecha.Location = new System.Drawing.Point(41, 32);
            this.krLblFecha.Name = "krLblFecha";
            this.krLblFecha.Size = new System.Drawing.Size(51, 24);
            this.krLblFecha.TabIndex = 4;
            this.krLblFecha.Values.Text = "Fecha";
            // 
            // krSstSeleccion
            // 
            this.krSstSeleccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.krSstSeleccion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.krSstSeleccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProvincia,
            this.lblLocalidad});
            this.krSstSeleccion.Location = new System.Drawing.Point(0, 510);
            this.krSstSeleccion.Name = "krSstSeleccion";
            this.krSstSeleccion.ProgressBars = null;
            this.krSstSeleccion.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.krSstSeleccion.Size = new System.Drawing.Size(813, 26);
            this.krSstSeleccion.TabIndex = 5;
            this.krSstSeleccion.Text = "Seleccionado: ";
            // 
            // krLblTemperaturas
            // 
            this.krLblTemperaturas.Location = new System.Drawing.Point(333, 79);
            this.krLblTemperaturas.Name = "krLblTemperaturas";
            this.krLblTemperaturas.Size = new System.Drawing.Size(105, 24);
            this.krLblTemperaturas.TabIndex = 6;
            this.krLblTemperaturas.Values.Text = "Temperaturas";
            // 
            // lblProvincia
            // 
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(15, 20);
            this.lblProvincia.Text = "-";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(15, 20);
            this.lblLocalidad.Text = "-";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(813, 536);
            this.Controls.Add(this.krLblTemperaturas);
            this.Controls.Add(this.krSstSeleccion);
            this.Controls.Add(this.krLblFecha);
            this.Controls.Add(this.krLblUbicaciones);
            this.Controls.Add(this.krTvwUbicaciones);
            this.Controls.Add(this.krLsvTemperaturas);
            this.Controls.Add(this.krDtpFecha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meteorología";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.krSstSeleccion.ResumeLayout(false);
            this.krSstSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDateTimePicker krDtpFecha;
        private Krypton.Toolkit.KryptonListView krLsvTemperaturas;
        private Krypton.Toolkit.KryptonTreeView krTvwUbicaciones;
        private Krypton.Toolkit.KryptonLabel krLblUbicaciones;
        private Krypton.Toolkit.KryptonLabel krLblFecha;
        private Krypton.Toolkit.KryptonStatusStrip krSstSeleccion;
        private Krypton.Toolkit.KryptonLabel krLblTemperaturas;
        private System.Windows.Forms.ColumnHeader colTmpMin;
        private System.Windows.Forms.ColumnHeader colTmpMax;
        private System.Windows.Forms.ToolStripStatusLabel lblProvincia;
        private System.Windows.Forms.ToolStripStatusLabel lblLocalidad;
    }
}