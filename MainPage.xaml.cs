namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        string[] FlashcardsPl = {"wąż", "koń", "pies","ptak", "kot","krowa","królik"};
        string[] FlashcardsEn = {"snake", "horse", "dog","bird", "cat","cow","rabbit"};
        int index = 0;
        int points_count = 0;
        bool reverse_check = false; //false - polski



        private void reverse_Clicked(object sender, EventArgs e)
        {
            if(reverse_check==false)
            {
                reverse_check=true;
                flashcard.Text = FlashcardsEn[index];
            }
            else
            {
                reverse_check=false;
                flashcard.Text = FlashcardsPl[index];
            }
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            index++;
            if(index>=FlashcardsEn.Length)
            {
                index=0;
            }
            if(index==0)
            {
                if(reverse_check==false)
                {
                    flashcard.Text = FlashcardsPl[0];

                }
                else
                {
                    flashcard.Text = FlashcardsEn[0];

                }

            }
            
            else
            {
                
                if (reverse_check==false)
                {
                    flashcard.Text = FlashcardsPl[index];
                }
                else
                {
                    flashcard.Text = FlashcardsEn[index];

                }
            }

        }

        private void points_Clicked(object sender, EventArgs e)
        {
            points_count++;
            points.Text = "Points : "+points_count;
        }

        private void Previous_Clicked(object sender, EventArgs e)
        {
            index--;
            if(index<0)
            {
                index=FlashcardsPl.Length;
            }
            else
            {
                if(reverse_check==false)
                {
                    flashcard.Text=FlashcardsPl[index];
                }
                else
                {
                    flashcard.Text=FlashcardsEn[index]; 
                        
                }
            }
                   
        }
    }

}
