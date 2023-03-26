
namespace WindowsFormsApp1
{
    partial class Where_We_Fly_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Where_We_Fly_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airlineDBDataSet = new WindowsFormsApp1.AirlineDBDataSet();
            this.whereWeFlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whereWeFlyTableAdapter = new WindowsFormsApp1.AirlineDBDataSetTableAdapters.WhereWeFlyTableAdapter();
            this.labelBook = new System.Windows.Forms.Label();
            this.btnClickBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Flight_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whereWeFlyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonX);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnP);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnH);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 64);
            this.panel1.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(928, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 31);
            this.button10.TabIndex = 6;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Yellow;
            this.btnL.Location = new System.Drawing.Point(762, 9);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(114, 39);
            this.btnL.TabIndex = 9;
            this.btnL.Text = "Log In";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(548, 9);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(140, 40);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "Contact Us";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(432, 9);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(94, 40);
            this.btnP.TabIndex = 5;
            this.btnP.Text = "Pricing";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(264, 9);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(152, 39);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "Schedules";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnH.Location = new System.Drawing.Point(14, 9);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(94, 39);
            this.btnH.TabIndex = 2;
            this.btnH.Text = "Home";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(114, 9);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(144, 40);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "About Us";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.Color.White;
            this.buttonX.Location = new System.Drawing.Point(892, 3);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(34, 31);
            this.buttonX.TabIndex = 7;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flight_id,
            this.destinationDataGridViewTextBoxColumn,
            this.Origin});
            this.dataGridView1.DataSource = this.whereWeFlyBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(1, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 179);
            this.dataGridView1.TabIndex = 3;
            // 
            // airlineDBDataSet
            // 
            this.airlineDBDataSet.DataSetName = "AirlineDBDataSet";
            this.airlineDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // whereWeFlyBindingSource
            // 
            this.whereWeFlyBindingSource.DataMember = "WhereWeFly";
            this.whereWeFlyBindingSource.DataSource = this.airlineDBDataSet;
            // 
            // whereWeFlyTableAdapter
            // 
            this.whereWeFlyTableAdapter.ClearBeforeFill = true;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.Location = new System.Drawing.Point(689, 363);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(99, 20);
            this.labelBook.TabIndex = 18;
            this.labelBook.Text = "For Booking:";
            // 
            // btnClickBook
            // 
            this.btnClickBook.BackColor = System.Drawing.Color.Transparent;
            this.btnClickBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickBook.Location = new System.Drawing.Point(794, 354);
            this.btnClickBook.Name = "btnClickBook";
            this.btnClickBook.Size = new System.Drawing.Size(126, 39);
            this.btnClickBook.TabIndex = 20;
            this.btnClickBook.TabStop = false;
            this.btnClickBook.Text = "click here";
            this.btnClickBook.UseVisualStyleBackColor = false;
            this.btnClickBook.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(690, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(750, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "mhtravels@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "We have  over 50 destinations to offer you to relax and have amazing adventures.\r" +
    "\n";
            // 
            // Flight_id
            // 
            this.Flight_id.DataPropertyName = "Flight_id";
            this.Flight_id.HeaderText = "Flight_id";
            this.Flight_id.Name = "Flight_id";
            this.Flight_id.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // Origin
            // 
            this.Origin.DataPropertyName = "Origin";
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            // 
            // Where_We_Fly_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClickBook);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Where_We_Fly_Form";
            this.Text = "Where_We_Fly_Form";
            this.Load += new System.EventHandler(this.Where_We_Fly_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whereWeFlyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AirlineDBDataSet airlineDBDataSet;
        private System.Windows.Forms.BindingSource whereWeFlyBindingSource;
        private AirlineDBDataSetTableAdapters.WhereWeFlyTableAdapter whereWeFlyTableAdapter;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Button btnClickBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
    }
}