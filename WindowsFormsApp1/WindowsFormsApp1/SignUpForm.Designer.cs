
namespace WindowsFormsApp1
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.BtnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.labelPhn = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelEs = new System.Windows.Forms.Label();
            this.labelPs = new System.Windows.Forms.Label();
            this.labelEl = new System.Windows.Forms.Label();
            this.labelPl = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxPhn = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxEs = new System.Windows.Forms.TextBox();
            this.textBoxEl = new System.Windows.Forms.TextBox();
            this.textBoxPs = new System.Windows.Forms.TextBox();
            this.textBoxPl = new System.Windows.Forms.TextBox();
            this.textDoB = new System.Windows.Forms.DateTimePicker();
            this.btnSU = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.adminCheck = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.btnL);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.BtnP);
            this.panel1.Controls.Add(this.btnS);
            this.panel1.Controls.Add(this.btnH);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 59);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(916, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 31);
            this.button10.TabIndex = 6;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Yellow;
            this.btnL.Location = new System.Drawing.Point(756, 12);
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
            this.btnC.Location = new System.Drawing.Point(558, 12);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(140, 37);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "Contact Us";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // BtnP
            // 
            this.BtnP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP.Location = new System.Drawing.Point(445, 11);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(94, 40);
            this.BtnP.TabIndex = 5;
            this.BtnP.Text = "Pricing";
            this.BtnP.UseVisualStyleBackColor = false;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(278, 12);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(152, 38);
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
            this.btnH.Location = new System.Drawing.Point(10, 12);
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
            this.btnA.Location = new System.Drawing.Point(119, 11);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(144, 40);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "About Us";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(118, 139);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(51, 20);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "Name";
            // 
            // labelPhn
            // 
            this.labelPhn.AutoSize = true;
            this.labelPhn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhn.Location = new System.Drawing.Point(118, 182);
            this.labelPhn.Name = "labelPhn";
            this.labelPhn.Size = new System.Drawing.Size(79, 20);
            this.labelPhn.TabIndex = 4;
            this.labelPhn.Text = "Phone No";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(118, 231);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(68, 20);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "Address";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(118, 277);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(41, 20);
            this.labelD.TabIndex = 6;
            this.labelD.Text = "DoB";
            // 
            // labelEs
            // 
            this.labelEs.AutoSize = true;
            this.labelEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEs.Location = new System.Drawing.Point(118, 317);
            this.labelEs.Name = "labelEs";
            this.labelEs.Size = new System.Drawing.Size(48, 20);
            this.labelEs.TabIndex = 7;
            this.labelEs.Text = "Email";
            // 
            // labelPs
            // 
            this.labelPs.AutoSize = true;
            this.labelPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPs.Location = new System.Drawing.Point(118, 360);
            this.labelPs.Name = "labelPs";
            this.labelPs.Size = new System.Drawing.Size(78, 20);
            this.labelPs.TabIndex = 8;
            this.labelPs.Text = "Password";
            // 
            // labelEl
            // 
            this.labelEl.AutoSize = true;
            this.labelEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEl.Location = new System.Drawing.Point(624, 139);
            this.labelEl.Name = "labelEl";
            this.labelEl.Size = new System.Drawing.Size(48, 20);
            this.labelEl.TabIndex = 9;
            this.labelEl.Text = "Email";
            // 
            // labelPl
            // 
            this.labelPl.AutoSize = true;
            this.labelPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPl.Location = new System.Drawing.Point(624, 189);
            this.labelPl.Name = "labelPl";
            this.labelPl.Size = new System.Drawing.Size(78, 20);
            this.labelPl.TabIndex = 10;
            this.labelPl.Text = "Password";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(239, 141);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(200, 20);
            this.textBoxN.TabIndex = 11;
            // 
            // textBoxPhn
            // 
            this.textBoxPhn.Location = new System.Drawing.Point(239, 182);
            this.textBoxPhn.Name = "textBoxPhn";
            this.textBoxPhn.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhn.TabIndex = 12;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(239, 231);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(200, 20);
            this.textBoxA.TabIndex = 13;
            // 
            // textBoxEs
            // 
            this.textBoxEs.Location = new System.Drawing.Point(239, 319);
            this.textBoxEs.Name = "textBoxEs";
            this.textBoxEs.Size = new System.Drawing.Size(200, 20);
            this.textBoxEs.TabIndex = 14;
            // 
            // textBoxEl
            // 
            this.textBoxEl.Location = new System.Drawing.Point(737, 141);
            this.textBoxEl.Name = "textBoxEl";
            this.textBoxEl.Size = new System.Drawing.Size(177, 20);
            this.textBoxEl.TabIndex = 15;
            // 
            // textBoxPs
            // 
            this.textBoxPs.Location = new System.Drawing.Point(239, 362);
            this.textBoxPs.Name = "textBoxPs";
            this.textBoxPs.PasswordChar = '*';
            this.textBoxPs.Size = new System.Drawing.Size(200, 20);
            this.textBoxPs.TabIndex = 16;
            this.textBoxPs.UseSystemPasswordChar = true;
            // 
            // textBoxPl
            // 
            this.textBoxPl.Location = new System.Drawing.Point(737, 191);
            this.textBoxPl.Name = "textBoxPl";
            this.textBoxPl.PasswordChar = '*';
            this.textBoxPl.Size = new System.Drawing.Size(177, 20);
            this.textBoxPl.TabIndex = 17;
            this.textBoxPl.UseSystemPasswordChar = true;
            // 
            // textDoB
            // 
            this.textDoB.Location = new System.Drawing.Point(239, 276);
            this.textDoB.Name = "textDoB";
            this.textDoB.Size = new System.Drawing.Size(200, 20);
            this.textDoB.TabIndex = 18;
            // 
            // btnSU
            // 
            this.btnSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSU.Location = new System.Drawing.Point(280, 406);
            this.btnSU.Name = "btnSU";
            this.btnSU.Size = new System.Drawing.Size(75, 34);
            this.btnSU.TabIndex = 19;
            this.btnSU.Text = "Sign Up";
            this.btnSU.UseVisualStyleBackColor = true;
            this.btnSU.Click += new System.EventHandler(this.btnSU_Click);
            // 
            // btnSI
            // 
            this.btnSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSI.Location = new System.Drawing.Point(788, 310);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(75, 34);
            this.btnSI.TabIndex = 20;
            this.btnSI.Text = "Sign In";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Location = new System.Drawing.Point(774, 250);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(98, 17);
            this.adminCheck.TabIndex = 21;
            this.adminCheck.TabStop = true;
            this.adminCheck.Text = "Login As Admin";
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 501);
            this.Controls.Add(this.adminCheck);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.btnSU);
            this.Controls.Add(this.textDoB);
            this.Controls.Add(this.textBoxPl);
            this.Controls.Add(this.textBoxPs);
            this.Controls.Add(this.textBoxEl);
            this.Controls.Add(this.textBoxEs);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxPhn);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelPl);
            this.Controls.Add(this.labelEl);
            this.Controls.Add(this.labelPs);
            this.Controls.Add(this.labelEs);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelPhn);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button BtnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelPhn;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelEs;
        private System.Windows.Forms.Label labelPs;
        private System.Windows.Forms.Label labelEl;
        private System.Windows.Forms.Label labelPl;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxPhn;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxEs;
        private System.Windows.Forms.TextBox textBoxEl;
        private System.Windows.Forms.TextBox textBoxPs;
        private System.Windows.Forms.TextBox textBoxPl;
        private System.Windows.Forms.DateTimePicker textDoB;
        private System.Windows.Forms.Button btnSU;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.RadioButton adminCheck;
    }
}