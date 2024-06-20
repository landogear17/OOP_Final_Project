using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food
{
    public class FoodManager
    {
        private List<string> italian= new List<string>{ "Spaghetti Bolognese", "Margherita Pizza", "Risotto" };
        private List<string> japanese = new List<string> { "Sushi (Nigiri)", "Ramen", "Tempura" };
        private List<string> mexican = new List<string> { "Tacos", "Guacamole", "Enchiladas" };
        private List<string> mediterranean = new List<string> { "Hummus", "Greek Salad", "Falafel" };
        private List<string> sweets = new List<string> { "Chocolate Cake", "Ice Cream", "Cupcakes" };
        private List<string> fast_Food = new List<string> { "Burger", "French Fries", "Chicken Nuggets" };
        private List<string> allFoods = new List<string> { "Spaghetti Bolognese", "Margherita Pizza", "Risotto" , "Sushi (Nigiri)", "Ramen", "Tempura",
                                                           "Tacos", "Guacamole", "Enchiladas", "Hummus", "Greek Salad", "Falafel" ,"Chocolate Cake", "Ice Cream", "Cupcakes",
                                                            "Burger", "French Fries", "Chicken Nuggets" };

        private Mood very_sad = new Mood("Very Sad",1);
        private Mood sad = new Mood("Sad", 2);
        private Mood neutral = new Mood("Neutral", 3);
        private Mood happy = new Mood("Happy", 4);
        private Mood very_happy = new Mood("Very Happy", 5);


        private List<String> dislikedFood = new List<string>();

        private Dictionary<List<string>, int> foodsRates = new Dictionary<List<string>, int>();
            
        private List<Meal> meal_list = new List<Meal>();

        private List<Mood> moods= new List<Mood>();

        public FoodManager() { 
            addDict();
            addlistmood();
            FillDictionay();
        }


        private Dictionary<string, List<string>> cuisineDictionary = new Dictionary<string, List<string>>();

        public List<string> Italian { get => italian; set => italian = value; }
        public List<string> Japanese { get => japanese; set => japanese = value; }
        public List<string> Mexican { get => mexican; set => mexican = value; }
        public List<string> Mediterranean { get => mediterranean; set => mediterranean = value; }
        public List<string> Sweets { get => sweets; set => sweets = value; }
        public List<string> Fast_Food { get => fast_Food; set => fast_Food = value; }
        public Dictionary<string, List<string>> CuisineDictionary { get => cuisineDictionary; set => cuisineDictionary = value; }
        public List<Mood> Moods { get => moods; set => moods = value; }
        public Mood Very_sad { get => very_sad; set => very_sad = value; }
        public Mood Sad { get => sad; set => sad = value; }
        public Mood Neutral { get => neutral; set => neutral = value; }
        public Mood Happy { get => happy; set => happy = value; }
        public Mood Very_happy { get => very_happy; set => very_happy = value; }
        public List<Meal> Meal_list { get => meal_list; set => meal_list = value; }
        public Dictionary<List<string>, int> FoodsRates { get => foodsRates; set => foodsRates = value; }
        public List<string> DislikedFood { get => dislikedFood; set => dislikedFood = value; }
        public List<string> AllFoods { get => allFoods; set => allFoods = value; }
        

        public void addDict()
        {
            cuisineDictionary.Add("Italian",italian);
            cuisineDictionary.Add("Japanese", japanese);
            cuisineDictionary.Add("Mexican", mexican);
            cuisineDictionary.Add("Mediterranean", mediterranean);
            cuisineDictionary.Add("Sweets", sweets);
            cuisineDictionary.Add("Fast Food", fast_Food);

        }

        public void addlistmood()
        {
            moods.Add(very_sad);
            moods.Add(sad);
            moods.Add(neutral);
            moods.Add(happy);
            moods.Add(very_happy);
        }
        
        public void AddFoodList(Meal meal)
        {
            meal_list.Add(meal);
        }

        public void FillDictionay()
        {
            foodsRates[italian] = 0;
            foodsRates[japanese] = 1;
            foodsRates[mexican] = 0;
            foodsRates[mediterranean] = 1;
            foodsRates[sweets] = -1;
            foodsRates[fast_Food] = -1;
        }
        

        public int getTypeFood(string food)
        {
            if (italian.Contains(food))
                return foodsRates[italian];
            if (japanese.Contains(food))
                return foodsRates[japanese];
            if (mexican.Contains(food))
                return foodsRates[mexican];
            if (mediterranean.Contains(food))
                return foodsRates[mediterranean];
            if (sweets.Contains(food))
                return foodsRates[sweets];
            if (fast_Food.Contains(food))
                return foodsRates[fast_Food];

            return 0;
        }

        public void createPosiblefoodsList()
        {
            allFoods.RemoveAll(item => dislikedFood.Contains(item));
        }
    }
}
