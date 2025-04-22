using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace ClothingForm
{
    enum Size
    {
        S = 1, M, L, X, XXL, OS
    }
    enum Status
    {
        Not_in_use = 1, Little_used, Used_a_lot
    }
    internal class ClothingItem
    {
        Size _size;
        Status _status;
        private static uint item_SerialN = 1;
        private int serialitem;
        int price;
        string[] seasons = new string[4];
        string name, color, clothing_type, brand, user_id;
        bool is_favorite, is_revealing;
        public string Color
        {
            get => color;
            set
            {
                while (true) {
                    if (value[0] != '#') {
                        Console.WriteLine("The first tav isn't right. Add # at the beginning.");


                        value = Console.ReadLine();
                        continue;
                    }
                    if (value.Length != 7) {
                        Console.WriteLine("The code lenght isn't right. Enter 6 tavs after #.");

                        value = Console.ReadLine();
                        continue;

                    }
                    for (int i = 1; i < value.Length; i++) {
                        if ((value[i] < 'a' || value[i] > 'f') && (value[i] <

                        'A' || value[i] > 'F') && !char.IsDigit(value[i])) {
                            Console.WriteLine("The color code isn't valid. Make sure you enter valid tavs.");



                            value = Console.ReadLine();
                            continue;
                        }
                    }
                    break;
                }
                color = value;
            }
        }
        public int Price
        {
            get => price;
            set
            {
                while (true) {
                    if (value < 0) {
                        Console.WriteLine("The price isn't valid. Please enter again.");



                        value = int.Parse(Console.ReadLine());
                        continue;
                    }
                    price = value;
                    break;
                }
            }
        }
        internal Status Status
        {
            get => _status;
            set
            {
                {
                    int new_value = (int)value;
                    while (true) {
                        if (new_value != 1 && new_value != 2 && new_value != 3) {
                            Console.WriteLine("The status isn't right. Please enter again.");



                            new_value = int.Parse(Console.ReadLine());
                            continue;
                        }
                        break;
                    }
                    _status = (Status)new_value;
                }
            }
        }
        internal Size Size { get => _size; set => _size = value; }
        public static uint Item_SerialN
        {
            get => item_SerialN; set =>
        item_SerialN = value;
        }
        public string User_id { get => user_id; set => user_id = value; }
        public ClothingItem(string user_id, string name, string color, int
        price, string[] seasons, int size, string is_favorite, int status, string
        clothing_type, string brand, string is_revealing)
        {
            this.serialitem = (int)item_SerialN++;
            this.user_id = user_id;
            this.Color = color;
            this.Price = price;
            this.Status = (Status)status;
            this.Size = (Size)size;
            Set_is_revealing(is_revealing);
            this.seasons = seasons;
            this.name = name;
            this.clothing_type = clothing_type;
            this.brand = brand;
            if (is_favorite.ToLower() == "no" || is_favorite.ToLower() ==

            "false" || is_favorite == "0") {
                this.is_favorite = false;
            }
            else this.is_favorite = true;
        }
        public ClothingItem() { }
        public void Print()
        {
            Console.WriteLine("\n ~Clothing Item Details~");
            Console.WriteLine($"User id: {user_id}");
            Console.WriteLine($"Unit ID: {serialitem}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Season: {string.Join(", ", seasons)}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Favorite Item: {(is_favorite ? "Yes" : "No")}");
            Console.WriteLine($"Status: {Status}");

            Console.WriteLine($"Clothing Type: {clothing_type}");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Is revealing: {(is_revealing ? "Yes" :"No")}\n");
        }
        public void Set_is_revealing(string is_revealing)
        {
            if (is_revealing.ToLower() == "no" || is_revealing.ToLower() ==

            "false" || is_revealing == "0") {
                this.is_revealing = false;
            }
            else this.is_revealing = true;
        }
        public bool Get_is_revealing()
        {
            return this.is_revealing;
        }
    }
}