using System.Collections.Generic;

namespace TeamManager
{
    partial class TeamManager
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxLayout = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountry.Location = new System.Drawing.Point(36, 9);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(137, 30);
            this.labelCountry.TabIndex = 10;
            this.labelCountry.Text = "Country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(233, 18);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(170, 21);
            this.comboBoxCountry.TabIndex = 11;
            // 
            // comboBoxLayout
            // 
            this.comboBoxLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLayout.FormattingEnabled = true;
            this.comboBoxLayout.Location = new System.Drawing.Point(27, 651);
            this.comboBoxLayout.Name = "comboBoxLayout";
            this.comboBoxLayout.Size = new System.Drawing.Size(170, 21);
            this.comboBoxLayout.TabIndex = 12;
            this.comboBoxLayout.SelectedIndexChanged += new System.EventHandler(this.comboBoxLayout_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(256, 635);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(181, 50);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate team";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(48, 57);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(91, 23);
            this.labelPosition.TabIndex = 14;
            this.labelPosition.Text = "Position";
            // 
            // labelSurname
            // 
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(340, 57);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(97, 23);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Surname";
            // 
            // labelNumber
            // 
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(204, 57);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 23);
            this.labelNumber.TabIndex = 16;
            this.labelNumber.Text = "Number";
            // 
            // TeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(477, 684);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboBoxLayout);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Name = "TeamManager";
            this.Text = "Team Manager";
            this.Load += new System.EventHandler(this.TeamManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerInfo[] listPlayer;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxLayout;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelNumber;
    }
}

