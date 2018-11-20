namespace Principal
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_simulaciones = new System.Windows.Forms.DataGridView();
            this.gb_datos_iniciales = new System.Windows.Forms.GroupBox();
            this.gb_recalibracion = new System.Windows.Forms.GroupBox();
            this.txt_puesta_alfombras = new System.Windows.Forms.MaskedTextBox();
            this.gb_darsenas = new System.Windows.Forms.GroupBox();
            this.txt_aspirado_b = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_b = new System.Windows.Forms.Label();
            this.txt_aspirado_a = new System.Windows.Forms.TextBox();
            this.lbl_darsenas_a = new System.Windows.Forms.Label();
            this.gb_balanza = new System.Windows.Forms.GroupBox();
            this.txt_lavado_b = new System.Windows.Forms.TextBox();
            this.lbl_balanza_b = new System.Windows.Forms.Label();
            this.txt_lavado_a = new System.Windows.Forms.TextBox();
            this.lbl_balanza_a = new System.Windows.Forms.Label();
            this.gb_recepcion = new System.Windows.Forms.GroupBox();
            this.txt_tiempoQA = new System.Windows.Forms.MaskedTextBox();
            this.gb_llegadas = new System.Windows.Forms.GroupBox();
            this.txt_llegadas_media = new System.Windows.Forms.TextBox();
            this.lbl_llegadas_lambda = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_aspirado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_aspirado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_lavadero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_lavadero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_lavadero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_lavadero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_lavadero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_lavadero_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_secado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_secado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_PA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_PA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_PA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_atendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_long_cola_QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).BeginInit();
            this.gb_datos_iniciales.SuspendLayout();
            this.gb_recalibracion.SuspendLayout();
            this.gb_darsenas.SuspendLayout();
            this.gb_balanza.SuspendLayout();
            this.gb_recepcion.SuspendLayout();
            this.gb_llegadas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_simulaciones
            // 
            this.dgv_simulaciones.AllowUserToAddRows = false;
            this.dgv_simulaciones.AllowUserToDeleteRows = false;
            this.dgv_simulaciones.AllowUserToResizeColumns = false;
            this.dgv_simulaciones.AllowUserToResizeRows = false;
            this.dgv_simulaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_simulaciones.CausesValidation = false;
            this.dgv_simulaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_simulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_simulaciones.ColumnHeadersHeight = 41;
            this.dgv_simulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_simulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.proxima_llegada,
            this.cola_QA,
            this.estado_QA,
            this.proximo_fin_QA,
            this.cola_aspirado,
            this.estado_aspirado,
            this.proximo_fin_balanza,
            this.cola_LS,
            this.estado_lavadero1,
            this.proximo_fin_lavadero1,
            this.atendidos_lavadero1,
            this.estado_lavadero2,
            this.proximo_fin_lavadero2,
            this.atendidos_lavadero_2,
            this.estado_secado,
            this.proximo_fin_secado,
            this.cola_PA,
            this.estado_PA,
            this.proximo_fin_PA,
            this.total_atendidos,
            this.permanencia,
            this.max_long_cola_QA});
            this.dgv_simulaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_simulaciones.EnableHeadersVisualStyles = false;
            this.dgv_simulaciones.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgv_simulaciones.Location = new System.Drawing.Point(12, 179);
            this.dgv_simulaciones.Name = "dgv_simulaciones";
            this.dgv_simulaciones.RowHeadersVisible = false;
            this.dgv_simulaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_simulaciones.RowTemplate.ReadOnly = true;
            this.dgv_simulaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_simulaciones.ShowCellErrors = false;
            this.dgv_simulaciones.ShowCellToolTips = false;
            this.dgv_simulaciones.ShowEditingIcon = false;
            this.dgv_simulaciones.ShowRowErrors = false;
            this.dgv_simulaciones.Size = new System.Drawing.Size(1137, 385);
            this.dgv_simulaciones.TabIndex = 29;
            // 
            // gb_datos_iniciales
            // 
            this.gb_datos_iniciales.Controls.Add(this.gb_recalibracion);
            this.gb_datos_iniciales.Controls.Add(this.gb_darsenas);
            this.gb_datos_iniciales.Controls.Add(this.gb_balanza);
            this.gb_datos_iniciales.Controls.Add(this.gb_recepcion);
            this.gb_datos_iniciales.Controls.Add(this.gb_llegadas);
            this.gb_datos_iniciales.Controls.Add(this.txt_hasta);
            this.gb_datos_iniciales.Controls.Add(this.txt_desde);
            this.gb_datos_iniciales.Controls.Add(this.txt_dias);
            this.gb_datos_iniciales.Controls.Add(this.lbl_dias);
            this.gb_datos_iniciales.Controls.Add(this.lbl_hasta);
            this.gb_datos_iniciales.Controls.Add(this.lbl_desde);
            this.gb_datos_iniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_iniciales.Location = new System.Drawing.Point(12, 12);
            this.gb_datos_iniciales.Name = "gb_datos_iniciales";
            this.gb_datos_iniciales.Size = new System.Drawing.Size(925, 102);
            this.gb_datos_iniciales.TabIndex = 30;
            this.gb_datos_iniciales.TabStop = false;
            this.gb_datos_iniciales.Text = "Datos Iniciales:";
            // 
            // gb_recalibracion
            // 
            this.gb_recalibracion.Controls.Add(this.txt_puesta_alfombras);
            this.gb_recalibracion.Location = new System.Drawing.Point(767, 13);
            this.gb_recalibracion.Name = "gb_recalibracion";
            this.gb_recalibracion.Size = new System.Drawing.Size(152, 82);
            this.gb_recalibracion.TabIndex = 17;
            this.gb_recalibracion.TabStop = false;
            this.gb_recalibracion.Text = "Poner Alfombras (PA)";
            // 
            // txt_puesta_alfombras
            // 
            this.txt_puesta_alfombras.Location = new System.Drawing.Point(26, 31);
            this.txt_puesta_alfombras.Mask = "00:00:00";
            this.txt_puesta_alfombras.Name = "txt_puesta_alfombras";
            this.txt_puesta_alfombras.Size = new System.Drawing.Size(100, 20);
            this.txt_puesta_alfombras.TabIndex = 5;
            this.txt_puesta_alfombras.Text = "000300";
            this.txt_puesta_alfombras.ValidatingType = typeof(System.DateTime);
            // 
            // gb_darsenas
            // 
            this.gb_darsenas.Controls.Add(this.txt_aspirado_b);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_b);
            this.gb_darsenas.Controls.Add(this.txt_aspirado_a);
            this.gb_darsenas.Controls.Add(this.lbl_darsenas_a);
            this.gb_darsenas.Location = new System.Drawing.Point(636, 13);
            this.gb_darsenas.Name = "gb_darsenas";
            this.gb_darsenas.Size = new System.Drawing.Size(125, 82);
            this.gb_darsenas.TabIndex = 16;
            this.gb_darsenas.TabStop = false;
            this.gb_darsenas.Text = "Aspirado (AA)";
            // 
            // txt_aspirado_b
            // 
            this.txt_aspirado_b.Location = new System.Drawing.Point(55, 48);
            this.txt_aspirado_b.Name = "txt_aspirado_b";
            this.txt_aspirado_b.Size = new System.Drawing.Size(37, 20);
            this.txt_aspirado_b.TabIndex = 3;
            this.txt_aspirado_b.Text = "5";
            // 
            // lbl_darsenas_b
            // 
            this.lbl_darsenas_b.AutoSize = true;
            this.lbl_darsenas_b.Location = new System.Drawing.Point(30, 51);
            this.lbl_darsenas_b.Name = "lbl_darsenas_b";
            this.lbl_darsenas_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_darsenas_b.TabIndex = 2;
            this.lbl_darsenas_b.Text = "B:";
            // 
            // txt_aspirado_a
            // 
            this.txt_aspirado_a.Location = new System.Drawing.Point(55, 22);
            this.txt_aspirado_a.Name = "txt_aspirado_a";
            this.txt_aspirado_a.Size = new System.Drawing.Size(37, 20);
            this.txt_aspirado_a.TabIndex = 1;
            this.txt_aspirado_a.Text = "3";
            // 
            // lbl_darsenas_a
            // 
            this.lbl_darsenas_a.AutoSize = true;
            this.lbl_darsenas_a.Location = new System.Drawing.Point(30, 25);
            this.lbl_darsenas_a.Name = "lbl_darsenas_a";
            this.lbl_darsenas_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_darsenas_a.TabIndex = 0;
            this.lbl_darsenas_a.Text = "A:";
            // 
            // gb_balanza
            // 
            this.gb_balanza.Controls.Add(this.txt_lavado_b);
            this.gb_balanza.Controls.Add(this.lbl_balanza_b);
            this.gb_balanza.Controls.Add(this.txt_lavado_a);
            this.gb_balanza.Controls.Add(this.lbl_balanza_a);
            this.gb_balanza.Location = new System.Drawing.Point(505, 13);
            this.gb_balanza.Name = "gb_balanza";
            this.gb_balanza.Size = new System.Drawing.Size(125, 82);
            this.gb_balanza.TabIndex = 8;
            this.gb_balanza.TabStop = false;
            this.gb_balanza.Text = "Lavado (L)";
            // 
            // txt_lavado_b
            // 
            this.txt_lavado_b.Location = new System.Drawing.Point(51, 48);
            this.txt_lavado_b.Name = "txt_lavado_b";
            this.txt_lavado_b.Size = new System.Drawing.Size(37, 20);
            this.txt_lavado_b.TabIndex = 3;
            this.txt_lavado_b.Text = "12";
            // 
            // lbl_balanza_b
            // 
            this.lbl_balanza_b.AutoSize = true;
            this.lbl_balanza_b.Location = new System.Drawing.Point(26, 51);
            this.lbl_balanza_b.Name = "lbl_balanza_b";
            this.lbl_balanza_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_balanza_b.TabIndex = 2;
            this.lbl_balanza_b.Text = "B:";
            // 
            // txt_lavado_a
            // 
            this.txt_lavado_a.Location = new System.Drawing.Point(51, 22);
            this.txt_lavado_a.Name = "txt_lavado_a";
            this.txt_lavado_a.Size = new System.Drawing.Size(37, 20);
            this.txt_lavado_a.TabIndex = 1;
            this.txt_lavado_a.Text = "6";
            // 
            // lbl_balanza_a
            // 
            this.lbl_balanza_a.AutoSize = true;
            this.lbl_balanza_a.Location = new System.Drawing.Point(26, 25);
            this.lbl_balanza_a.Name = "lbl_balanza_a";
            this.lbl_balanza_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_balanza_a.TabIndex = 0;
            this.lbl_balanza_a.Text = "A:";
            // 
            // gb_recepcion
            // 
            this.gb_recepcion.Controls.Add(this.txt_tiempoQA);
            this.gb_recepcion.Location = new System.Drawing.Point(319, 13);
            this.gb_recepcion.Name = "gb_recepcion";
            this.gb_recepcion.Size = new System.Drawing.Size(179, 82);
            this.gb_recepcion.TabIndex = 7;
            this.gb_recepcion.TabStop = false;
            this.gb_recepcion.Text = "Quitado de Alfombras (QA)";
            // 
            // txt_tiempoQA
            // 
            this.txt_tiempoQA.Location = new System.Drawing.Point(46, 31);
            this.txt_tiempoQA.Mask = "00:00:00";
            this.txt_tiempoQA.Name = "txt_tiempoQA";
            this.txt_tiempoQA.Size = new System.Drawing.Size(100, 20);
            this.txt_tiempoQA.TabIndex = 4;
            this.txt_tiempoQA.Text = "000200";
            this.txt_tiempoQA.ValidatingType = typeof(System.DateTime);
            // 
            // gb_llegadas
            // 
            this.gb_llegadas.Controls.Add(this.txt_llegadas_media);
            this.gb_llegadas.Controls.Add(this.lbl_llegadas_lambda);
            this.gb_llegadas.Location = new System.Drawing.Point(196, 13);
            this.gb_llegadas.Name = "gb_llegadas";
            this.gb_llegadas.Size = new System.Drawing.Size(117, 82);
            this.gb_llegadas.TabIndex = 6;
            this.gb_llegadas.TabStop = false;
            this.gb_llegadas.Text = "Llegadas Autos";
            // 
            // txt_llegadas_media
            // 
            this.txt_llegadas_media.Location = new System.Drawing.Point(60, 33);
            this.txt_llegadas_media.Name = "txt_llegadas_media";
            this.txt_llegadas_media.Size = new System.Drawing.Size(51, 20);
            this.txt_llegadas_media.TabIndex = 1;
            this.txt_llegadas_media.Text = "10";
            // 
            // lbl_llegadas_lambda
            // 
            this.lbl_llegadas_lambda.AutoSize = true;
            this.lbl_llegadas_lambda.Location = new System.Drawing.Point(9, 36);
            this.lbl_llegadas_lambda.Name = "lbl_llegadas_lambda";
            this.lbl_llegadas_lambda.Size = new System.Drawing.Size(45, 13);
            this.lbl_llegadas_lambda.TabIndex = 0;
            this.lbl_llegadas_lambda.Text = "Media:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(114, 71);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(54, 20);
            this.txt_hasta.TabIndex = 5;
            this.txt_hasta.Text = "100";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(114, 45);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(54, 20);
            this.txt_desde.TabIndex = 4;
            this.txt_desde.Text = "1";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(114, 19);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(54, 20);
            this.txt_dias.TabIndex = 3;
            this.txt_dias.Text = "30";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(11, 22);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(38, 13);
            this.lbl_dias.TabIndex = 2;
            this.lbl_dias.Text = "Días:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(11, 74);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(88, 13);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Mostrar hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(11, 48);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(91, 13);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Mostrar desde:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_evento);
            this.groupBox1.Controls.Add(this.txt_hora);
            this.groupBox1.Controls.Add(this.txt_dia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(943, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulación:";
            // 
            // txt_evento
            // 
            this.txt_evento.CausesValidation = false;
            this.txt_evento.Enabled = false;
            this.txt_evento.Location = new System.Drawing.Point(63, 71);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.ReadOnly = true;
            this.txt_evento.Size = new System.Drawing.Size(100, 20);
            this.txt_evento.TabIndex = 5;
            // 
            // txt_hora
            // 
            this.txt_hora.CausesValidation = false;
            this.txt_hora.Enabled = false;
            this.txt_hora.Location = new System.Drawing.Point(63, 45);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.ReadOnly = true;
            this.txt_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_hora.TabIndex = 4;
            // 
            // txt_dia
            // 
            this.txt_dia.CausesValidation = false;
            this.txt_dia.Enabled = false;
            this.txt_dia.Location = new System.Drawing.Point(63, 19);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.ReadOnly = true;
            this.txt_dia.Size = new System.Drawing.Size(100, 20);
            this.txt_dia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Día:";
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.Location = new System.Drawing.Point(568, 127);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(80, 33);
            this.btn_detener.TabIndex = 32;
            this.btn_detener.Text = "PARAR";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(482, 127);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(80, 33);
            this.btn_simular.TabIndex = 31;
            this.btn_simular.Text = "SIMULAR";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reloj.FillWeight = 1F;
            this.reloj.Frozen = true;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reloj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reloj.Width = 55;
            // 
            // evento
            // 
            this.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.evento.FillWeight = 1F;
            this.evento.Frozen = true;
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.evento.Width = 150;
            // 
            // proxima_llegada
            // 
            this.proxima_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proxima_llegada.FillWeight = 1F;
            this.proxima_llegada.HeaderText = "Próxima Llegada";
            this.proxima_llegada.Name = "proxima_llegada";
            this.proxima_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proxima_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proxima_llegada.Width = 60;
            // 
            // cola_QA
            // 
            this.cola_QA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_QA.FillWeight = 1F;
            this.cola_QA.HeaderText = "Cola Quitado Alfombras";
            this.cola_QA.Name = "cola_QA";
            this.cola_QA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_QA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_QA.Width = 80;
            // 
            // estado_QA
            // 
            this.estado_QA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_QA.FillWeight = 1F;
            this.estado_QA.HeaderText = "Estado Quitado Alfombras";
            this.estado_QA.Name = "estado_QA";
            this.estado_QA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_QA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_QA.Width = 150;
            // 
            // proximo_fin_QA
            // 
            this.proximo_fin_QA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_QA.FillWeight = 1F;
            this.proximo_fin_QA.HeaderText = "Próximo Fin Quitado Alfombras";
            this.proximo_fin_QA.Name = "proximo_fin_QA";
            this.proximo_fin_QA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_QA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_QA.Width = 85;
            // 
            // cola_aspirado
            // 
            this.cola_aspirado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_aspirado.FillWeight = 1F;
            this.cola_aspirado.HeaderText = "Cola Aspirado";
            this.cola_aspirado.Name = "cola_aspirado";
            this.cola_aspirado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_aspirado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_aspirado.Width = 60;
            // 
            // estado_aspirado
            // 
            this.estado_aspirado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_aspirado.FillWeight = 1F;
            this.estado_aspirado.HeaderText = "Estado Aspirado";
            this.estado_aspirado.Name = "estado_aspirado";
            this.estado_aspirado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_aspirado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_aspirado.Width = 200;
            // 
            // proximo_fin_balanza
            // 
            this.proximo_fin_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_balanza.FillWeight = 1F;
            this.proximo_fin_balanza.HeaderText = "Próximo Fin Aspirado";
            this.proximo_fin_balanza.Name = "proximo_fin_balanza";
            this.proximo_fin_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_balanza.Width = 85;
            // 
            // cola_LS
            // 
            this.cola_LS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_LS.FillWeight = 1F;
            this.cola_LS.HeaderText = "Cola Lavado/Secado";
            this.cola_LS.Name = "cola_LS";
            this.cola_LS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_LS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_LS.Width = 90;
            // 
            // estado_lavadero1
            // 
            this.estado_lavadero1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_lavadero1.FillWeight = 1F;
            this.estado_lavadero1.HeaderText = "Estado Lavadero 1";
            this.estado_lavadero1.Name = "estado_lavadero1";
            this.estado_lavadero1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_lavadero1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_lavadero1.Width = 150;
            // 
            // proximo_fin_lavadero1
            // 
            this.proximo_fin_lavadero1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_lavadero1.FillWeight = 1F;
            this.proximo_fin_lavadero1.HeaderText = "Próximo Fin Lavadero 1";
            this.proximo_fin_lavadero1.Name = "proximo_fin_lavadero1";
            this.proximo_fin_lavadero1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_lavadero1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_lavadero1.Width = 85;
            // 
            // atendidos_lavadero1
            // 
            this.atendidos_lavadero1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_lavadero1.FillWeight = 1F;
            this.atendidos_lavadero1.HeaderText = "Atendidos Lavadero 1";
            this.atendidos_lavadero1.Name = "atendidos_lavadero1";
            this.atendidos_lavadero1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_lavadero1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_lavadero1.Width = 80;
            // 
            // estado_lavadero2
            // 
            this.estado_lavadero2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_lavadero2.FillWeight = 1F;
            this.estado_lavadero2.HeaderText = "Estado Lavadero 2";
            this.estado_lavadero2.Name = "estado_lavadero2";
            this.estado_lavadero2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_lavadero2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_lavadero2.Width = 150;
            // 
            // proximo_fin_lavadero2
            // 
            this.proximo_fin_lavadero2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_lavadero2.FillWeight = 1F;
            this.proximo_fin_lavadero2.HeaderText = "Próximo Fin Lavadero 2";
            this.proximo_fin_lavadero2.Name = "proximo_fin_lavadero2";
            this.proximo_fin_lavadero2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_lavadero2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_lavadero2.Width = 85;
            // 
            // atendidos_lavadero_2
            // 
            this.atendidos_lavadero_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_lavadero_2.FillWeight = 1F;
            this.atendidos_lavadero_2.HeaderText = "Atendidos Lavadero 2";
            this.atendidos_lavadero_2.Name = "atendidos_lavadero_2";
            this.atendidos_lavadero_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_lavadero_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_lavadero_2.Width = 80;
            // 
            // estado_secado
            // 
            this.estado_secado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_secado.HeaderText = "Estado Secado";
            this.estado_secado.Name = "estado_secado";
            this.estado_secado.Width = 150;
            // 
            // proximo_fin_secado
            // 
            this.proximo_fin_secado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_secado.HeaderText = "Proximo Fin Secadora";
            this.proximo_fin_secado.Name = "proximo_fin_secado";
            // 
            // cola_PA
            // 
            this.cola_PA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_PA.FillWeight = 1F;
            this.cola_PA.HeaderText = "Cola Colocacion Alfombras";
            this.cola_PA.Name = "cola_PA";
            this.cola_PA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_PA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_PA.Width = 70;
            // 
            // estado_PA
            // 
            this.estado_PA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_PA.HeaderText = "Estado Colocacion Alfombras";
            this.estado_PA.Name = "estado_PA";
            this.estado_PA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_PA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // proximo_fin_PA
            // 
            this.proximo_fin_PA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_PA.HeaderText = "Prox. Fin Colocacion Alfombras";
            this.proximo_fin_PA.Name = "proximo_fin_PA";
            this.proximo_fin_PA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_PA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_atendidos
            // 
            this.total_atendidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_atendidos.FillWeight = 1F;
            this.total_atendidos.HeaderText = "Total Atendidos";
            this.total_atendidos.Name = "total_atendidos";
            this.total_atendidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_atendidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total_atendidos.Width = 70;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.permanencia.FillWeight = 1F;
            this.permanencia.HeaderText = "Permanencia Promedio";
            this.permanencia.Name = "permanencia";
            this.permanencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.permanencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.permanencia.Width = 90;
            // 
            // max_long_cola_QA
            // 
            this.max_long_cola_QA.HeaderText = "Maxima Long Cola";
            this.max_long_cola_QA.Name = "max_long_cola_QA";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 596);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_datos_iniciales);
            this.Controls.Add(this.dgv_simulaciones);
            this.Name = "principal";
            this.Text = "TRABAJO PRACTICO FINAL ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).EndInit();
            this.gb_datos_iniciales.ResumeLayout(false);
            this.gb_datos_iniciales.PerformLayout();
            this.gb_recalibracion.ResumeLayout(false);
            this.gb_recalibracion.PerformLayout();
            this.gb_darsenas.ResumeLayout(false);
            this.gb_darsenas.PerformLayout();
            this.gb_balanza.ResumeLayout(false);
            this.gb_balanza.PerformLayout();
            this.gb_recepcion.ResumeLayout(false);
            this.gb_recepcion.PerformLayout();
            this.gb_llegadas.ResumeLayout(false);
            this.gb_llegadas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_simulaciones;
        private System.Windows.Forms.GroupBox gb_datos_iniciales;
        private System.Windows.Forms.GroupBox gb_recalibracion;
        private System.Windows.Forms.GroupBox gb_darsenas;
        private System.Windows.Forms.TextBox txt_aspirado_b;
        private System.Windows.Forms.Label lbl_darsenas_b;
        private System.Windows.Forms.TextBox txt_aspirado_a;
        private System.Windows.Forms.Label lbl_darsenas_a;
        private System.Windows.Forms.GroupBox gb_balanza;
        private System.Windows.Forms.TextBox txt_lavado_b;
        private System.Windows.Forms.Label lbl_balanza_b;
        private System.Windows.Forms.TextBox txt_lavado_a;
        private System.Windows.Forms.Label lbl_balanza_a;
        private System.Windows.Forms.GroupBox gb_recepcion;
        private System.Windows.Forms.GroupBox gb_llegadas;
        private System.Windows.Forms.TextBox txt_llegadas_media;
        private System.Windows.Forms.Label lbl_llegadas_lambda;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.MaskedTextBox txt_tiempoQA;
        private System.Windows.Forms.MaskedTextBox txt_puesta_alfombras;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_QA;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_QA;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_QA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_aspirado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_aspirado;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_lavadero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_lavadero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_lavadero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_lavadero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_lavadero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_lavadero_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_secado;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_secado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_PA;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_PA;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_PA;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_atendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_long_cola_QA;
    }
}

