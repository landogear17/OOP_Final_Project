using System.Data;
using System.Windows.Forms;

namespace Mood_Food
{
    public partial class Form1 : Form
    {

        FoodManager mgfood = new FoodManager();
        public Form1()
        {
            InitializeComponent();
            buttonMood.Enabled = false;
            tabControl1.TabPages[1].Enabled = false;
            tabControl1.TabPages[2].Enabled = false;
            
            addcombobox();
            addMoodsBefore();

        }

        private void buttonMood_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form2 form2 = new Form2(mgfood);
            form2.Show();
        }

        //public List<Meal> getMealForm1()
        //{
        //    return mgfood.Meal_list;
        //}

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if (comboBoxFoodtype.SelectedIndex == -1 || comboBoxTypeofFood.SelectedIndex == -1)
            {
                MessageBox.Show("Do not leave any empty fields");
                return;
            }
            buttonMood.Enabled = true;
            Meal person_meal = new Meal();
            person_meal.Food = comboBoxFoodtype.Text;
            person_meal.Size = numericUpDownPortionSize.Value;
            person_meal.Time = dateTimePickerTimeofDay.Value.TimeOfDay;


            mgfood.AddFoodList(person_meal);

            comboBoxTypeofFood.SelectedIndex = -1;
            numericUpDownPortionSize.Value = 0;
            dateTimePickerTimeofDay.Value = dateTimePickerTimeofDay.MinDate;

            comboBoxFoodtype.Items.Clear();
            comboBoxFoodtype.ResetText();
        }

        private void addcombobox()
        {
            foreach (var foods in mgfood.CuisineDictionary)
            {
                comboBoxlistfood.Items.Add(foods.Key);
            }
            foreach (var food in mgfood.CuisineDictionary)
            {
                comboBoxTypeofFood.Items.Add(food.Key);
            }
        }
        private void addListbox(int index)
        {
            checkedListBoxPreference.Items.Clear();
            comboBoxFoodtype.Items.Clear();

            switch (index)
            {
                case 0:
                    foreach (var food in mgfood.Italian)
                    {
                        checkedListBoxPreference.Items.Add(food);
                        comboBoxFoodtype.Items.Add(food);
                    }
                    break;
                case 1:
                    foreach (var food in mgfood.Japanese)
                    {
                        checkedListBoxPreference.Items.Add(food);
                        comboBoxFoodtype.Items.Add(food);
                    }
                    break;
                case 2:
                    foreach (var food in mgfood.Mexican)
                    {
                        checkedListBoxPreference.Items.Add(food);
                        comboBoxFoodtype.Items.Add(food);
                    }
                    break;
                case 3:
                    foreach (var food in mgfood.Mediterranean)
                    {
                        checkedListBoxPreference.Items.Add(food);
                        comboBoxFoodtype.Items.Add(food);
                    }
                    break;
                case 4:
                    foreach (var food in mgfood.Sweets)
                    {
                        checkedListBoxPreference.Items.Add(food);
                        comboBoxFoodtype.Items.Add(food);
                    }
                    break;
                case 5:
                    foreach (var food in mgfood.Fast_Food)
                    {
                        checkedListBoxPreference.Items.Add(food);
                        comboBoxFoodtype.Items.Add(food);
                    }
                    break;


            }

        }

        private void comboBoxlistfood_SelectedIndexChanged(object sender, EventArgs e)
        {
            addListbox(comboBoxlistfood.SelectedIndex);
            //here
            
        }
        private void comboBoxTypeofFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            addListbox(comboBoxTypeofFood.SelectedIndex);
        }

        private void buttonDislikes_Click(object sender, EventArgs e)
        {

            foreach (var item in checkedListBoxPreference.CheckedItems)
            {
                mgfood.DislikedFood.Add(item.ToString());
            }
            mgfood.DislikedFood = mgfood.DislikedFood.Distinct().ToList();
            tabactive();
            comboBoxlistfood.SelectedIndex = -1;
            comboBoxFoodtype.Text = " ";


        }

        private void checkBoxAte_CheckedChanged(object sender, EventArgs e)
        {
            tabactive();
        }

        public void tabactive()
        {
            if (checkBoxAte.Checked == true)
            {
                tabControl1.TabPages[1].Enabled = true;
                tabControl1.TabPages[2].Enabled = false;
                labelAte.Text = "Go to After Tab After selecting all your allergies/preferences";
            }
            else
            {
                tabControl1.TabPages[2].Enabled = true;
                tabControl1.TabPages[1].Enabled = false;
                labelAte.Text = "Go to Before Tab After selecting all your allergies/preferences";
            }
        }
        public void addMoodsBefore()
        {
            foreach (var mood in mgfood.Moods)
            {
                comboBoxMoods.Items.Add(mood.Moods);
            }
        }

        private void buttonRecommend_Click(object sender, EventArgs e)
        {
            mgfood.createPosiblefoodsList();

            if (comboBoxMoods.Text != "Very Happy")
            {
                labelview.Text = ($"If You are feeling {comboBoxMoods.Text} " +
                    $"maybe you should try eating from the list below");
            }
            else
            { labelview.Text = "Congratulations for feeling the best, You can see below many foods to try later"; }
            DataTable dt = new DataTable();
            dt.Columns.Add("Food");
            foreach (var food in mgfood.AllFoods)
            {
                dt.Rows.Add(food);
            }
            dataGridViewbefore.DataSource = dt;
            dataGridViewbefore.Columns[0].Width = 200;
        }
    }
}