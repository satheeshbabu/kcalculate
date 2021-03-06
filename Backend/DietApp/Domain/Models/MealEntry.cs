﻿using System;

namespace DietApp.Domain.Models
{
    public class MealEntry
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public Nutrients Nutrients { get; set; }
        public int WeightGram { get; set; }
        public int Kcal { get => WeightGram * Nutrients.KcalPer100Gram / 100; } //TODO: Rozważyć czy tylko gram, czy dodać np sztuki
    }
}
