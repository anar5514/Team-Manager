namespace TeamManager
{
    partial class PlayerInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.position = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // position
            // 
            this.position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.position.Location = new System.Drawing.Point(31, 16);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(100, 23);
            this.position.TabIndex = 0;
            this.position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Location = new System.Drawing.Point(193, 16);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 23);
            this.number.TabIndex = 1;
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(349, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 2;
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.position);
            this.Name = "PlayerInfo";
            this.Size = new System.Drawing.Size(468, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.UserControl playerInfo;
    }
}
