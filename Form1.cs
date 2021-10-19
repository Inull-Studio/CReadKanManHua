using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CReadKanManHua
{
    public partial class Form1 : Form
    {
        string allComicPath = "";
        string currentComic = "";
        FileInfo[] pageList;
        public Form1()
        {
            InitializeComponent();
        }
        public void ShowImage(String filename)
        {
            ShowPage.Image = Image.FromFile(filename);
        }
        private void 打开漫画文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择漫画所在文件夹";
            dialog.ShowNewFolderButton = false;
            if (allComicPath != "")
                dialog.SelectedPath = allComicPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                allComicPath = dialog.SelectedPath;
                String[] pathList = allComicPath.Split('\\');
                if (pathList[pathList.Length - 1] == "downloads")
                    listComicName(allComicPath);
                else
                {
                    MessageBox.Show("请选择KanManHua下载路径!", "路径错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allComicPath = "";
                }
            }
        }
        public void listComicName(string path)
        {
            DirectoryInfo[] comicPath = new DirectoryInfo(path).GetDirectories();
            for (int i = 0; i < comicPath.Length; i++)
            {
                comic_name_box.Items.Add(comicPath[i].Name);
            }
        }
        private void comic_name_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            chapter_name_box.Items.Clear();
            currentComic = comic_name_box.Text;
            DirectoryInfo[] chapterPath = new DirectoryInfo(Path.Combine(allComicPath, currentComic)).GetDirectories().OrderBy(x=>x.CreationTime).ToArray();
            for (int i = 0; i < chapterPath.Length; i++)
                chapter_name_box.Items.Add(chapterPath[i].Name);
        }
        private void chapter_name_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageList = new DirectoryInfo(Path.Combine(allComicPath, comic_name_box.Text, chapter_name_box.Text)).GetFiles().OrderBy(x=>x.CreationTime).ToArray();
            ShowImage(pageList[0].FullName);
            page_progress.Maximum = pageList.Length-1;
            page_progress.Value = 0;
        }
        private void page_progress_Scroll(object sender, EventArgs e)
        {
            ShowImage(pageList[page_progress.Value].FullName);
        }
        private void next_page_Click(object sender, EventArgs e)
        {
            if (page_progress.Value != page_progress.Maximum)
            {
                page_progress.Value += 1;
                ShowImage(pageList[page_progress.Value].FullName);
            }
            else
                if(chapter_name_box.SelectedIndex != chapter_name_box.Items.Count - 1)
                    chapter_name_box.SelectedIndex += 1;
        }
        private void prev_page_Click(object sender, EventArgs e)
        {
            if (page_progress.Value != 0)
            {
                page_progress.Value -= 1;
                ShowImage(pageList[page_progress.Value].FullName);
            }
            else
                if (chapter_name_box.SelectedIndex != 0)
                chapter_name_box.SelectedIndex -= 1;
        }

        private void next_chapter_Click(object sender, EventArgs e)
        {
            if(chapter_name_box.SelectedIndex!=chapter_name_box.Items.Count-1)
                chapter_name_box.SelectedIndex += 1;
        }

        private void prev_chapter_Click(object sender, EventArgs e)
        {
            if(chapter_name_box.SelectedIndex!=0)
                chapter_name_box.SelectedIndex -= 1;
        }
    }
}
