
namespace Skeletown_Game
{
    partial class Skeletown_Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChoiceA = new System.Windows.Forms.Button();
            this.btnChoiceC = new System.Windows.Forms.Button();
            this.btnChoiceD = new System.Windows.Forms.Button();
            this.btnChoiceB = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoiceA
            // 
            this.btnChoiceA.Location = new System.Drawing.Point(357, 404);
            this.btnChoiceA.Name = "btnChoiceA";
            this.btnChoiceA.Size = new System.Drawing.Size(400, 50);
            this.btnChoiceA.TabIndex = 13;
            this.btnChoiceA.Text = "North";
            this.btnChoiceA.UseVisualStyleBackColor = true;
            this.btnChoiceA.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnChoiceC
            // 
            this.btnChoiceC.Location = new System.Drawing.Point(357, 516);
            this.btnChoiceC.Name = "btnChoiceC";
            this.btnChoiceC.Size = new System.Drawing.Size(400, 50);
            this.btnChoiceC.TabIndex = 14;
            this.btnChoiceC.Text = "East";
            this.btnChoiceC.UseVisualStyleBackColor = true;
            this.btnChoiceC.Click += new System.EventHandler(this.btnChoiceC_Click);
            // 
            // btnChoiceD
            // 
            this.btnChoiceD.Location = new System.Drawing.Point(357, 572);
            this.btnChoiceD.Name = "btnChoiceD";
            this.btnChoiceD.Size = new System.Drawing.Size(400, 50);
            this.btnChoiceD.TabIndex = 15;
            this.btnChoiceD.Text = "South";
            this.btnChoiceD.UseVisualStyleBackColor = true;
            this.btnChoiceD.Click += new System.EventHandler(this.btnChoiceD_Click);
            // 
            // btnChoiceB
            // 
            this.btnChoiceB.Location = new System.Drawing.Point(357, 460);
            this.btnChoiceB.Name = "btnChoiceB";
            this.btnChoiceB.Size = new System.Drawing.Size(400, 50);
            this.btnChoiceB.TabIndex = 16;
            this.btnChoiceB.Text = "West";
            this.btnChoiceB.UseVisualStyleBackColor = true;
            this.btnChoiceB.Click += new System.EventHandler(this.btnChoiceB_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(16, 12);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(312, 105);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(375, 280);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(360, 118);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 33;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowHeadersWidth = 62;
            this.dgvQuests.RowTemplate.Height = 33;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // Skeletown_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnChoiceB);
            this.Controls.Add(this.btnChoiceD);
            this.Controls.Add(this.btnChoiceC);
            this.Controls.Add(this.btnChoiceA);
            this.Name = "Skeletown_Game";
            this.Text = "Murder in Skeletown";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChoiceA;
        private System.Windows.Forms.Button btnChoiceC;
        private System.Windows.Forms.Button btnChoiceD;
        private System.Windows.Forms.Button btnChoiceB;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
    }
}

