
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDialogue = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pbNPC = new System.Windows.Forms.PictureBox();
            this.lblBlackBar1 = new System.Windows.Forms.Label();
            this.lblBlackBar2 = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblClues = new System.Windows.Forms.Label();
            this.btnClues = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblDialogue = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNPC)).BeginInit();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 54;
            this.listMenu.Location = new System.Drawing.Point(12, 650);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(714, 220);
            this.listMenu.TabIndex = 25;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMove.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMove.Location = new System.Drawing.Point(791, 753);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(454, 141);
            this.btnMove.TabIndex = 23;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDialogue
            // 
            this.btnDialogue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDialogue.Enabled = false;
            this.btnDialogue.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDialogue.Location = new System.Drawing.Point(791, 577);
            this.btnDialogue.Name = "btnDialogue";
            this.btnDialogue.Size = new System.Drawing.Size(454, 141);
            this.btnDialogue.TabIndex = 21;
            this.btnDialogue.Text = "Look";
            this.btnDialogue.UseVisualStyleBackColor = false;
            this.btnDialogue.Visible = false;
            this.btnDialogue.Click += new System.EventHandler(this.btnDialogue_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.Color.LightGray;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMessages.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbMessages.Location = new System.Drawing.Point(118, 512);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(608, 101);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // pbMain
            // 
            this.pbMain.InitialImage = null;
            this.pbMain.Location = new System.Drawing.Point(12, 86);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(714, 336);
            this.pbMain.TabIndex = 30;
            this.pbMain.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(21, 97);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(371, 54);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "LocationText";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(746, 86);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 33;
            this.dgvData.Size = new System.Drawing.Size(530, 473);
            this.dgvData.TabIndex = 27;
            // 
            // pbNPC
            // 
            this.pbNPC.Location = new System.Drawing.Point(12, 512);
            this.pbNPC.Name = "pbNPC";
            this.pbNPC.Size = new System.Drawing.Size(100, 100);
            this.pbNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNPC.TabIndex = 31;
            this.pbNPC.TabStop = false;
            this.pbNPC.Visible = false;
            // 
            // lblBlackBar1
            // 
            this.lblBlackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBlackBar1.Location = new System.Drawing.Point(12, 14);
            this.lblBlackBar1.Name = "lblBlackBar1";
            this.lblBlackBar1.Size = new System.Drawing.Size(713, 72);
            this.lblBlackBar1.TabIndex = 33;
            this.lblBlackBar1.Text = "blackbar1";
            // 
            // lblBlackBar2
            // 
            this.lblBlackBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBlackBar2.Location = new System.Drawing.Point(12, 425);
            this.lblBlackBar2.Name = "lblBlackBar2";
            this.lblBlackBar2.Size = new System.Drawing.Size(713, 72);
            this.lblBlackBar2.TabIndex = 34;
            this.lblBlackBar2.Text = "blackbar2";
            // 
            // lblInventory
            // 
            this.lblInventory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInventory.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInventory.Location = new System.Drawing.Point(746, 24);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(254, 74);
            this.lblInventory.TabIndex = 35;
            this.lblInventory.Text = "My Stuff";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClues
            // 
            this.lblClues.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblClues.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClues.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClues.Location = new System.Drawing.Point(1023, 24);
            this.lblClues.Name = "lblClues";
            this.lblClues.Size = new System.Drawing.Size(254, 74);
            this.lblClues.TabIndex = 36;
            this.lblClues.Text = "Clues";
            this.lblClues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClues.Visible = false;
            // 
            // btnClues
            // 
            this.btnClues.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClues.Location = new System.Drawing.Point(1023, 9);
            this.btnClues.Name = "btnClues";
            this.btnClues.Size = new System.Drawing.Size(254, 74);
            this.btnClues.TabIndex = 37;
            this.btnClues.Text = "Clues";
            this.btnClues.UseVisualStyleBackColor = true;
            this.btnClues.Click += new System.EventHandler(this.btnClues_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Enabled = false;
            this.btnInventory.Font = new System.Drawing.Font("Courier New", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.Location = new System.Drawing.Point(746, 9);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(254, 74);
            this.btnInventory.TabIndex = 38;
            this.btnInventory.Text = "My Stuff";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Visible = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblDialogue
            // 
            this.lblDialogue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDialogue.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialogue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDialogue.Location = new System.Drawing.Point(791, 577);
            this.lblDialogue.Name = "lblDialogue";
            this.lblDialogue.Size = new System.Drawing.Size(454, 141);
            this.lblDialogue.TabIndex = 39;
            this.lblDialogue.Text = "Look";
            this.lblDialogue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMove
            // 
            this.lblMove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMove.Enabled = false;
            this.lblMove.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMove.Location = new System.Drawing.Point(791, 753);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(454, 141);
            this.lblMove.TabIndex = 40;
            this.lblMove.Text = "Move";
            this.lblMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMove.Visible = false;
            // 
            // Skeletown_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 917);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblDialogue);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblClues);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblBlackBar2);
            this.Controls.Add(this.lblBlackBar1);
            this.Controls.Add(this.pbNPC);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDialogue);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnClues);
            this.Name = "Skeletown_Game";
            this.Text = "Murder in Skeletown";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDialogue;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.PictureBox pbNPC;
        private System.Windows.Forms.Label lblBlackBar1;
        private System.Windows.Forms.Label lblBlackBar2;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblClues;
        private System.Windows.Forms.Button btnClues;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblDialogue;
        private System.Windows.Forms.Label lblMove;
    }
}

