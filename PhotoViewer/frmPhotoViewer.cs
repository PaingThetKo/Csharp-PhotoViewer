namespace PhotoViewer
{
    public partial class frmPhotoViewer : Form
    {
        public frmPhotoViewer()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // to choose type of file as the filter when browse 
            openFileDialog1.Filter = "PNG Files(.png)|*.png|JPEG Files(.jpg)|*.jpg|ALL Files(*.*)|*.*";
            // to choose the file type as the first one of type to open first
            openFileDialog1.FilterIndex = 1;
            // when want to select multiple file
            openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String filename = openFileDialog1.FileName;
                Image image = Image.FromFile(filename);
                pictureBox1.Image = image;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // must be enter under type of words in combobox properties > items > collections ---
            switch(comboBox1.SelectedItem.ToString())
            {
                case "Normal":          pictureBox1.SizeMode = PictureBoxSizeMode.Normal; break;
                case "StretchImage":    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; break;
                case "Autosize":        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; break;
                case "CenterImage":     pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case "Zoom":            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; break;
            }
        }
    }
}
