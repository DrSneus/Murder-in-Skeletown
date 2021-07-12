
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
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.Color.LightGray;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMessages.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbMessages.Location = new System.Drawing.Point(350, 384);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(597, 93);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(14, 105);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowHeadersWidth = 62;
            this.dgvQuests.RowTemplate.Height = 33;
            this.dgvQuests.Size = new System.Drawing.Size(312, 568);
            this.dgvQuests.TabIndex = 20;
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTalk.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTalk.Location = new System.Drawing.Point(350, 484);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(166, 85);
            this.btnTalk.TabIndex = 21;
            this.btnTalk.Text = "Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnUse
            // 
            this.btnUse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUse.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUse.Location = new System.Drawing.Point(350, 585);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(166, 85);
            this.btnUse.TabIndex = 22;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = false;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMove.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMove.Location = new System.Drawing.Point(781, 585);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(166, 85);
            this.btnMove.TabIndex = 23;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLook.Font = new System.Drawing.Font("NSimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLook.Location = new System.Drawing.Point(781, 483);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(166, 85);
            this.btnLook.TabIndex = 24;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = false;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 25;
            this.listMenu.Location = new System.Drawing.Point(523, 498);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(252, 154);
            this.listMenu.TabIndex = 25;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(456, 20);
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
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(972, 105);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 33;
            this.dgvInventory.Size = new System.Drawing.Size(312, 568);
            this.dgvInventory.TabIndex = 27;
            // 
            // lblLog
            // 
            this.lblLog.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog.Location = new System.Drawing.Point(14, 9);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(314, 89);
            this.lblLog.TabIndex = 28;
            this.lblLog.Text = "Log";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItems
            // 
            this.lblItems.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItems.Location = new System.Drawing.Point(972, 9);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(314, 89);
            this.lblItems.TabIndex = 29;
            this.lblItems.Text = "Items";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMain
            // 
            this.pbMain.InitialImage = null;
            this.pbMain.Location = new System.Drawing.Point(350, 105);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(597, 273);
            this.pbMain.TabIndex = 30;
            this.pbMain.TabStop = false;
            // 
            // Skeletown_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 685);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.listMenu);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.rtbMessages);
            this.Name = "Skeletown_Game";
            this.Text = "Murder in Skeletown";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.ListBox listMenu;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.PictureBox pbMain;
    }
}

