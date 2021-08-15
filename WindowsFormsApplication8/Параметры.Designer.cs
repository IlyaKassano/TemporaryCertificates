namespace WindowsFormsApplication5
{
    partial class Параметры
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
        public static System.Windows.Forms.ColorDialog colorDialog1 = new System.Windows.Forms.ColorDialog();
        public static System.Windows.Forms.FontDialog fontDialog1 = new System.Windows.Forms.FontDialog();
        private System.Windows.Forms.ListBox listBox1;
    }
}