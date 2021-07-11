
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
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(352, 346);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(597, 93);
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
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(352, 446);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(166, 85);
            this.btnTalk.TabIndex = 21;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(352, 547);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(166, 85);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(783, 547);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(166, 85);
            this.btnMove.TabIndex = 23;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(783, 445);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(166, 85);
            this.btnLook.TabIndex = 24;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 25;
            this.listMenu.Location = new System.Drawing.Point(525, 460);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(252, 154);
            this.listMenu.TabIndex = 25;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(16, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(262, 54);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "LocationText";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Skeletown_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Name = "Skeletown_Game";
            this.Text = "Murder in Skeletown";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.Label lblLocation;
    }
}

