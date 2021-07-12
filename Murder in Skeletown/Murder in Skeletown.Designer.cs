
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
            this.listMenu = new System.Windows.Forms.ListBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pbNPC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNPC)).BeginInit();
            this.SuspendLayout();
            // 
            // listMenu
            // 
            this.listMenu.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 54;
            this.listMenu.Location = new System.Drawing.Point(12, 472);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(714, 166);
            this.listMenu.TabIndex = 25;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLook.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLook.Location = new System.Drawing.Point(787, 136);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(454, 85);
            this.btnLook.TabIndex = 24;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = false;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMove.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMove.Location = new System.Drawing.Point(787, 244);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(454, 85);
            this.btnMove.TabIndex = 23;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTalk.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTalk.Location = new System.Drawing.Point(787, 27);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(454, 85);
            this.btnTalk.TabIndex = 21;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.Color.LightGray;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMessages.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbMessages.Location = new System.Drawing.Point(118, 365);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(608, 101);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // pbMain
            // 
            this.pbMain.InitialImage = null;
            this.pbMain.Location = new System.Drawing.Point(12, 9);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(714, 336);
            this.pbMain.TabIndex = 30;
            this.pbMain.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(12, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(397, 59);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "LocationText";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.ColumnHeadersVisible = false;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(747, 365);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 33;
            this.dgvInventory.Size = new System.Drawing.Size(540, 307);
            this.dgvInventory.TabIndex = 27;
            // 
            // pbNPC
            // 
            this.pbNPC.Location = new System.Drawing.Point(12, 365);
            this.pbNPC.Name = "pbNPC";
            this.pbNPC.Size = new System.Drawing.Size(100, 100);
            this.pbNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNPC.TabIndex = 31;
            this.pbNPC.TabStop = false;
            this.pbNPC.Visible = false;
            // 
            // Skeletown_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 684);
            this.Controls.Add(this.pbNPC);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.listMenu);
            this.Name = "Skeletown_Game";
            this.Text = "Murder in Skeletown";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.PictureBox pbNPC;
    }
}

