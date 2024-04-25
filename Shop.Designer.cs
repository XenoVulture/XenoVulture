
namespace AndrewRusso_CPT_185_Final_Project
{
    partial class Shop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.jobFoundLabel = new System.Windows.Forms.Label();
            this.jobInfoTextBox = new System.Windows.Forms.TextBox();
            this.foundJobPictureBox = new System.Windows.Forms.PictureBox();
            this.questionAddCardsLabel = new System.Windows.Forms.Label();
            this.shopJobImageList = new System.Windows.Forms.ImageList(this.components);
            this.addCardsButton = new System.Windows.Forms.Button();
            this.doNotAddCardsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foundJobPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // jobFoundLabel
            // 
            this.jobFoundLabel.AutoSize = true;
            this.jobFoundLabel.Location = new System.Drawing.Point(20, 16);
            this.jobFoundLabel.Name = "jobFoundLabel";
            this.jobFoundLabel.Size = new System.Drawing.Size(198, 17);
            this.jobFoundLabel.TabIndex = 0;
            this.jobFoundLabel.Text = "You have found _____________";
            // 
            // jobInfoTextBox
            // 
            this.jobInfoTextBox.Location = new System.Drawing.Point(132, 76);
            this.jobInfoTextBox.Multiline = true;
            this.jobInfoTextBox.Name = "jobInfoTextBox";
            this.jobInfoTextBox.ReadOnly = true;
            this.jobInfoTextBox.Size = new System.Drawing.Size(245, 136);
            this.jobInfoTextBox.TabIndex = 18;
            this.jobInfoTextBox.TabStop = false;
            this.jobInfoTextBox.Text = "jobInfoTextBox";
            // 
            // foundJobPictureBox
            // 
            this.foundJobPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("foundJobPictureBox.BackgroundImage")));
            this.foundJobPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foundJobPictureBox.ErrorImage = null;
            this.foundJobPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("foundJobPictureBox.Image")));
            this.foundJobPictureBox.InitialImage = null;
            this.foundJobPictureBox.Location = new System.Drawing.Point(23, 76);
            this.foundJobPictureBox.Name = "foundJobPictureBox";
            this.foundJobPictureBox.Size = new System.Drawing.Size(103, 136);
            this.foundJobPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foundJobPictureBox.TabIndex = 19;
            this.foundJobPictureBox.TabStop = false;
            // 
            // questionAddCardsLabel
            // 
            this.questionAddCardsLabel.AutoSize = true;
            this.questionAddCardsLabel.Location = new System.Drawing.Point(23, 219);
            this.questionAddCardsLabel.Name = "questionAddCardsLabel";
            this.questionAddCardsLabel.Size = new System.Drawing.Size(336, 17);
            this.questionAddCardsLabel.TabIndex = 20;
            this.questionAddCardsLabel.Text = "Would you like to add this job\'s 6 cards to your deck?";
            // 
            // shopJobImageList
            // 
            this.shopJobImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("shopJobImageList.ImageStream")));
            this.shopJobImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.shopJobImageList.Images.SetKeyName(0, "alchemist.png");
            // 
            // addCardsButton
            // 
            this.addCardsButton.Location = new System.Drawing.Point(26, 263);
            this.addCardsButton.Name = "addCardsButton";
            this.addCardsButton.Size = new System.Drawing.Size(75, 25);
            this.addCardsButton.TabIndex = 21;
            this.addCardsButton.Text = "&Yes";
            this.addCardsButton.UseVisualStyleBackColor = true;
            this.addCardsButton.Click += new System.EventHandler(this.addCardsButton_Click);
            // 
            // doNotAddCardsButton
            // 
            this.doNotAddCardsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doNotAddCardsButton.Location = new System.Drawing.Point(302, 263);
            this.doNotAddCardsButton.Name = "doNotAddCardsButton";
            this.doNotAddCardsButton.Size = new System.Drawing.Size(75, 25);
            this.doNotAddCardsButton.TabIndex = 22;
            this.doNotAddCardsButton.Text = "&No";
            this.doNotAddCardsButton.UseVisualStyleBackColor = true;
            this.doNotAddCardsButton.Click += new System.EventHandler(this.doNotAddCardsButton_Click);
            // 
            // Shop
            // 
            this.AcceptButton = this.addCardsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.doNotAddCardsButton;
            this.ClientSize = new System.Drawing.Size(401, 310);
            this.Controls.Add(this.doNotAddCardsButton);
            this.Controls.Add(this.addCardsButton);
            this.Controls.Add(this.questionAddCardsLabel);
            this.Controls.Add(this.foundJobPictureBox);
            this.Controls.Add(this.jobInfoTextBox);
            this.Controls.Add(this.jobFoundLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rescue";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foundJobPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jobFoundLabel;
        private System.Windows.Forms.TextBox jobInfoTextBox;
        private System.Windows.Forms.PictureBox foundJobPictureBox;
        private System.Windows.Forms.Label questionAddCardsLabel;
        private System.Windows.Forms.ImageList shopJobImageList;
        private System.Windows.Forms.Button addCardsButton;
        private System.Windows.Forms.Button doNotAddCardsButton;
    }
}