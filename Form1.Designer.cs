
namespace CReadKanManHua
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.常用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开漫画文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comic_name_box = new System.Windows.Forms.ComboBox();
            this.chapter_name_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.prev_chapter = new System.Windows.Forms.Button();
            this.prev_page = new System.Windows.Forms.Button();
            this.next_page = new System.Windows.Forms.Button();
            this.next_chapter = new System.Windows.Forms.Button();
            this.page_progress = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPage)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_progress)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.常用ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 常用ToolStripMenuItem
            // 
            this.常用ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开漫画文件夹ToolStripMenuItem});
            this.常用ToolStripMenuItem.Name = "常用ToolStripMenuItem";
            this.常用ToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.常用ToolStripMenuItem.Text = "常用";
            // 
            // 打开漫画文件夹ToolStripMenuItem
            // 
            this.打开漫画文件夹ToolStripMenuItem.Name = "打开漫画文件夹ToolStripMenuItem";
            this.打开漫画文件夹ToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.打开漫画文件夹ToolStripMenuItem.Text = "打开漫画文件夹";
            this.打开漫画文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开漫画文件夹ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowPage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.page_progress, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 16F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 540);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comic_name_box, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chapter_name_box, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "章节名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comic_name_box
            // 
            this.comic_name_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comic_name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comic_name_box.Location = new System.Drawing.Point(3, 25);
            this.comic_name_box.Name = "comic_name_box";
            this.comic_name_box.Size = new System.Drawing.Size(260, 29);
            this.comic_name_box.Sorted = true;
            this.comic_name_box.TabIndex = 2;
            this.comic_name_box.SelectedIndexChanged += new System.EventHandler(this.comic_name_box_SelectedIndexChanged);
            // 
            // chapter_name_box
            // 
            this.chapter_name_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapter_name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chapter_name_box.FormattingEnabled = true;
            this.chapter_name_box.Location = new System.Drawing.Point(269, 25);
            this.chapter_name_box.Name = "chapter_name_box";
            this.chapter_name_box.Size = new System.Drawing.Size(261, 29);
            this.chapter_name_box.TabIndex = 3;
            this.chapter_name_box.SelectedIndexChanged += new System.EventHandler(this.chapter_name_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "漫画名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPage
            // 
            this.ShowPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPage.Location = new System.Drawing.Point(3, 64);
            this.ShowPage.Name = "ShowPage";
            this.ShowPage.Size = new System.Drawing.Size(533, 381);
            this.ShowPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPage.TabIndex = 1;
            this.ShowPage.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.prev_chapter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.prev_page, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.next_page, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.next_chapter, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 451);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(533, 35);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // prev_chapter
            // 
            this.prev_chapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prev_chapter.Location = new System.Drawing.Point(3, 3);
            this.prev_chapter.Name = "prev_chapter";
            this.prev_chapter.Size = new System.Drawing.Size(127, 29);
            this.prev_chapter.TabIndex = 0;
            this.prev_chapter.Text = "上一章";
            this.prev_chapter.UseVisualStyleBackColor = true;
            this.prev_chapter.Click += new System.EventHandler(this.prev_chapter_Click);
            // 
            // prev_page
            // 
            this.prev_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prev_page.Location = new System.Drawing.Point(136, 3);
            this.prev_page.Name = "prev_page";
            this.prev_page.Size = new System.Drawing.Size(127, 29);
            this.prev_page.TabIndex = 1;
            this.prev_page.Text = "上一页";
            this.prev_page.UseVisualStyleBackColor = true;
            this.prev_page.Click += new System.EventHandler(this.prev_page_Click);
            // 
            // next_page
            // 
            this.next_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next_page.Location = new System.Drawing.Point(269, 3);
            this.next_page.Name = "next_page";
            this.next_page.Size = new System.Drawing.Size(127, 29);
            this.next_page.TabIndex = 2;
            this.next_page.Text = "下一页";
            this.next_page.UseVisualStyleBackColor = true;
            this.next_page.Click += new System.EventHandler(this.next_page_Click);
            // 
            // next_chapter
            // 
            this.next_chapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next_chapter.Location = new System.Drawing.Point(402, 3);
            this.next_chapter.Name = "next_chapter";
            this.next_chapter.Size = new System.Drawing.Size(128, 29);
            this.next_chapter.TabIndex = 3;
            this.next_chapter.Text = "下一章";
            this.next_chapter.UseVisualStyleBackColor = true;
            this.next_chapter.Click += new System.EventHandler(this.next_chapter_Click);
            // 
            // page_progress
            // 
            this.page_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.page_progress.Location = new System.Drawing.Point(3, 492);
            this.page_progress.Name = "page_progress";
            this.page_progress.Size = new System.Drawing.Size(533, 45);
            this.page_progress.TabIndex = 3;
            this.page_progress.Scroll += new System.EventHandler(this.page_progress_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Read看漫画";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPage)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page_progress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 常用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开漫画文件夹ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comic_name_box;
        private System.Windows.Forms.ComboBox chapter_name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ShowPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button prev_chapter;
        private System.Windows.Forms.Button prev_page;
        private System.Windows.Forms.Button next_page;
        private System.Windows.Forms.Button next_chapter;
        private System.Windows.Forms.TrackBar page_progress;
    }
}

