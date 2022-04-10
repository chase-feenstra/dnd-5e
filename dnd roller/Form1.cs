namespace dice_roller
{
    public partial class dndroller : Form
    {
        Random Dice = new Random();
        public dndroller()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int randomNum1 = Dice.net (1, 7);
            int randomNum2 = dice.net (1, 7);

            switch (randomNum1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\6.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\4.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\2.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\5.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:Users\chase\videos\dice\6.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }