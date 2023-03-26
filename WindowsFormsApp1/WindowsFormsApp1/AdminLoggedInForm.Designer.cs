
namespace WindowsFormsApp1
{
    partial class AdminLoggedInForm
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
            this.btnAF = new System.Windows.Forms.Button();
            this.btnCF = new System.Windows.Forms.Button();
            this.btnVFA = new System.Windows.Forms.Button();
            this.btnBFA = new System.Windows.Forms.Button();
            this.btnCFA = new System.Windows.Forms.Button();
            this.btnVPA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.labelTicket = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAF
            // 
            this.btnAF.Location = new System.Drawing.Point(791, 85);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(64, 42);
            this.btnAF.TabIndex = 0;
            this.btnAF.Text = "Add Flight";
            this.btnAF.UseVisualStyleBackColor = true;
            // 
            // btnCF
            // 
            this.btnCF.Location = new System.Drawing.Point(791, 172);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(64, 50);
            this.btnCF.TabIndex = 1;
            this.btnCF.Text = "Delete Flight";
            this.btnCF.UseVisualStyleBackColor = true;
            // 
            // btnVFA
            // 
            this.btnVFA.Location = new System.Drawing.Point(791, 272);
            this.btnVFA.Name = "btnVFA";
            this.btnVFA.Size = new System.Drawing.Size(64, 41);
            this.btnVFA.TabIndex = 2;
            this.btnVFA.Text = "View Flights";
            this.btnVFA.UseVisualStyleBackColor = true;
            // 
            // btnBFA
            // 
            this.btnBFA.Location = new System.Drawing.Point(791, 352);
            this.btnBFA.Name = "btnBFA";
            this.btnBFA.Size = new System.Drawing.Size(64, 43);
            this.btnBFA.TabIndex = 3;
            this.btnBFA.Text = "Book Flight";
            this.btnBFA.UseVisualStyleBackColor = true;
            // 
            // btnCFA
            // 
            this.btnCFA.Location = new System.Drawing.Point(780, 427);
            this.btnCFA.Name = "btnCFA";
            this.btnCFA.Size = new System.Drawing.Size(75, 49);
            this.btnCFA.TabIndex = 4;
            this.btnCFA.Text = "Cancel Reservation";
            this.btnCFA.UseVisualStyleBackColor = true;
            this.btnCFA.Click += new System.EventHandler(this.btnCFA_Click);
            // 
            // btnVPA
            // 
            this.btnVPA.Location = new System.Drawing.Point(0, 78);
            this.btnVPA.Name = "btnVPA";
            this.btnVPA.Size = new System.Drawing.Size(64, 49);
            this.btnVPA.TabIndex = 5;
            this.btnVPA.Text = "View Profile";
            this.btnVPA.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.btnH);
            this.panel2.Controls.Add(this.btnL);
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Controls.Add(this.btnP);
            this.panel2.Controls.Add(this.btnS);
            this.panel2.Controls.Add(this.btnA);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 62);
            this.panel2.TabIndex = 12;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(821, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 31);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(3, 11);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(94, 39);
            this.btnH.TabIndex = 9;
            this.btnH.Text = "Home";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Yellow;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(703, 11);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(114, 37);
            this.btnL.TabIndex = 8;
            this.btnL.Text = "Log In";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 488);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(274, 150);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(251, 20);
            this.textBoxTicket.TabIndex = 14;
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(166, 150);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(51, 13);
            this.labelTicket.TabIndex = 15;
            this.labelTicket.Text = "TicketNo";
            // 
            // AdminLoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(856, 488);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.textBoxTicket);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVPA);
            this.Controls.Add(this.btnCFA);
            this.Controls.Add(this.btnBFA);
            this.Controls.Add(this.btnVFA);
            this.Controls.Add(this.btnCF);
            this.Controls.Add(this.btnAF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoggedInForm";
            this.Text = "AdminLoggedInForm";
            this.Load += new System.EventHandler(this.AdminLoggedInForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnCF;
        private System.Windows.Forms.Button btnVFA;
        private System.Windows.Forms.Button btnBFA;
        private System.Windows.Forms.Button btnCFA;
        private System.Windows.Forms.Button btnVPA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.Label labelTicket;
    }
}