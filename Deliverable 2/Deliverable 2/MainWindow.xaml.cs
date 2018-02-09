using System;
using System.Windows;
namespace Deliverable_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Actor act;
        Map_Cell MC;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating the Actor object after the button is entered and validating the input from form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtActorName.Text != null & txtTitle.Text != null & txtHP.Text != null & txtAttackSpeed.Text != null & txtX.Text != null & txtY.Text != null)
            {
                if ((txtActorName.Text != "" & txtTitle.Text != "") || txtHP.Text != "" || txtAttackSpeed.Text != "" || txtX.Text != "" || txtY.Text != "")
                {
                    try
                    {
                        string Name = txtActorName.Text;
                        string Title = txtTitle.Text;
                        int MaxHp = int.Parse(txtHP.Text);
                        int AttackSpeed = int.Parse(txtAttackSpeed.Text);
                        int PositionX = int.Parse(txtX.Text);
                        int PositionY = int.Parse(txtY.Text);
                        act = new Actor(Name, Title, MaxHp, AttackSpeed, PositionX, PositionY);
                        act.Capatalized(act.Name);
                        act.TitleCase(act.Title);
                        Update();
                    }
                    catch
                    {
                        MessageBox.Show("Only Int value");
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Value in all the field");
                }
            }
            else
            {
                MessageBox.Show("Enter Value to create Actor :)");
            }
        }
        /// <summary>
        /// Damage the actor based upon the button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDamageActor_Click(object sender, RoutedEventArgs e)
        {
            if (act != null)
            {
                act.Damage(10);
                Update();

            }

        }
        /// <summary>
        /// updating the output
        /// </summary>
        public void Update()
        {
            tbActorOutput.Text = String.Format("Name: {0}\nNameWithTitle: {1}\nHP: {2}/{3}\nAttackSpeed: {4}\nX: {5}\nY: {6}", act.Name, act.Title, act.CurrentHP, act.MaxHP, act.AttackSpeed, act.PositionX, act.PositionY);
        }
        /// <summary>
        /// Healing the actor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHealActor_Click(object sender, RoutedEventArgs e)
        {
            if (act != null)
            {
                act.Heal(5);
                Update();

            }
        }
        /// <summary>
        /// actor's move in the map and location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveLeft_Click(object sender, RoutedEventArgs e)
        {
            if (act != null)
            {
                act.Move(Actor.direction.Left);
                Update();

            }
        }
        private void btnMoveUp_Click(object sender, RoutedEventArgs e)
        {
            if (act != null)
            {
                act.Move(Actor.direction.Up);
                Update();

            }
        }

        private void btnMoveDown_Click(object sender, RoutedEventArgs e)
        {
            if (act != null)
            {
                act.Move(Actor.direction.down);
                Update();
            }
        }

        private void btnMoveRight_Click(object sender, RoutedEventArgs e)
        {
            if (act != null)
            {
                act.Move(Actor.direction.Right);
                Update();
            }
        }
        /// <summary>
        /// Creating the Item object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateItem_Click(object sender, RoutedEventArgs e)
        {

            string ItemName = txtItemName.Text;
            if (txtAffectValue.Text != null & txtAffectValue.Text != "")
            {
                try
                {
                    int Value = int.Parse(txtAffectValue.Text);
                    tbItemOutput.Text = String.Format("Name: {0}\nValue: {1}", ItemName, Value);
                    Item It = new Item("", 0);
                }
                catch
                {
                    MessageBox.Show("Enter Approprate Value in Item");
                }
            }
        }
        /// <summary>
        /// creating the mapcell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMapCell_Click(object sender, RoutedEventArgs e)
        {
            MC = new Map_Cell(false, false, false);
            if (rbHasMonster.IsChecked == true)
            {
                MC.HasMonster = true;
                MC.HasItem = false;
            }
            else if (rbHasItem.IsChecked == true)
            {
                MC.HasItem = true;
                MC.HasMonster = false;
            }
            else
            {
                MC.HasMonster = false;
                MC.HasItem = false;
            }
            MC.IsDiscovered = false;
            tbMapCellOutput.Text = String.Format("Is Discovered: {0}\nHas Monster: {1}\nHas Item: {2}", MC.IsDiscovered, MC.HasMonster, MC.HasItem);
        }
        private void btnMarkCellDiscovered_Click(object sender, RoutedEventArgs e)
        {
            MC.Discovered(true);
            tbMapCellOutput.Text = String.Format("Is Discovered: {0}\nHas Monster: {1}\nHas Item: {2}", MC.IsDiscovered, MC.HasMonster, MC.HasItem);
        }
    }
}