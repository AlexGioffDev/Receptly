public class Meal
{
    public string IdMeal { get; set; }
    public string StrMeal { get; set; }
    public string StrCategory { get; set; }
    public string StrArea { get; set; }
    public string StrInstructions { get; set; }
    public string StrMealThumb { get; set; }
    public string StrTags { get; set; }
    public string StrYoutube { get; set; }
    public string StrSource { get; set; }

    public string StrIngredient1 { get; set; }
    public string StrIngredient2 { get; set; }
    public string StrIngredient3 { get; set; }
    public string StrIngredient4 { get; set; }
    public string StrIngredient5 { get; set; }
    public string StrIngredient6 { get; set; }
    public string StrIngredient7 { get; set; }
    public string StrIngredient8 { get; set; }
    public string StrIngredient9 { get; set; }
    public string StrIngredient10 { get; set; }
    public string StrIngredient11 { get; set; }
    public string StrIngredient12 { get; set; }
    public string StrIngredient13 { get; set; }
    public string StrIngredient14 { get; set; }
    public string StrIngredient15 { get; set; }
    public string StrIngredient16 { get; set; }
    public string StrIngredient17 { get; set; }
    public string StrIngredient18 { get; set; }
    public string StrIngredient19 { get; set; }
    public string StrIngredient20 { get; set; }

    public string StrMeasure1 { get; set; }
    public string StrMeasure2 { get; set; }
    public string StrMeasure3 { get; set; }
    public string StrMeasure4 { get; set; }
    public string StrMeasure5 { get; set; }
    public string StrMeasure6 { get; set; }
    public string StrMeasure7 { get; set; }
    public string StrMeasure8 { get; set; }
    public string StrMeasure9 { get; set; }
    public string StrMeasure10 { get; set; }
    public string StrMeasure11 { get; set; }
    public string StrMeasure12 { get; set; }
    public string StrMeasure13 { get; set; }
    public string StrMeasure14 { get; set; }
    public string StrMeasure15 { get; set; }
    public string StrMeasure16 { get; set; }
    public string StrMeasure17 { get; set; }
    public string StrMeasure18 { get; set; }
    public string StrMeasure19 { get; set; }
    public string StrMeasure20 { get; set; }

    public List<(string Ingredient, string Measure)> ValidIngredients
    {
        get
        {
            var list = new List<(string, string)>();
            for (int i = 1; i <= 20; i++)
            {
                var ingredient = (string?)GetType().GetProperty($"StrIngredient{i}")?.GetValue(this);
                var measure = (string?)GetType().GetProperty($"StrMeasure{i}")?.GetValue(this);

                if (!string.IsNullOrWhiteSpace(ingredient) && !string.IsNullOrWhiteSpace(measure))
                {
                    list.Add((ingredient.Trim(), measure.Trim()));
                }
            }

            return list;
        }
    }
}
