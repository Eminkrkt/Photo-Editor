namespace Fotoğraf_Düzenleyici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.effect_thread = new System.ComponentModel.BackgroundWorker();
            this.effect_panel = new System.Windows.Forms.Panel();
            this.effect_7_button = new System.Windows.Forms.Button();
            this.effect_6_button = new System.Windows.Forms.Button();
            this.effect_5_button = new System.Windows.Forms.Button();
            this.effect_4_button = new System.Windows.Forms.Button();
            this.effect_3_button = new System.Windows.Forms.Button();
            this.effect_2_button = new System.Windows.Forms.Button();
            this.effect_1_button = new System.Windows.Forms.Button();
            this.picture_area = new System.Windows.Forms.PictureBox();
            this.main_menu.SuspendLayout();
            this.effect_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_area)).BeginInit();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.main_menu.Size = new System.Drawing.Size(800, 27);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.newToolStripMenuItem.Image = global::Fotoğraf_Düzenleyici.Properties.Resources.Icons8_Ios7_Programming_Open_In_Browser;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.saveToolStripMenuItem.Image = global::Fotoğraf_Düzenleyici.Properties.Resources.Iconsmind_Outline_Disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem});
            this.imageToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.imageToolStripMenuItem.Text = "İmage";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.originalToolStripMenuItem.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold);
            this.originalToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.originalToolStripMenuItem.Image = global::Fotoğraf_Düzenleyici.Properties.Resources.Iconsmind_Outline_Photo;
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // effect_thread
            // 
            this.effect_thread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.effect_thread_DoWork);
            // 
            // effect_panel
            // 
            this.effect_panel.AutoScroll = true;
            this.effect_panel.Controls.Add(this.effect_7_button);
            this.effect_panel.Controls.Add(this.effect_6_button);
            this.effect_panel.Controls.Add(this.effect_5_button);
            this.effect_panel.Controls.Add(this.effect_4_button);
            this.effect_panel.Controls.Add(this.effect_3_button);
            this.effect_panel.Controls.Add(this.effect_2_button);
            this.effect_panel.Controls.Add(this.effect_1_button);
            this.effect_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.effect_panel.Location = new System.Drawing.Point(0, 381);
            this.effect_panel.Name = "effect_panel";
            this.effect_panel.Size = new System.Drawing.Size(800, 69);
            this.effect_panel.TabIndex = 1;
            // 
            // effect_7_button
            // 
            this.effect_7_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_7_button.FlatAppearance.BorderSize = 3;
            this.effect_7_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_7_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.effect_7_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_7_button.Location = new System.Drawing.Point(780, 6);
            this.effect_7_button.Name = "effect_7_button";
            this.effect_7_button.Size = new System.Drawing.Size(122, 36);
            this.effect_7_button.TabIndex = 6;
            this.effect_7_button.Text = "Red";
            this.effect_7_button.UseVisualStyleBackColor = false;
            this.effect_7_button.Click += new System.EventHandler(this.button_click);
            // 
            // effect_6_button
            // 
            this.effect_6_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_6_button.FlatAppearance.BorderSize = 3;
            this.effect_6_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_6_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.effect_6_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_6_button.Location = new System.Drawing.Point(652, 6);
            this.effect_6_button.Name = "effect_6_button";
            this.effect_6_button.Size = new System.Drawing.Size(122, 36);
            this.effect_6_button.TabIndex = 5;
            this.effect_6_button.Text = "Live";
            this.effect_6_button.UseVisualStyleBackColor = false;
            this.effect_6_button.Click += new System.EventHandler(this.button_click);
            // 
            // effect_5_button
            // 
            this.effect_5_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_5_button.FlatAppearance.BorderSize = 3;
            this.effect_5_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_5_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.effect_5_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_5_button.Location = new System.Drawing.Point(524, 6);
            this.effect_5_button.Name = "effect_5_button";
            this.effect_5_button.Size = new System.Drawing.Size(122, 36);
            this.effect_5_button.TabIndex = 4;
            this.effect_5_button.Text = "Invert 2";
            this.effect_5_button.UseVisualStyleBackColor = false;
            this.effect_5_button.Click += new System.EventHandler(this.button_click);
            // 
            // effect_4_button
            // 
            this.effect_4_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_4_button.FlatAppearance.BorderSize = 3;
            this.effect_4_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_4_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.effect_4_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_4_button.Location = new System.Drawing.Point(396, 6);
            this.effect_4_button.Name = "effect_4_button";
            this.effect_4_button.Size = new System.Drawing.Size(122, 36);
            this.effect_4_button.TabIndex = 3;
            this.effect_4_button.Text = "Invert";
            this.effect_4_button.UseVisualStyleBackColor = false;
            this.effect_4_button.Click += new System.EventHandler(this.button_click);
            // 
            // effect_3_button
            // 
            this.effect_3_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_3_button.FlatAppearance.BorderSize = 3;
            this.effect_3_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_3_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.effect_3_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_3_button.Location = new System.Drawing.Point(268, 6);
            this.effect_3_button.Name = "effect_3_button";
            this.effect_3_button.Size = new System.Drawing.Size(122, 36);
            this.effect_3_button.TabIndex = 2;
            this.effect_3_button.Text = "Grey";
            this.effect_3_button.UseVisualStyleBackColor = false;
            this.effect_3_button.Click += new System.EventHandler(this.button_click);
            // 
            // effect_2_button
            // 
            this.effect_2_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_2_button.FlatAppearance.BorderSize = 3;
            this.effect_2_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_2_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.effect_2_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_2_button.Location = new System.Drawing.Point(140, 6);
            this.effect_2_button.Name = "effect_2_button";
            this.effect_2_button.Size = new System.Drawing.Size(122, 36);
            this.effect_2_button.TabIndex = 1;
            this.effect_2_button.Text = "Blue";
            this.effect_2_button.UseVisualStyleBackColor = false;
            this.effect_2_button.Click += new System.EventHandler(this.button_click);
            // 
            // effect_1_button
            // 
            this.effect_1_button.BackColor = System.Drawing.Color.Transparent;
            this.effect_1_button.FlatAppearance.BorderSize = 3;
            this.effect_1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effect_1_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effect_1_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.effect_1_button.Location = new System.Drawing.Point(12, 6);
            this.effect_1_button.Name = "effect_1_button";
            this.effect_1_button.Size = new System.Drawing.Size(122, 36);
            this.effect_1_button.TabIndex = 0;
            this.effect_1_button.Text = "Pale";
            this.effect_1_button.UseVisualStyleBackColor = false;
            this.effect_1_button.Click += new System.EventHandler(this.button_click);
            // 
            // picture_area
            // 
            this.picture_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_area.Location = new System.Drawing.Point(0, 27);
            this.picture_area.Name = "picture_area";
            this.picture_area.Size = new System.Drawing.Size(800, 354);
            this.picture_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_area.TabIndex = 2;
            this.picture_area.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture_area);
            this.Controls.Add(this.effect_panel);
            this.Controls.Add(this.main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Photo Editor";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.effect_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker effect_thread;
        private System.Windows.Forms.Panel effect_panel;
        private System.Windows.Forms.PictureBox picture_area;
        private System.Windows.Forms.Button effect_1_button;
        private System.Windows.Forms.Button effect_5_button;
        private System.Windows.Forms.Button effect_4_button;
        private System.Windows.Forms.Button effect_3_button;
        private System.Windows.Forms.Button effect_2_button;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.Button effect_6_button;
        private System.Windows.Forms.Button effect_7_button;
    }
}

