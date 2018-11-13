namespace TP_N_7___Bar
{
    partial class TP7_Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_continua = new System.Windows.Forms.GroupBox();
            this.txt_valor_h = new System.Windows.Forms.TextBox();
            this.txt_litros_vaso = new System.Windows.Forms.TextBox();
            this.lbl_valor_h = new System.Windows.Forms.Label();
            this.lbl_litros_vaso = new System.Windows.Forms.Label();
            this.dgv_simulaciones = new System.Windows.Forms.DataGridView();
            this.gb_solucion = new System.Windows.Forms.GroupBox();
            this.txt_espera_maxima = new System.Windows.Forms.TextBox();
            this.lbl_espera_maxima = new System.Windows.Forms.Label();
            this.txt_consumen_masuna = new System.Windows.Forms.TextBox();
            this.lbl_consume_masuna = new System.Windows.Forms.Label();
            this.txt_no_atendidos = new System.Windows.Forms.TextBox();
            this.lbl_no_atendidos = new System.Windows.Forms.Label();
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_simular = new System.Windows.Forms.Button();
            this.gb_datos_iniciales = new System.Windows.Forms.GroupBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_eventos = new System.Windows.Forms.TextBox();
            this.lbl_eventos = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.gb_actual = new System.Windows.Forms.GroupBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.gb_llegadas = new System.Windows.Forms.GroupBox();
            this.txt_llegadas_mediaxhora = new System.Windows.Forms.TextBox();
            this.lbl_llegadas_mediaxhora = new System.Windows.Forms.Label();
            this.gb_servir = new System.Windows.Forms.GroupBox();
            this.txt_servir_b = new System.Windows.Forms.TextBox();
            this.lbl_servir_b = new System.Windows.Forms.Label();
            this.txt_servir_a = new System.Windows.Forms.TextBox();
            this.lbl_servir_a = new System.Windows.Forms.Label();
            this.gb_lavar = new System.Windows.Forms.GroupBox();
            this.txt_const_lavar = new System.Windows.Forms.TextBox();
            this.lbl_lavar_const = new System.Windows.Forms.Label();
            this.gb_recoger = new System.Windows.Forms.GroupBox();
            this.lbl_recoge_masveinte = new System.Windows.Forms.Label();
            this.txt_recoge_masviente = new System.Windows.Forms.TextBox();
            this.txt_recoge_diezyveinte = new System.Windows.Forms.TextBox();
            this.lbl_recoge_diezyveinte = new System.Windows.Forms.Label();
            this.txt_recoge_menosdiez = new System.Windows.Forms.TextBox();
            this.lbl_recoge_menordiez = new System.Windows.Forms.Label();
            this.gb_clientes_a_servir = new System.Windows.Forms.GroupBox();
            this.txt_maximo_cola = new System.Windows.Forms.TextBox();
            this.lbl_maximo_cola = new System.Windows.Forms.Label();
            this.lbl_vasos_iniciales = new System.Windows.Forms.Label();
            this.txt_vasos_iniciales = new System.Windows.Forms.TextBox();
            this.lbl_promedio_espera = new System.Windows.Forms.Label();
            this.txt_promedio_espera = new System.Windows.Forms.TextBox();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasos_limpios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasos_usandose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasos_a_recoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasos_a_lavar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_servir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_servir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random_servir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_servir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_servir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_lavar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_lavar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_lavar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_lavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_lavar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_darsenas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_recoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_recoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sin_atender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_consumieron_masuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espera_maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espera_promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_continua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).BeginInit();
            this.gb_solucion.SuspendLayout();
            this.gb_datos_iniciales.SuspendLayout();
            this.gb_actual.SuspendLayout();
            this.gb_llegadas.SuspendLayout();
            this.gb_servir.SuspendLayout();
            this.gb_lavar.SuspendLayout();
            this.gb_recoger.SuspendLayout();
            this.gb_clientes_a_servir.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_continua
            // 
            this.gb_continua.BackColor = System.Drawing.Color.Transparent;
            this.gb_continua.Controls.Add(this.txt_valor_h);
            this.gb_continua.Controls.Add(this.txt_litros_vaso);
            this.gb_continua.Controls.Add(this.lbl_valor_h);
            this.gb_continua.Controls.Add(this.lbl_litros_vaso);
            this.gb_continua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_continua.Location = new System.Drawing.Point(677, 11);
            this.gb_continua.Name = "gb_continua";
            this.gb_continua.Size = new System.Drawing.Size(159, 75);
            this.gb_continua.TabIndex = 40;
            this.gb_continua.TabStop = false;
            this.gb_continua.Text = "Datos para Continua:";
            // 
            // txt_valor_h
            // 
            this.txt_valor_h.Location = new System.Drawing.Point(111, 46);
            this.txt_valor_h.Name = "txt_valor_h";
            this.txt_valor_h.Size = new System.Drawing.Size(37, 20);
            this.txt_valor_h.TabIndex = 13;
            this.txt_valor_h.Text = "1";
            // 
            // txt_litros_vaso
            // 
            this.txt_litros_vaso.Location = new System.Drawing.Point(111, 20);
            this.txt_litros_vaso.Name = "txt_litros_vaso";
            this.txt_litros_vaso.Size = new System.Drawing.Size(37, 20);
            this.txt_litros_vaso.TabIndex = 12;
            this.txt_litros_vaso.Text = "450";
            // 
            // lbl_valor_h
            // 
            this.lbl_valor_h.AutoSize = true;
            this.lbl_valor_h.Location = new System.Drawing.Point(56, 48);
            this.lbl_valor_h.Name = "lbl_valor_h";
            this.lbl_valor_h.Size = new System.Drawing.Size(49, 13);
            this.lbl_valor_h.TabIndex = 42;
            this.lbl_valor_h.Text = "h (min):";
            // 
            // lbl_litros_vaso
            // 
            this.lbl_litros_vaso.AutoSize = true;
            this.lbl_litros_vaso.Location = new System.Drawing.Point(10, 22);
            this.lbl_litros_vaso.Name = "lbl_litros_vaso";
            this.lbl_litros_vaso.Size = new System.Drawing.Size(95, 13);
            this.lbl_litros_vaso.TabIndex = 41;
            this.lbl_litros_vaso.Text = "Capacidad (ml):";
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
            this.dgv_simulaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
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
            this.random_llegada,
            this.tiempo_llegada,
            this.proxima_llegada,
            this.vasos_limpios,
            this.vasos_usandose,
            this.vasos_a_recoger,
            this.vasos_a_lavar,
            this.cola_servir,
            this.estado_servir,
            this.random_servir,
            this.tiempo_servir,
            this.proximo_fin_servir,
            this.cola_lavar,
            this.estado_lavar,
            this.cantidad_lavar,
            this.tiempo_lavado,
            this.proximo_fin_lavar,
            this.cola_darsenas,
            this.estado_darsena_1,
            this.cantidad_recoger,
            this.tiempo_recoger,
            this.proximo_fin_darsena_1,
            this.sin_atender,
            this.total_consumieron_masuna,
            this.espera_maxima,
            this.espera_promedio});
            this.dgv_simulaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_simulaciones.EnableHeadersVisualStyles = false;
            this.dgv_simulaciones.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgv_simulaciones.Location = new System.Drawing.Point(12, 120);
            this.dgv_simulaciones.Name = "dgv_simulaciones";
            this.dgv_simulaciones.ReadOnly = true;
            this.dgv_simulaciones.RowHeadersVisible = false;
            this.dgv_simulaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_simulaciones.RowTemplate.ReadOnly = true;
            this.dgv_simulaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_simulaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_simulaciones.ShowCellErrors = false;
            this.dgv_simulaciones.ShowCellToolTips = false;
            this.dgv_simulaciones.ShowEditingIcon = false;
            this.dgv_simulaciones.ShowRowErrors = false;
            this.dgv_simulaciones.Size = new System.Drawing.Size(1390, 429);
            this.dgv_simulaciones.TabIndex = 22;
            // 
            // gb_solucion
            // 
            this.gb_solucion.BackColor = System.Drawing.Color.Transparent;
            this.gb_solucion.Controls.Add(this.txt_promedio_espera);
            this.gb_solucion.Controls.Add(this.lbl_promedio_espera);
            this.gb_solucion.Controls.Add(this.txt_espera_maxima);
            this.gb_solucion.Controls.Add(this.lbl_espera_maxima);
            this.gb_solucion.Controls.Add(this.txt_consumen_masuna);
            this.gb_solucion.Controls.Add(this.lbl_consume_masuna);
            this.gb_solucion.Controls.Add(this.txt_no_atendidos);
            this.gb_solucion.Controls.Add(this.lbl_no_atendidos);
            this.gb_solucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_solucion.Location = new System.Drawing.Point(1026, 12);
            this.gb_solucion.Name = "gb_solucion";
            this.gb_solucion.Size = new System.Drawing.Size(373, 102);
            this.gb_solucion.TabIndex = 46;
            this.gb_solucion.TabStop = false;
            this.gb_solucion.Text = "SOLUCION:";
            // 
            // txt_espera_maxima
            // 
            this.txt_espera_maxima.Enabled = false;
            this.txt_espera_maxima.Location = new System.Drawing.Point(272, 25);
            this.txt_espera_maxima.Name = "txt_espera_maxima";
            this.txt_espera_maxima.Size = new System.Drawing.Size(89, 20);
            this.txt_espera_maxima.TabIndex = 19;
            // 
            // lbl_espera_maxima
            // 
            this.lbl_espera_maxima.Location = new System.Drawing.Point(170, 18);
            this.lbl_espera_maxima.Name = "lbl_espera_maxima";
            this.lbl_espera_maxima.Size = new System.Drawing.Size(96, 33);
            this.lbl_espera_maxima.TabIndex = 48;
            this.lbl_espera_maxima.Text = "Espera Maxima de un Cliente";
            this.lbl_espera_maxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_consumen_masuna
            // 
            this.txt_consumen_masuna.Enabled = false;
            this.txt_consumen_masuna.Location = new System.Drawing.Point(97, 66);
            this.txt_consumen_masuna.Name = "txt_consumen_masuna";
            this.txt_consumen_masuna.Size = new System.Drawing.Size(62, 20);
            this.txt_consumen_masuna.TabIndex = 20;
            // 
            // lbl_consume_masuna
            // 
            this.lbl_consume_masuna.Location = new System.Drawing.Point(6, 51);
            this.lbl_consume_masuna.Name = "lbl_consume_masuna";
            this.lbl_consume_masuna.Size = new System.Drawing.Size(87, 46);
            this.lbl_consume_masuna.TabIndex = 49;
            this.lbl_consume_masuna.Text = "Clientes que consumieron más de 1 vez:";
            this.lbl_consume_masuna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_no_atendidos
            // 
            this.txt_no_atendidos.Enabled = false;
            this.txt_no_atendidos.Location = new System.Drawing.Point(97, 25);
            this.txt_no_atendidos.Name = "txt_no_atendidos";
            this.txt_no_atendidos.Size = new System.Drawing.Size(62, 20);
            this.txt_no_atendidos.TabIndex = 18;
            // 
            // lbl_no_atendidos
            // 
            this.lbl_no_atendidos.Location = new System.Drawing.Point(6, 18);
            this.lbl_no_atendidos.Name = "lbl_no_atendidos";
            this.lbl_no_atendidos.Size = new System.Drawing.Size(87, 33);
            this.lbl_no_atendidos.TabIndex = 47;
            this.lbl_no_atendidos.Text = "Clientes No Atendidos:";
            this.lbl_no_atendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_detener
            // 
            this.btn_detener.BackColor = System.Drawing.SystemColors.Control;
            this.btn_detener.Enabled = false;
            this.btn_detener.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.Location = new System.Drawing.Point(934, 71);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(80, 33);
            this.btn_detener.TabIndex = 16;
            this.btn_detener.Text = "PARAR";
            this.btn_detener.UseVisualStyleBackColor = false;
            // 
            // btn_simular
            // 
            this.btn_simular.BackColor = System.Drawing.SystemColors.Control;
            this.btn_simular.Enabled = false;
            this.btn_simular.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(848, 71);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(80, 33);
            this.btn_simular.TabIndex = 15;
            this.btn_simular.Text = "SIMULAR";
            this.btn_simular.UseVisualStyleBackColor = false;
            // 
            // gb_datos_iniciales
            // 
            this.gb_datos_iniciales.BackColor = System.Drawing.Color.Transparent;
            this.gb_datos_iniciales.Controls.Add(this.txt_hasta);
            this.gb_datos_iniciales.Controls.Add(this.txt_desde);
            this.gb_datos_iniciales.Controls.Add(this.txt_eventos);
            this.gb_datos_iniciales.Controls.Add(this.lbl_eventos);
            this.gb_datos_iniciales.Controls.Add(this.lbl_hasta);
            this.gb_datos_iniciales.Controls.Add(this.lbl_desde);
            this.gb_datos_iniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datos_iniciales.Location = new System.Drawing.Point(12, 11);
            this.gb_datos_iniciales.Name = "gb_datos_iniciales";
            this.gb_datos_iniciales.Size = new System.Drawing.Size(173, 103);
            this.gb_datos_iniciales.TabIndex = 23;
            this.gb_datos_iniciales.TabStop = false;
            this.gb_datos_iniciales.Text = "Datos Iniciales:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(105, 71);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(54, 20);
            this.txt_hasta.TabIndex = 3;
            this.txt_hasta.Text = "1000";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(105, 45);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(54, 20);
            this.txt_desde.TabIndex = 2;
            this.txt_desde.Text = "1";
            // 
            // txt_eventos
            // 
            this.txt_eventos.Location = new System.Drawing.Point(105, 19);
            this.txt_eventos.Name = "txt_eventos";
            this.txt_eventos.Size = new System.Drawing.Size(54, 20);
            this.txt_eventos.TabIndex = 1;
            this.txt_eventos.Text = "100000";
            // 
            // lbl_eventos
            // 
            this.lbl_eventos.AutoSize = true;
            this.lbl_eventos.Location = new System.Drawing.Point(11, 22);
            this.lbl_eventos.Name = "lbl_eventos";
            this.lbl_eventos.Size = new System.Drawing.Size(91, 13);
            this.lbl_eventos.TabIndex = 24;
            this.lbl_eventos.Text = "Cant. Eventos:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(14, 74);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(88, 13);
            this.lbl_hasta.TabIndex = 26;
            this.lbl_hasta.Text = "Mostrar hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(11, 48);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(91, 13);
            this.lbl_desde.TabIndex = 25;
            this.lbl_desde.Text = "Mostrar desde:";
            // 
            // gb_actual
            // 
            this.gb_actual.BackColor = System.Drawing.Color.Transparent;
            this.gb_actual.Controls.Add(this.txt_evento);
            this.gb_actual.Controls.Add(this.lbl_evento);
            this.gb_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_actual.Location = new System.Drawing.Point(842, 12);
            this.gb_actual.Name = "gb_actual";
            this.gb_actual.Size = new System.Drawing.Size(178, 53);
            this.gb_actual.TabIndex = 44;
            this.gb_actual.TabStop = false;
            this.gb_actual.Text = "Simulación:";
            // 
            // txt_evento
            // 
            this.txt_evento.CausesValidation = false;
            this.txt_evento.Enabled = false;
            this.txt_evento.Location = new System.Drawing.Point(66, 19);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.ReadOnly = true;
            this.txt_evento.Size = new System.Drawing.Size(100, 20);
            this.txt_evento.TabIndex = 17;
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(9, 22);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(51, 13);
            this.lbl_evento.TabIndex = 45;
            this.lbl_evento.Text = "Evento:";
            // 
            // gb_llegadas
            // 
            this.gb_llegadas.BackColor = System.Drawing.Color.Transparent;
            this.gb_llegadas.Controls.Add(this.txt_llegadas_mediaxhora);
            this.gb_llegadas.Controls.Add(this.lbl_llegadas_mediaxhora);
            this.gb_llegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_llegadas.Location = new System.Drawing.Point(191, 11);
            this.gb_llegadas.Name = "gb_llegadas";
            this.gb_llegadas.Size = new System.Drawing.Size(167, 48);
            this.gb_llegadas.TabIndex = 27;
            this.gb_llegadas.TabStop = false;
            this.gb_llegadas.Text = "Llegadas Clientes (hora):";
            // 
            // txt_llegadas_mediaxhora
            // 
            this.txt_llegadas_mediaxhora.Location = new System.Drawing.Point(89, 19);
            this.txt_llegadas_mediaxhora.Name = "txt_llegadas_mediaxhora";
            this.txt_llegadas_mediaxhora.Size = new System.Drawing.Size(34, 20);
            this.txt_llegadas_mediaxhora.TabIndex = 4;
            this.txt_llegadas_mediaxhora.Text = "30";
            // 
            // lbl_llegadas_mediaxhora
            // 
            this.lbl_llegadas_mediaxhora.AutoSize = true;
            this.lbl_llegadas_mediaxhora.Location = new System.Drawing.Point(38, 22);
            this.lbl_llegadas_mediaxhora.Name = "lbl_llegadas_mediaxhora";
            this.lbl_llegadas_mediaxhora.Size = new System.Drawing.Size(45, 13);
            this.lbl_llegadas_mediaxhora.TabIndex = 28;
            this.lbl_llegadas_mediaxhora.Text = "Media:";
            // 
            // gb_servir
            // 
            this.gb_servir.BackColor = System.Drawing.Color.Transparent;
            this.gb_servir.Controls.Add(this.txt_servir_b);
            this.gb_servir.Controls.Add(this.lbl_servir_b);
            this.gb_servir.Controls.Add(this.txt_servir_a);
            this.gb_servir.Controls.Add(this.lbl_servir_a);
            this.gb_servir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_servir.Location = new System.Drawing.Point(364, 11);
            this.gb_servir.Name = "gb_servir";
            this.gb_servir.Size = new System.Drawing.Size(151, 48);
            this.gb_servir.TabIndex = 31;
            this.gb_servir.TabStop = false;
            this.gb_servir.Text = "Servir Cervezas (min):";
            // 
            // txt_servir_b
            // 
            this.txt_servir_b.Location = new System.Drawing.Point(102, 19);
            this.txt_servir_b.Name = "txt_servir_b";
            this.txt_servir_b.Size = new System.Drawing.Size(37, 20);
            this.txt_servir_b.TabIndex = 7;
            this.txt_servir_b.Text = "2";
            // 
            // lbl_servir_b
            // 
            this.lbl_servir_b.AutoSize = true;
            this.lbl_servir_b.Location = new System.Drawing.Point(77, 22);
            this.lbl_servir_b.Name = "lbl_servir_b";
            this.lbl_servir_b.Size = new System.Drawing.Size(19, 13);
            this.lbl_servir_b.TabIndex = 33;
            this.lbl_servir_b.Text = "B:";
            // 
            // txt_servir_a
            // 
            this.txt_servir_a.Location = new System.Drawing.Point(34, 19);
            this.txt_servir_a.Name = "txt_servir_a";
            this.txt_servir_a.Size = new System.Drawing.Size(37, 20);
            this.txt_servir_a.TabIndex = 6;
            this.txt_servir_a.Text = "1";
            // 
            // lbl_servir_a
            // 
            this.lbl_servir_a.AutoSize = true;
            this.lbl_servir_a.Location = new System.Drawing.Point(9, 22);
            this.lbl_servir_a.Name = "lbl_servir_a";
            this.lbl_servir_a.Size = new System.Drawing.Size(19, 13);
            this.lbl_servir_a.TabIndex = 32;
            this.lbl_servir_a.Text = "A:";
            // 
            // gb_lavar
            // 
            this.gb_lavar.BackColor = System.Drawing.Color.Transparent;
            this.gb_lavar.Controls.Add(this.txt_const_lavar);
            this.gb_lavar.Controls.Add(this.lbl_lavar_const);
            this.gb_lavar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_lavar.Location = new System.Drawing.Point(364, 65);
            this.gb_lavar.Name = "gb_lavar";
            this.gb_lavar.Size = new System.Drawing.Size(151, 49);
            this.gb_lavar.TabIndex = 34;
            this.gb_lavar.TabStop = false;
            this.gb_lavar.Text = "Lavar Vasos (seg):";
            // 
            // txt_const_lavar
            // 
            this.txt_const_lavar.Location = new System.Drawing.Point(87, 19);
            this.txt_const_lavar.Name = "txt_const_lavar";
            this.txt_const_lavar.Size = new System.Drawing.Size(37, 20);
            this.txt_const_lavar.TabIndex = 8;
            this.txt_const_lavar.Text = "15";
            // 
            // lbl_lavar_const
            // 
            this.lbl_lavar_const.AutoSize = true;
            this.lbl_lavar_const.Location = new System.Drawing.Point(13, 22);
            this.lbl_lavar_const.Name = "lbl_lavar_const";
            this.lbl_lavar_const.Size = new System.Drawing.Size(68, 13);
            this.lbl_lavar_const.TabIndex = 35;
            this.lbl_lavar_const.Text = "Constante:";
            // 
            // gb_recoger
            // 
            this.gb_recoger.BackColor = System.Drawing.Color.Transparent;
            this.gb_recoger.Controls.Add(this.lbl_recoge_masveinte);
            this.gb_recoger.Controls.Add(this.txt_recoge_masviente);
            this.gb_recoger.Controls.Add(this.txt_recoge_diezyveinte);
            this.gb_recoger.Controls.Add(this.lbl_recoge_diezyveinte);
            this.gb_recoger.Controls.Add(this.txt_recoge_menosdiez);
            this.gb_recoger.Controls.Add(this.lbl_recoge_menordiez);
            this.gb_recoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_recoger.Location = new System.Drawing.Point(521, 11);
            this.gb_recoger.Name = "gb_recoger";
            this.gb_recoger.Size = new System.Drawing.Size(149, 103);
            this.gb_recoger.TabIndex = 36;
            this.gb_recoger.TabStop = false;
            this.gb_recoger.Text = "Recoger Vasos (min):";
            // 
            // lbl_recoge_masveinte
            // 
            this.lbl_recoge_masveinte.AutoSize = true;
            this.lbl_recoge_masveinte.Location = new System.Drawing.Point(25, 74);
            this.lbl_recoge_masveinte.Name = "lbl_recoge_masveinte";
            this.lbl_recoge_masveinte.Size = new System.Drawing.Size(70, 13);
            this.lbl_recoge_masveinte.TabIndex = 39;
            this.lbl_recoge_masveinte.Text = "Más de 20:";
            // 
            // txt_recoge_masviente
            // 
            this.txt_recoge_masviente.Location = new System.Drawing.Point(100, 70);
            this.txt_recoge_masviente.Name = "txt_recoge_masviente";
            this.txt_recoge_masviente.Size = new System.Drawing.Size(37, 20);
            this.txt_recoge_masviente.TabIndex = 11;
            this.txt_recoge_masviente.Text = "8";
            // 
            // txt_recoge_diezyveinte
            // 
            this.txt_recoge_diezyveinte.Location = new System.Drawing.Point(100, 44);
            this.txt_recoge_diezyveinte.Name = "txt_recoge_diezyveinte";
            this.txt_recoge_diezyveinte.Size = new System.Drawing.Size(37, 20);
            this.txt_recoge_diezyveinte.TabIndex = 10;
            this.txt_recoge_diezyveinte.Text = "6";
            // 
            // lbl_recoge_diezyveinte
            // 
            this.lbl_recoge_diezyveinte.AutoSize = true;
            this.lbl_recoge_diezyveinte.Location = new System.Drawing.Point(8, 47);
            this.lbl_recoge_diezyveinte.Name = "lbl_recoge_diezyveinte";
            this.lbl_recoge_diezyveinte.Size = new System.Drawing.Size(87, 13);
            this.lbl_recoge_diezyveinte.TabIndex = 38;
            this.lbl_recoge_diezyveinte.Text = "Entre 10 y 20:";
            // 
            // txt_recoge_menosdiez
            // 
            this.txt_recoge_menosdiez.Location = new System.Drawing.Point(100, 18);
            this.txt_recoge_menosdiez.Name = "txt_recoge_menosdiez";
            this.txt_recoge_menosdiez.Size = new System.Drawing.Size(37, 20);
            this.txt_recoge_menosdiez.TabIndex = 9;
            this.txt_recoge_menosdiez.Text = "4";
            // 
            // lbl_recoge_menordiez
            // 
            this.lbl_recoge_menordiez.AutoSize = true;
            this.lbl_recoge_menordiez.Location = new System.Drawing.Point(11, 21);
            this.lbl_recoge_menordiez.Name = "lbl_recoge_menordiez";
            this.lbl_recoge_menordiez.Size = new System.Drawing.Size(84, 13);
            this.lbl_recoge_menordiez.TabIndex = 37;
            this.lbl_recoge_menordiez.Text = "Menos de 10:";
            // 
            // gb_clientes_a_servir
            // 
            this.gb_clientes_a_servir.BackColor = System.Drawing.Color.Transparent;
            this.gb_clientes_a_servir.Controls.Add(this.lbl_maximo_cola);
            this.gb_clientes_a_servir.Controls.Add(this.txt_maximo_cola);
            this.gb_clientes_a_servir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_clientes_a_servir.Location = new System.Drawing.Point(191, 65);
            this.gb_clientes_a_servir.Name = "gb_clientes_a_servir";
            this.gb_clientes_a_servir.Size = new System.Drawing.Size(167, 49);
            this.gb_clientes_a_servir.TabIndex = 29;
            this.gb_clientes_a_servir.TabStop = false;
            this.gb_clientes_a_servir.Text = "Cola de Clientes a Servir:";
            // 
            // txt_maximo_cola
            // 
            this.txt_maximo_cola.Location = new System.Drawing.Point(89, 19);
            this.txt_maximo_cola.Name = "txt_maximo_cola";
            this.txt_maximo_cola.Size = new System.Drawing.Size(34, 20);
            this.txt_maximo_cola.TabIndex = 5;
            this.txt_maximo_cola.Text = "4";
            // 
            // lbl_maximo_cola
            // 
            this.lbl_maximo_cola.AutoSize = true;
            this.lbl_maximo_cola.Location = new System.Drawing.Point(30, 22);
            this.lbl_maximo_cola.Name = "lbl_maximo_cola";
            this.lbl_maximo_cola.Size = new System.Drawing.Size(53, 13);
            this.lbl_maximo_cola.TabIndex = 30;
            this.lbl_maximo_cola.Text = "Maximo:";
            // 
            // lbl_vasos_iniciales
            // 
            this.lbl_vasos_iniciales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vasos_iniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vasos_iniciales.Location = new System.Drawing.Point(677, 94);
            this.lbl_vasos_iniciales.Name = "lbl_vasos_iniciales";
            this.lbl_vasos_iniciales.Size = new System.Drawing.Size(116, 17);
            this.lbl_vasos_iniciales.TabIndex = 43;
            this.lbl_vasos_iniciales.Text = "Cant. Vasos Inicio:";
            // 
            // txt_vasos_iniciales
            // 
            this.txt_vasos_iniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vasos_iniciales.Location = new System.Drawing.Point(799, 91);
            this.txt_vasos_iniciales.Name = "txt_vasos_iniciales";
            this.txt_vasos_iniciales.Size = new System.Drawing.Size(37, 20);
            this.txt_vasos_iniciales.TabIndex = 14;
            this.txt_vasos_iniciales.Text = "100";
            // 
            // lbl_promedio_espera
            // 
            this.lbl_promedio_espera.Location = new System.Drawing.Point(170, 55);
            this.lbl_promedio_espera.Name = "lbl_promedio_espera";
            this.lbl_promedio_espera.Size = new System.Drawing.Size(96, 40);
            this.lbl_promedio_espera.TabIndex = 50;
            this.lbl_promedio_espera.Text = "Promedio de Espera un Cliente";
            this.lbl_promedio_espera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_promedio_espera
            // 
            this.txt_promedio_espera.Enabled = false;
            this.txt_promedio_espera.Location = new System.Drawing.Point(272, 66);
            this.txt_promedio_espera.Name = "txt_promedio_espera";
            this.txt_promedio_espera.Size = new System.Drawing.Size(89, 20);
            this.txt_promedio_espera.TabIndex = 21;
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reloj.FillWeight = 1F;
            this.reloj.Frozen = true;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
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
            this.evento.ReadOnly = true;
            this.evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.evento.Width = 80;
            // 
            // random_llegada
            // 
            this.random_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.random_llegada.FillWeight = 1F;
            this.random_llegada.HeaderText = "Random Llegada";
            this.random_llegada.Name = "random_llegada";
            this.random_llegada.ReadOnly = true;
            this.random_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.random_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.random_llegada.Width = 50;
            // 
            // tiempo_llegada
            // 
            this.tiempo_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tiempo_llegada.FillWeight = 1F;
            this.tiempo_llegada.HeaderText = "Tiempo Llegada";
            this.tiempo_llegada.Name = "tiempo_llegada";
            this.tiempo_llegada.ReadOnly = true;
            this.tiempo_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo_llegada.Width = 60;
            // 
            // proxima_llegada
            // 
            this.proxima_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proxima_llegada.FillWeight = 1F;
            this.proxima_llegada.HeaderText = "Próxima Llegada";
            this.proxima_llegada.Name = "proxima_llegada";
            this.proxima_llegada.ReadOnly = true;
            this.proxima_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proxima_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proxima_llegada.Width = 60;
            // 
            // vasos_limpios
            // 
            this.vasos_limpios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vasos_limpios.FillWeight = 1F;
            this.vasos_limpios.HeaderText = "Vasos Limpios";
            this.vasos_limpios.Name = "vasos_limpios";
            this.vasos_limpios.ReadOnly = true;
            this.vasos_limpios.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vasos_limpios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vasos_limpios.Width = 50;
            // 
            // vasos_usandose
            // 
            this.vasos_usandose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vasos_usandose.FillWeight = 1F;
            this.vasos_usandose.HeaderText = "Vasos Usandose";
            this.vasos_usandose.Name = "vasos_usandose";
            this.vasos_usandose.ReadOnly = true;
            this.vasos_usandose.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vasos_usandose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vasos_usandose.Width = 55;
            // 
            // vasos_a_recoger
            // 
            this.vasos_a_recoger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vasos_a_recoger.FillWeight = 1F;
            this.vasos_a_recoger.HeaderText = "Vasos a Recoger";
            this.vasos_a_recoger.Name = "vasos_a_recoger";
            this.vasos_a_recoger.ReadOnly = true;
            this.vasos_a_recoger.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vasos_a_recoger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vasos_a_recoger.Width = 60;
            // 
            // vasos_a_lavar
            // 
            this.vasos_a_lavar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vasos_a_lavar.FillWeight = 1F;
            this.vasos_a_lavar.HeaderText = "Vasos a Lavar";
            this.vasos_a_lavar.Name = "vasos_a_lavar";
            this.vasos_a_lavar.ReadOnly = true;
            this.vasos_a_lavar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vasos_a_lavar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vasos_a_lavar.Width = 50;
            // 
            // cola_servir
            // 
            this.cola_servir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_servir.FillWeight = 1F;
            this.cola_servir.HeaderText = "Cola a Servir";
            this.cola_servir.Name = "cola_servir";
            this.cola_servir.ReadOnly = true;
            this.cola_servir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_servir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_servir.Width = 55;
            // 
            // estado_servir
            // 
            this.estado_servir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_servir.FillWeight = 1F;
            this.estado_servir.HeaderText = "Estado Servir Cerveza";
            this.estado_servir.Name = "estado_servir";
            this.estado_servir.ReadOnly = true;
            this.estado_servir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_servir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_servir.Width = 140;
            // 
            // random_servir
            // 
            this.random_servir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.random_servir.FillWeight = 1F;
            this.random_servir.HeaderText = "Random Servir";
            this.random_servir.Name = "random_servir";
            this.random_servir.ReadOnly = true;
            this.random_servir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.random_servir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.random_servir.Width = 50;
            // 
            // tiempo_servir
            // 
            this.tiempo_servir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tiempo_servir.FillWeight = 1F;
            this.tiempo_servir.HeaderText = "Tiempo en Servir";
            this.tiempo_servir.Name = "tiempo_servir";
            this.tiempo_servir.ReadOnly = true;
            this.tiempo_servir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo_servir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo_servir.Width = 65;
            // 
            // proximo_fin_servir
            // 
            this.proximo_fin_servir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_servir.FillWeight = 1F;
            this.proximo_fin_servir.HeaderText = "Próximo Fin Servir";
            this.proximo_fin_servir.Name = "proximo_fin_servir";
            this.proximo_fin_servir.ReadOnly = true;
            this.proximo_fin_servir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_servir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_servir.Width = 65;
            // 
            // cola_lavar
            // 
            this.cola_lavar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_lavar.FillWeight = 1F;
            this.cola_lavar.HeaderText = "Cola a Lavar";
            this.cola_lavar.Name = "cola_lavar";
            this.cola_lavar.ReadOnly = true;
            this.cola_lavar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_lavar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_lavar.Width = 50;
            // 
            // estado_lavar
            // 
            this.estado_lavar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_lavar.FillWeight = 1F;
            this.estado_lavar.HeaderText = "Estado Lavar Vasos";
            this.estado_lavar.Name = "estado_lavar";
            this.estado_lavar.ReadOnly = true;
            this.estado_lavar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_lavar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_lavar.Width = 140;
            // 
            // cantidad_lavar
            // 
            this.cantidad_lavar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cantidad_lavar.FillWeight = 1F;
            this.cantidad_lavar.HeaderText = "Cantidad a Lavar";
            this.cantidad_lavar.Name = "cantidad_lavar";
            this.cantidad_lavar.ReadOnly = true;
            this.cantidad_lavar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad_lavar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad_lavar.Width = 55;
            // 
            // tiempo_lavado
            // 
            this.tiempo_lavado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tiempo_lavado.FillWeight = 1F;
            this.tiempo_lavado.HeaderText = "Tiempo en Lavado";
            this.tiempo_lavado.Name = "tiempo_lavado";
            this.tiempo_lavado.ReadOnly = true;
            this.tiempo_lavado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo_lavado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo_lavado.Width = 65;
            // 
            // proximo_fin_lavar
            // 
            this.proximo_fin_lavar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_lavar.FillWeight = 1F;
            this.proximo_fin_lavar.HeaderText = "Próximo Fin Lavar";
            this.proximo_fin_lavar.Name = "proximo_fin_lavar";
            this.proximo_fin_lavar.ReadOnly = true;
            this.proximo_fin_lavar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_lavar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_lavar.Width = 65;
            // 
            // cola_darsenas
            // 
            this.cola_darsenas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_darsenas.FillWeight = 1F;
            this.cola_darsenas.HeaderText = "Cola a Recoger";
            this.cola_darsenas.Name = "cola_darsenas";
            this.cola_darsenas.ReadOnly = true;
            this.cola_darsenas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_darsenas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_darsenas.Width = 50;
            // 
            // estado_darsena_1
            // 
            this.estado_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_1.FillWeight = 1F;
            this.estado_darsena_1.HeaderText = "Estado Recoger Vasos";
            this.estado_darsena_1.Name = "estado_darsena_1";
            this.estado_darsena_1.ReadOnly = true;
            this.estado_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_1.Width = 140;
            // 
            // cantidad_recoger
            // 
            this.cantidad_recoger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cantidad_recoger.FillWeight = 1F;
            this.cantidad_recoger.HeaderText = "Cantidad Recogida";
            this.cantidad_recoger.Name = "cantidad_recoger";
            this.cantidad_recoger.ReadOnly = true;
            this.cantidad_recoger.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad_recoger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad_recoger.Width = 55;
            // 
            // tiempo_recoger
            // 
            this.tiempo_recoger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tiempo_recoger.FillWeight = 1F;
            this.tiempo_recoger.HeaderText = "Tiempo en Recoger";
            this.tiempo_recoger.Name = "tiempo_recoger";
            this.tiempo_recoger.ReadOnly = true;
            this.tiempo_recoger.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo_recoger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo_recoger.Width = 65;
            // 
            // proximo_fin_darsena_1
            // 
            this.proximo_fin_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_1.FillWeight = 1F;
            this.proximo_fin_darsena_1.HeaderText = "Próximo Fin Recogida";
            this.proximo_fin_darsena_1.Name = "proximo_fin_darsena_1";
            this.proximo_fin_darsena_1.ReadOnly = true;
            this.proximo_fin_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_1.Width = 70;
            // 
            // sin_atender
            // 
            this.sin_atender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sin_atender.FillWeight = 1F;
            this.sin_atender.HeaderText = "Total Sin Atender";
            this.sin_atender.Name = "sin_atender";
            this.sin_atender.ReadOnly = true;
            this.sin_atender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sin_atender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sin_atender.Width = 90;
            // 
            // total_consumieron_masuna
            // 
            this.total_consumieron_masuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_consumieron_masuna.FillWeight = 1F;
            this.total_consumieron_masuna.HeaderText = "Total consumieron varias veces";
            this.total_consumieron_masuna.Name = "total_consumieron_masuna";
            this.total_consumieron_masuna.ReadOnly = true;
            this.total_consumieron_masuna.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_consumieron_masuna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total_consumieron_masuna.Width = 110;
            // 
            // espera_maxima
            // 
            this.espera_maxima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.espera_maxima.FillWeight = 1F;
            this.espera_maxima.HeaderText = "Espera Maxima";
            this.espera_maxima.Name = "espera_maxima";
            this.espera_maxima.ReadOnly = true;
            this.espera_maxima.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.espera_maxima.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.espera_maxima.Width = 75;
            // 
            // espera_promedio
            // 
            this.espera_promedio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.espera_promedio.FillWeight = 1F;
            this.espera_promedio.HeaderText = "Espera Promedio";
            this.espera_promedio.Name = "espera_promedio";
            this.espera_promedio.ReadOnly = true;
            this.espera_promedio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.espera_promedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.espera_promedio.Width = 75;
            // 
            // TP7_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::TP_N_7___Bar.Properties.Resources.wooden_background;
            this.ClientSize = new System.Drawing.Size(1414, 561);
            this.Controls.Add(this.txt_vasos_iniciales);
            this.Controls.Add(this.lbl_vasos_iniciales);
            this.Controls.Add(this.gb_clientes_a_servir);
            this.Controls.Add(this.gb_recoger);
            this.Controls.Add(this.gb_lavar);
            this.Controls.Add(this.gb_servir);
            this.Controls.Add(this.gb_llegadas);
            this.Controls.Add(this.gb_continua);
            this.Controls.Add(this.dgv_simulaciones);
            this.Controls.Add(this.gb_solucion);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.gb_datos_iniciales);
            this.Controls.Add(this.gb_actual);
            this.Name = "TP7_Principal";
            this.Text = "TP7_Principal";
            this.gb_continua.ResumeLayout(false);
            this.gb_continua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulaciones)).EndInit();
            this.gb_solucion.ResumeLayout(false);
            this.gb_solucion.PerformLayout();
            this.gb_datos_iniciales.ResumeLayout(false);
            this.gb_datos_iniciales.PerformLayout();
            this.gb_actual.ResumeLayout(false);
            this.gb_actual.PerformLayout();
            this.gb_llegadas.ResumeLayout(false);
            this.gb_llegadas.PerformLayout();
            this.gb_servir.ResumeLayout(false);
            this.gb_servir.PerformLayout();
            this.gb_lavar.ResumeLayout(false);
            this.gb_lavar.PerformLayout();
            this.gb_recoger.ResumeLayout(false);
            this.gb_recoger.PerformLayout();
            this.gb_clientes_a_servir.ResumeLayout(false);
            this.gb_clientes_a_servir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_continua;
        private System.Windows.Forms.TextBox txt_valor_h;
        private System.Windows.Forms.TextBox txt_litros_vaso;
        private System.Windows.Forms.Label lbl_valor_h;
        private System.Windows.Forms.Label lbl_litros_vaso;
        private System.Windows.Forms.DataGridView dgv_simulaciones;
        private System.Windows.Forms.GroupBox gb_solucion;
        private System.Windows.Forms.TextBox txt_espera_maxima;
        private System.Windows.Forms.Label lbl_espera_maxima;
        private System.Windows.Forms.TextBox txt_consumen_masuna;
        private System.Windows.Forms.Label lbl_consume_masuna;
        private System.Windows.Forms.TextBox txt_no_atendidos;
        private System.Windows.Forms.Label lbl_no_atendidos;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.GroupBox gb_datos_iniciales;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_eventos;
        private System.Windows.Forms.Label lbl_eventos;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox gb_actual;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.TextBox txt_promedio_espera;
        private System.Windows.Forms.Label lbl_promedio_espera;
        private System.Windows.Forms.GroupBox gb_llegadas;
        private System.Windows.Forms.TextBox txt_llegadas_mediaxhora;
        private System.Windows.Forms.Label lbl_llegadas_mediaxhora;
        private System.Windows.Forms.GroupBox gb_servir;
        private System.Windows.Forms.TextBox txt_servir_b;
        private System.Windows.Forms.Label lbl_servir_b;
        private System.Windows.Forms.TextBox txt_servir_a;
        private System.Windows.Forms.Label lbl_servir_a;
        private System.Windows.Forms.GroupBox gb_lavar;
        private System.Windows.Forms.TextBox txt_const_lavar;
        private System.Windows.Forms.Label lbl_lavar_const;
        private System.Windows.Forms.GroupBox gb_recoger;
        private System.Windows.Forms.Label lbl_recoge_masveinte;
        private System.Windows.Forms.TextBox txt_recoge_masviente;
        private System.Windows.Forms.TextBox txt_recoge_diezyveinte;
        private System.Windows.Forms.Label lbl_recoge_diezyveinte;
        private System.Windows.Forms.TextBox txt_recoge_menosdiez;
        private System.Windows.Forms.Label lbl_recoge_menordiez;
        private System.Windows.Forms.GroupBox gb_clientes_a_servir;
        private System.Windows.Forms.Label lbl_maximo_cola;
        private System.Windows.Forms.TextBox txt_maximo_cola;
        private System.Windows.Forms.Label lbl_vasos_iniciales;
        private System.Windows.Forms.TextBox txt_vasos_iniciales;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn random_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasos_limpios;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasos_usandose;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasos_a_recoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasos_a_lavar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_servir;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_servir;
        private System.Windows.Forms.DataGridViewTextBoxColumn random_servir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_servir;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_servir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_lavar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_lavar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_lavar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_lavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_lavar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_darsenas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_recoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_recoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sin_atender;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_consumieron_masuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn espera_maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn espera_promedio;
    }
}