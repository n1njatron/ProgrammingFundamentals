namespace Midterm_Final
{
    partial class MidFinal
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
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.btnLocation = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnSpecialty = new System.Windows.Forms.Button();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.pnlPrevNext = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlStart.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlPrevNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.Red;
            this.pnlStart.Controls.Add(this.lblStart);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(12, 12);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(600, 365);
            this.pnlStart.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(195, 173);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(210, 18);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Push Button to Start";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(16, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(571, 98);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlLocation
            // 
            this.pnlLocation.Controls.Add(this.btnLocation);
            this.pnlLocation.Controls.Add(this.btnOut);
            this.pnlLocation.Controls.Add(this.btnIn);
            this.pnlLocation.Location = new System.Drawing.Point(12, 5);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(600, 365);
            this.pnlLocation.TabIndex = 2;
            // 
            // btnLocation
            // 
            this.btnLocation.AutoSize = true;
            this.btnLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.Location = new System.Drawing.Point(220, 94);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(154, 24);
            this.btnLocation.TabIndex = 2;
            this.btnLocation.Text = "Eating Location";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(427, 188);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(135, 82);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Take Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(38, 188);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(131, 82);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "Eat In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlOrderType.Controls.Add(this.pnlPrevNext);
            this.pnlOrderType.Controls.Add(this.lblOrderType);
            this.pnlOrderType.Controls.Add(this.btnSpecialty);
            this.pnlOrderType.Controls.Add(this.btnBuild);
            this.pnlOrderType.Location = new System.Drawing.Point(3, 8);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(622, 384);
            this.pnlOrderType.TabIndex = 3;
            // 
            // btnBuild
            // 
            this.btnBuild.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(57, 159);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(120, 67);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build your Own";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // btnSpecialty
            // 
            this.btnSpecialty.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialty.Location = new System.Drawing.Point(423, 159);
            this.btnSpecialty.Name = "btnSpecialty";
            this.btnSpecialty.Size = new System.Drawing.Size(120, 67);
            this.btnSpecialty.TabIndex = 1;
            this.btnSpecialty.Text = "Specialty Builds";
            this.btnSpecialty.UseVisualStyleBackColor = true;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(185, 139);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(216, 23);
            this.lblOrderType.TabIndex = 2;
            this.lblOrderType.Text = "Choose an Option";
            // 
            // pnlPrevNext
            // 
            this.pnlPrevNext.BackColor = System.Drawing.Color.Orange;
            this.pnlPrevNext.Controls.Add(this.btnNext);
            this.pnlPrevNext.Controls.Add(this.btnPrev);
            this.pnlPrevNext.Location = new System.Drawing.Point(3, 264);
            this.pnlPrevNext.Name = "pnlPrevNext";
            this.pnlPrevNext.Size = new System.Drawing.Size(594, 100);
            this.pnlPrevNext.TabIndex = 3;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(61, 17);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 67);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "< Go Back";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(427, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 67);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // MidFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 484);
            this.Controls.Add(this.pnlOrderType);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlStart);
            this.Name = "MidFinal";
            this.Text = "MidFinal";
            this.Load += new System.EventHandler(this.MidFinal_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.pnlPrevNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label btnLocation;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.Panel pnlPrevNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Button btnSpecialty;
        private System.Windows.Forms.Button btnBuild;


    }
}

