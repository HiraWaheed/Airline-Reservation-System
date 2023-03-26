
namespace WindowsFormsApp1
{
    partial class PassengerLoggedInForm
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
            this.btnVPP = new System.Windows.Forms.Button();
            this.btnBFP = new System.Windows.Forms.Button();
            this.btnCFP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.dgvPassengerProfile = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.comboBoxSeat = new System.Windows.Forms.ComboBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.dateTimeReserve = new System.Windows.Forms.DateTimePicker();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.comboBoxDepTime = new System.Windows.Forms.ComboBox();
            this.comboBoxArrivalTime = new System.Windows.Forms.ComboBox();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.comboBoxDest = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVPP
            // 
            this.btnVPP.Location = new System.Drawing.Point(3, 90);
            this.btnVPP.Name = "btnVPP";
            this.btnVPP.Size = new System.Drawing.Size(172, 23);
            this.btnVPP.TabIndex = 0;
            this.btnVPP.Text = "View Profile";
            this.btnVPP.UseVisualStyleBackColor = true;
            this.btnVPP.Click += new System.EventHandler(this.btnVPP_Click);
            // 
            // btnBFP
            // 
            this.btnBFP.Location = new System.Drawing.Point(226, 415);
            this.btnBFP.Name = "btnBFP";
            this.btnBFP.Size = new System.Drawing.Size(172, 23);
            this.btnBFP.TabIndex = 1;
            this.btnBFP.Text = "Book Flight";
            this.btnBFP.UseVisualStyleBackColor = true;
            this.btnBFP.Click += new System.EventHandler(this.btnBFP_Click);
            // 
            // btnCFP
            // 
            this.btnCFP.Location = new System.Drawing.Point(589, 415);
            this.btnCFP.Name = "btnCFP";
            this.btnCFP.Size = new System.Drawing.Size(172, 23);
            this.btnCFP.TabIndex = 2;
            this.btnCFP.Text = "Cancel Flight";
            this.btnCFP.UseVisualStyleBackColor = true;
            this.btnCFP.Click += new System.EventHandler(this.btnCFP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Controls.Add(this.btnP);
            this.panel2.Controls.Add(this.btnS);
            this.panel2.Controls.Add(this.btnA);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 62);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(826, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 31);
            this.btnX.TabIndex = 14;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(3, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 39);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(703, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Log In";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(526, 11);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(140, 39);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "Contact Us";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(415, 11);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(94, 39);
            this.btnP.TabIndex = 6;
            this.btnP.Text = "Pricing";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(262, 11);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(136, 39);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "Schedules";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(105, 11);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(144, 39);
            this.btnA.TabIndex = 4;
            this.btnA.Text = "About Us\r\n";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // dgvPassengerProfile
            // 
            this.dgvPassengerProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengerProfile.Location = new System.Drawing.Point(195, 68);
            this.dgvPassengerProfile.Name = "dgvPassengerProfile";
            this.dgvPassengerProfile.Size = new System.Drawing.Size(622, 65);
            this.dgvPassengerProfile.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "TicketNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "SeatNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ReservationDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "DepartureTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ArrivalTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Origin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Destination";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "PassportNo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(109, 231);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(137, 20);
            this.textBoxTicket.TabIndex = 24;
            // 
            // comboBoxSeat
            // 
            this.comboBoxSeat.FormattingEnabled = true;
            this.comboBoxSeat.Location = new System.Drawing.Point(109, 277);
            this.comboBoxSeat.Name = "comboBoxSeat";
            this.comboBoxSeat.Size = new System.Drawing.Size(137, 21);
            this.comboBoxSeat.TabIndex = 25;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(109, 325);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(140, 20);
            this.textBoxPayment.TabIndex = 26;
            // 
            // dateTimeReserve
            // 
            this.dateTimeReserve.Location = new System.Drawing.Point(112, 374);
            this.dateTimeReserve.Name = "dateTimeReserve";
            this.dateTimeReserve.Size = new System.Drawing.Size(213, 20);
            this.dateTimeReserve.TabIndex = 28;
            this.dateTimeReserve.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(109, 197);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(137, 20);
            this.textBoxPassport.TabIndex = 29;
            // 
            // comboBoxDepTime
            // 
            this.comboBoxDepTime.FormattingEnabled = true;
            this.comboBoxDepTime.Location = new System.Drawing.Point(529, 197);
            this.comboBoxDepTime.Name = "comboBoxDepTime";
            this.comboBoxDepTime.Size = new System.Drawing.Size(137, 21);
            this.comboBoxDepTime.TabIndex = 30;
            // 
            // comboBoxArrivalTime
            // 
            this.comboBoxArrivalTime.FormattingEnabled = true;
            this.comboBoxArrivalTime.Location = new System.Drawing.Point(530, 231);
            this.comboBoxArrivalTime.Name = "comboBoxArrivalTime";
            this.comboBoxArrivalTime.Size = new System.Drawing.Size(137, 21);
            this.comboBoxArrivalTime.TabIndex = 31;
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.FormattingEnabled = true;
            this.comboBoxOrigin.Location = new System.Drawing.Point(530, 277);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(137, 21);
            this.comboBoxOrigin.TabIndex = 32;
            // 
            // comboBoxDest
            // 
            this.comboBoxDest.FormattingEnabled = true;
            this.comboBoxDest.Location = new System.Drawing.Point(529, 324);
            this.comboBoxDest.Name = "comboBoxDest";
            this.comboBoxDest.Size = new System.Drawing.Size(137, 21);
            this.comboBoxDest.TabIndex = 33;
            // 
            // PassengerLoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.comboBoxDest);
            this.Controls.Add(this.comboBoxOrigin);
            this.Controls.Add(this.comboBoxArrivalTime);
            this.Controls.Add(this.comboBoxDepTime);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.dateTimeReserve);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.comboBoxSeat);
            this.Controls.Add(this.textBoxTicket);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPassengerProfile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCFP);
            this.Controls.Add(this.btnBFP);
            this.Controls.Add(this.btnVPP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassengerLoggedInForm";
            this.Text = "PassengerLoggedInForm";
            this.Load += new System.EventHandler(this.PassengerLoggedInForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVPP;
        private System.Windows.Forms.Button btnBFP;
        private System.Windows.Forms.Button btnCFP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.DataGridView dgvPassengerProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.ComboBox comboBoxSeat;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.DateTimePicker dateTimeReserve;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.ComboBox comboBoxDepTime;
        private System.Windows.Forms.ComboBox comboBoxArrivalTime;
        private System.Windows.Forms.ComboBox comboBoxOrigin;
        private System.Windows.Forms.ComboBox comboBoxDest;
    }
}