/// created by : Andrew Johnson
/// date       : 03/14/20
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {

        int scene = 0;
        int luck = 0;
        int soup = 0;

        Random randgen = new Random();
        //
        //SoundPlayer bgmusic= new SoundPlayer(Properties.Resources.x);

        public Form1()
        {
            InitializeComponent();
        }


       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if blue button pressed
            if (e.KeyCode == Keys.B)
            {
                //if (scene == x) {scene = y;}
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 18; }
                else if (scene == 97) { scene = 1; }
                else if (scene == 98) { scene = 1; }
                else if (scene == 4) { scene = 14; }
                else if (scene == 5) { scene = 4; }
                else if (scene == 6) { scene = 12; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 15) { scene = 16; }
                else if (scene == 14) { scene = 19; }
                else if (scene == 20) { scene = 21; }
                else if (scene == 23) { scene = 29; }
                else if (scene == 24) { scene = 29; }
                else if (scene == 26) { scene = 27; }
            }

            //if yellow button pressed
            else if (e.KeyCode == Keys.N)
            {
                //if (scene == x) {scene = y;}
                if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 97; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 18) { scene = 97; }
                else if (scene == 4) { scene = 30; }
                else if (scene == 9) { scene = 97; }
                else if (scene == 10) { scene = 97; }
                else if (scene == 11) { scene = 97; }
                else if (scene == 12) { scene = 98; }
                else if (scene == 13) { scene = 97; }
                else if (scene == 16) { scene = 97; }
                else if (scene == 17) { scene = 97; }
                else if (scene == 19 && luck >= 6 && luck <= 100) { scene = 23; }
                else if (scene == 19 && luck <= 5 && luck >= 0) { scene = 20; }
                else if (scene == 21) { scene = 97; }
                else if (scene == 22) { scene = 23; }
                else if (scene == 23) { scene = 24; }
                else if (scene == 24 && soup <= 4) { scene = 24; } //this is intentional for a secret ending
                else if (scene == 24 && soup == 5) { scene = 25; }
                else if (scene == 25) { scene = 97; }
                else if (scene == 27) { scene = 97; }
                else if (scene == 28) { scene = 98; }
                else if (scene == 29) { scene = 97; }
                else if (scene == 30) { scene = 98; }
            }

            //if red button pressed
            else if (e.KeyCode == Keys.M)
            {
                //if (scene == x) {scene = y;}
                if (scene == 0) { scene = 99; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 97) { scene = 99; }
                else if (scene == 98) { scene = 99; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 14) { scene = 15; }
                else if (scene == 15) { scene = 17; }
                else if (scene == 20) { scene = 22; }
                else if (scene == 23) { scene = 26; }
                else if (scene == 26) { scene = 28; }
            }


            //decides what scene will play
            switch (scene)
            {
                /*
                    outputLabel.Text = "";
                    //imageBox.Image = Properties.Resources.scene_x;
                    blueButton.Text = "";
                    yellowButton.Text = "";
                    redButton.Text = "";
                 */
                case 0:
                    outputLabel.Text = "Welcome to Wario Dating Simulator, currently in build v1.0.0!";
                    imageBox.Image = Properties.Resources.scene_0;
                    blueButton.Text = "Play Game";
                    yellowButton.Text = "";
                    redButton.Text = "Exit Game";
                    break;
                case 1:
                    soup = 0;
                    outputLabel.Text = "Wario is picking you up for your date in 10 minutes! What will you wear?";
                    imageBox.Image = Properties.Resources.scene_1;
                    blueButton.Text = "Your sleek, red dress";
                    yellowButton.Text = "Your dirty clothes you haven't changed out of this week";
                    redButton.Text = "A yellow shirt with purple suspenders";
                    break;
                case 2:
                    outputLabel.Text = "Wario arrives and sees how you've dressed.";
                    outputLabel.Text += "\n\nWario is too embarrassed you are 'twinning' with him, and he dumps you on the spot.";
                    imageBox.Image = Properties.Resources.scene_2;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "Wario arrives and sees how you've dressed. He compliments how you smell like garlic.";
                    imageBox.Image = Properties.Resources.scene_3;
                    blueButton.Text = "";
                    yellowButton.Text = "Epic";
                    redButton.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "'Wah,' Wario starts, 'what do you want to do?'";
                    imageBox.Image = Properties.Resources.scene_4;
                    blueButton.Text = "Go for dinner";
                    yellowButton.Text = "Watch a movie";
                    redButton.Text = "Ascend";
                    break;
                case 5:
                    outputLabel.Text = "You suggest to Wario that you two should ascend.";
                    outputLabel.Text += "\n\n'Wah, are you sure? Ascension is very dangerous. We might not live through it, wah.'";
                    imageBox.Image = Properties.Resources.scene_5;
                    blueButton.Text = "Rethink decision";
                    yellowButton.Text = "";
                    redButton.Text = "Continue with ascension";
                    break;
                case 6:
                    outputLabel.Text = "Wario starts to drive to the ritual spot, and you dig the Necronomicon out of your back pocket.";
                    outputLabel.Text += "\n\nAfter you arrive, you hop off Wario's motorcycle.";
                    outputLabel.Text += "\n\n'Wah,' Wario starts, 'do you want to read the passage?'";
                    imageBox.Image = Properties.Resources.scene_6;
                    blueButton.Text = "Let Wario read";
                    yellowButton.Text = "";
                    redButton.Text = "Read it yourself";
                    break;
                case 7:
                    outputLabel.Text = "You say you'll read it, and Wario looks at you with concern in his eyes before motioning for you to follow him.";
                    outputLabel.Text += "\n\nLeading you through a small wooded patch, Wario stops at a red pentagram drawn in red chalk on the rocky ground. Lit candles already surround the perimeter, and as you step into the center, you prepare to read...";
                    imageBox.Image = Properties.Resources.scene_7;
                    blueButton.Text = "...from page 42";
                    yellowButton.Text = "";
                    redButton.Text = "...from page 127";
                    break;
                case 8:
                    outputLabel.Text = "You flip to page 42 and begin to read. About 3 words in you realize that you grabbed the Spanish version of the Necronomicon.";
                    outputLabel.Text += "\n\nStopping the incantation would result in a swift death for the two of you. Your only chance of ascending relies on if you've taken a Spanish class.";
                    imageBox.Image = Properties.Resources.scene_8;
                    blueButton.Text = "You've taken one";
                    yellowButton.Text = "";
                    redButton.Text = "You haven't taken one";
                    break;
                case 9:
                    outputLabel.Text = "You try to read the Spanish, but to no avail. The ground beneath you opens up into a big chasm, causing you and Wario to fall to your doom.";
                    imageBox.Image = Properties.Resources.scene_9;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "You try to recite the Spanish, but your grade 9 credit for the class was no help. You hear thunder rumble in the sky above you before being struck by lightning, killing you and Wario in less than 10 seconds.";
                    imageBox.Image = Properties.Resources.scene_10;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You flip to page 127 and begin to read. You flawlessly recite the passage from the Necronomicon, and when you finish you and Wario start to float into the air.";
                    outputLabel.Text += "\n\nAs you float higher and higher, you realize that both your and Wario's bodies are becoming transparent. 'Wah!' Wario shouts. 'You read the wrong passage!";
                    outputLabel.Text += "\n\nWario slowly fades from existance right in front of your eyes, with you following in his footsteps soon after. As you fade from reality, you wish you turned to page 42 before vanishing off the face of the planet.";
                    imageBox.Image = Properties.Resources.scene_11;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 12:
                    luck = randgen.Next(1, 101);
                    if (luck <= 15 && luck >= 0)
                    {
                        outputLabel.Text = "You hand Wario the Necronomicon and tell him you want him to read.";
                        outputLabel.Text += "\n\nWario wastes no time and flips to the passage. He flawlessly recites from the page (ceasing to amaze you), and you two wait... and wait... and wait.";
                        outputLabel.Text += "\n\nNothing happens. You and Wario decide to head home. You both feel saddened by the failure, but hey, at least you didn't die.";
                        imageBox.Image = Properties.Resources.scene_12;
                        blueButton.Text = "";
                        yellowButton.Text = "Accept your fate";
                        redButton.Text = "";
                    }
                    else if (luck >=16)
                    {
                        outputLabel.Text = "You hand Wario the Necronomicon and tell him you want him to read.";
                        outputLabel.Text += "\n\nUnfortunately, Wario couldn't recite more than 10 words in the passage without saying 'wha'. No one knows what happened to you two after the slip up, but you were never seen from again.";
                        imageBox.Image = Properties.Resources.scene_13;
                        blueButton.Text = "";
                        yellowButton.Text = "Accept your fate";
                        redButton.Text = "";
                        scene = 13;
                    }
                    break;
                
                case 13:
                    //sorry Mr. T, but scene 13 is just a jape. Don't trust it.
                    //my original plan for scene 13 was the fail ending for scene 12 but I realized during the 
                    //coding that I could just put both in a if else loop in scene 12
                    break;

                case 14:
                    outputLabel.Text = "'Wah-ha-ha!' Wario chortles. 'Dinner it is then!'";
                    outputLabel.Text += "\n\nWario smiles and asks where you want to go.";
                    imageBox.Image = Properties.Resources.scene_14;
                    blueButton.Text = "A 5 star restaurant";
                    yellowButton.Text = "";
                    redButton.Text = "Wario's choice";
                    break;
                case 15:
                    outputLabel.Text = "'Alright, Arby's! Wah, Arby's is my favorite!'";
                    outputLabel.Text += "\n\nYou've never heard anyone say that. Who likes Arby's? Since thats the only flaw you've seen in him the seven years you've known him, you shrug it off.";
                    outputLabel.Text += "\n\nYou're riding on the motorcycle with him, his greasy hair and sweaty back pushed against you... yes, this is the life. You lose track of time, and before you know it you've arrived at Arby's.";
                    outputLabel.Text += "\n\nWario helps you off his motorcycle, and you go inside to order. Wario orders one of everything off the kids menu, and you grab yourself a Brown Sugar Bacon Half Pound Club with extra Dijon.";
                    outputLabel.Text += "\n\nHowever, Wario's fries are looking kind of tasty...";
                    imageBox.Image = Properties.Resources.scene_15;
                    blueButton.Text = "Take one";
                    yellowButton.Text = "";
                    redButton.Text = "Don't take one";
                    break;
                case 16:
                    outputLabel.Text = "Wario sees you take a fry, and he is NOT having it.";
                    outputLabel.Text += "\n\nWario starts getting really angry that you didn't ask before you took, and to be fair he had a reasonable point; you just snatched them without asking. AND, since you chose to not order fries, that was your mistake.";
                    outputLabel.Text += "\n\nYou awkwardly laugh at Wario's death threats he's been shouting at you for the past 15 minutes, which really sets him off. While you thought he was joking, he was dead serious. Offended, he ends your life in one swift blow to the chest.";
                    imageBox.Image = Properties.Resources.scene_16;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You are well aware of the consequences that would occur if you took a fry, and you don't really feel like dying tonight.";
                    outputLabel.Text += "\n\nHowever, it slipped your mind that Wario can read thoughts. It was too late for you. Wario stands up on the table in front of you and reels his arm backwards.";
                    outputLabel.Text += "\n\n'W - Wario, I - I - I - ...' you stammer, but its too late for you. Wario thrusts his fist forward and punches your head clean off. ";
                    imageBox.Image = Properties.Resources.scene_17;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You put on the dress and you wait for Wario.";
                    outputLabel.Text += "\n\nIt's now been a week since the supposed 'date' and Wario still hasn't arrived. You realize you've been stood up, and die of a heartbreak. ";
                    imageBox.Image = Properties.Resources.scene_18;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "'Alright, let's go, wah!' Wario shouts. You hop on his motorcycle and drive off.";
                    luck = randgen.Next(1, 101);
                    imageBox.Image = Properties.Resources.scene_19;
                    blueButton.Text = "";
                    yellowButton.Text = "Wheeeeeee";
                    redButton.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "Wario pulls into a Tesco on the way, and begins to walk inside.";
                    outputLabel.Text += "\n\nYou ask Wario why he stopped at a Tesco. 'Wah, just need to deal with business matters,' He replies.";
                    outputLabel.Text += "\n\nRacking your brain for an answer to what he means by that, you finally remember that Wario is the manager of Tesco. You think about how much of an idiot you are for forgetting that.";
                    outputLabel.Text += "\n\nYou want to wait for Wario, but you're also really hungry. What should you do?";
                    imageBox.Image = Properties.Resources.scene_20;
                    blueButton.Text = "Get a quick snack";
                    yellowButton.Text = "";
                    redButton.Text = "Wait for Wario";
                    break;
                case 21:
                    outputLabel.Text = "You spot a garbage can near the entrance to the store, so you hop off the motorcycle to grab a quick bite.";
                    outputLabel.Text += "\n\nWhen you go to cross the street, a car comes barreling towards you. Paralyzed with fear, you can't move to escape the car's trail.";
                    outputLabel.Text += "\n\nFortunately, the car stops before it hits you. Unfortunately, the fear shocked you so much that you died from a heart attack on the spot.";
                    imageBox.Image = Properties.Resources.scene_21;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "After about 10 minutes, Wario leaves the store with a pack of Pokemon cards. 'Thank you for waiting, wah,' Wario says. He hands you the pack as sort of a 'thank-you' gift.";
                    outputLabel.Text += "\n\nYou put them in your pocket and continue to drive to dinner.";
                    imageBox.Image = Properties.Resources.scene_22;
                    blueButton.Text = "";
                    yellowButton.Text = "PogChamp\nPogChamp\nPogChamp";
                    redButton.Text = "";
                    break;
                case 23:
                    soup = 0;
                    outputLabel.Text = "After a short drive, you arrive at Chez Loiuse. Wario knows this is your favorite restaurant and sees the excitement in your eyes. 'Wah, only the best for you,' He says with a wink.";
                    outputLabel.Text += "\n\nYou hurry inside and get escorted to a table for two. ";
                    outputLabel.Text += "\n\nAfter chatting with Wario for a few minutes, a waiter comes to take your order.";
                    outputLabel.Text += "\n\n'What would you like, monsieur Wario ?' he asks. 'Wah, I'll have what they're having.' Wario replies while nodding in your direction.";
                    outputLabel.Text += "\n\nNow... what did you want again? You were busy chatting with Wario, you forgot already. I think you wanted the...";
                    imageBox.Image = Properties.Resources.scene_23;
                    blueButton.Text = "Mushroom Kababs";
                    yellowButton.Text = "Soup";
                    redButton.Text = "Fish Platter";
                    break;
                case 24:
                    soup = soup + 1;
                    outputLabel.Text = "You tell the waiter you want soup.";
                    outputLabel.Text += "\n\n'Désolé,but we ran out of soup earlier and have been too busy to make more,' the waiter says. 'Is there something else you would like to order ? ";
                    imageBox.Image = Properties.Resources.scene_24;
                    blueButton.Text = "Mushroom Kababs";
                    yellowButton.Text = "Soup";
                    redButton.Text = "Fish Platter";
                    break;
                case 25:
                    outputLabel.Text = "'Are you joking ?' the Waiter asks. 'This is the fifth time you've asked for soup. We. Don't. Have. Any. You know what? Just leave. We don't serve idiots.'";
                    imageBox.Image = Properties.Resources.scene_25;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 26:
                    outputLabel.Text = "You tell the waiter you want the Fish Platter.";
                    outputLabel.Text += "\n\n'Tres bien, I will bring two Fish Platters right away,' he replies before walking off.";
                    outputLabel.Text += "\n\nYou start chatting with Wario again, and before you know it the Platters are sitting on the table in front of you. 'Let's dig in, wah?' asks Wario shortly before stuffing his face anyways.";
                    outputLabel.Text += "\n\nWhile you start on your plate, Wario has already finished his. 'Wah, are you going to finish that?'";
                    imageBox.Image = Properties.Resources.scene_26;
                    blueButton.Text = "No";
                    yellowButton.Text = "";
                    redButton.Text = "Yes";
                    break;
                case 27:
                    outputLabel.Text = "You give Wario the platter and he swallows it all in one gulp.";
                    outputLabel.Text += "\n\nIn what seems like mere seconds, Wario was on the ground gasping for air. And that's when it hits you... Wario has a seafood allergy.";
                    outputLabel.Text += "\n\nAnd as Wario lay lifeless on the ground now surrounded by doctors and medics you can't help but blame yourself for not choosing to watch a movie earlier. ";
                    imageBox.Image = Properties.Resources.scene_27;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 28:
                    outputLabel.Text = "You tell Wario that you're really hungry and want to eat your food. ";
                    outputLabel.Text += "\n\nHe understands and lets you eat in peace. After you finish he pays for the meal and drives you home. Overall, it was a successful date night.";
                    imageBox.Image = Properties.Resources.scene_28;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 29:
                    outputLabel.Text = "You tell the waiter you want the Mushroom Kabobs, but Wario stops you.";
                    outputLabel.Text += "\n\n'You don't even like mushrooms,' he says, 'have you been seeing Mario? Are you cheating on me?!";
                    outputLabel.Text += "\n\nYou can tell he's serious as he hasn't said 'wah' once in that whole sentence. You tell Wario you would never, but he doesn't believe you and breaks up with you on the spot.";
                    imageBox.Image = Properties.Resources.scene_29;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 30:
                    outputLabel.Text = "You say you want to watch a movie and invite Wario inside. Rather than go to a theater, you two would rather watch romantic comedies in the comfort of your own apartment.";
                    outputLabel.Text += "\n\nAfter the movie ends, Wario says goodnight and heads home. While being a rather low-key date, you probably wouldn't have had fun doing the other options.";
                    imageBox.Image = Properties.Resources.scene_30;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 97:
                    outputLabel.Text = "Game over! \n\nWould you like to play again?";
                    imageBox.Image = Properties.Resources.scene_97;
                    blueButton.Text = "Yes";
                    yellowButton.Text = "";
                    redButton.Text = "No";
                    break;
                case 98:
                    outputLabel.Text = "Congratulations, you didn't lose!\n\nWould you like to play again?";
                    imageBox.Image = Properties.Resources.scene_98;
                    blueButton.Text = "Yes";
                    yellowButton.Text = "";
                    redButton.Text = "No";
                    break;
                case 99: //Exit the environment
                    Environment.Exit(1);
                    break;
                default:
                    outputLabel.Text = "Welcome to Wario Dating Simulator, currently in build v1.0.0!";
                    imageBox.Image = Properties.Resources.scene_0;
                    blueButton.Text = "Play Game";
                    yellowButton.Text = "";
                    redButton.Text = "Exit Game";
                    break;
            }
        }
    }
}
