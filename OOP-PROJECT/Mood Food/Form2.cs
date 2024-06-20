using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food
{
    public partial class Form2 : Form
    {
        private FoodManager foodmanage;
        List<Meal> meal_list_Form2 = new List<Meal>();
        int count = 0;

        string mood;
        public List<string> availableFoods = new List<string>();

        

        public Form2(FoodManager foodmg)
        {
            InitializeComponent();
            foodmanage = foodmg;
            meal_list_Form2 = foodmg.Meal_list;
            labelFood.Text = meal_list_Form2[count].Food;
            foodmanage.createPosiblefoodsList();
        }



       
        private int getprom(int sumrate)
        {
            int prom = 0;
            return prom = sumrate / meal_list_Form2.Count;
        }
        private string set_Mood(int valueRate)
        {
            string final_mood=" ";
            foreach (var mood in foodmanage.Moods)
            {
                if (valueRate == mood.Rate)
                    final_mood = mood.Moods;
            }
            return final_mood;
        }
        private void recomendation(int valueRate)
        {
            //availableFoods
            //mood

            MyMessageBox ms = new MyMessageBox();


            switch (valueRate)
            {
                case 1:
                    ms.LabelText = "We can see your mood is very sad \nand we suggest you to eat one of this \nrecommended food for you!";
                    ms.SetDataGridViewData(availableFoods);
                    ms.ShowDialog();
                    break;
                case 2:
                    ms.LabelText = "We can see your mood is sad \nand we suggest you to eat one of this \nrecommended food for you!";
                    ms.SetDataGridViewData(availableFoods);
                    ms.ShowDialog();
                    break;
                case 3:
                    ms.LabelText = "We can see your mood is neutral sad \nand we suggest you to eat one of this \nrecommended food for you!";
                    ms.SetDataGridViewData(availableFoods);
                    ms.ShowDialog();
                    break;
                case 4:
                    ms.LabelText = "We can see your mood is happy \nand we suggest you to eat one of this \nrecommended food for you!";
                    ms.SetDataGridViewData(availableFoods);
                    ms.ShowDialog();
                    break;
                case 5:
                    ms.LabelText = "We can see your mood is very happy and we are happy for you, \nif you would like to have something to eat \nyou can try one of this recommended foods for you!";
                    ms.SetDataGridViewData(availableFoods);
                    ms.ShowDialog();
                    break;
            }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Mood mood_form2 = new Mood();
            mood_form2.Rate = Convert.ToInt32(numericUpDownRate.Value);
            //prom =2 => You are sad maybe u should eat some "pasta"
            int bonus = 0;
            bonus += foodmanage.getTypeFood(labelFood.Text);
            int ratesum = 0;
            ratesum += mood_form2.Rate;

            foodmanage.AllFoods.Remove(labelFood.Text);


            numericUpDownRate.Value = 1;

            count++;

            if (meal_list_Form2.Count > count)
            {
                labelFood.Text = meal_list_Form2[count].Food;
                //label.text(cada uno de los string de la lista de comidas escogidas) == busca si existe dict de todos los alimentos
                //coge el value del dict y lo pone en una variable bonus
            }
            else
            {
                buttonAddFood.Enabled = false;
                int prom = getprom(bonus + ratesum);
                availableFoods = foodmanage.AllFoods;
                mood = set_Mood(prom);
                recomendation(prom);
            }
        }
    }
}
