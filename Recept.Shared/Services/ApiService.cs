using System.Net.Http;
using System.Net.Http.Json;

public class ApiService
{
    private readonly HttpClient _http;

    public ApiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Meal>> GetRandomRecepts(int count = 10)
    {
        var uniqueMeals = new Dictionary<string, Meal>();

        while (uniqueMeals.Count < count)
        {
            var meal = await GetSingleRandomMeal();
            if (meal != null && !uniqueMeals.ContainsKey(meal.IdMeal))
            {
                uniqueMeals[meal.IdMeal] = meal;
            }

        }

        return uniqueMeals.Values.ToList();
    }

    public async Task<Meal> GetSingleMeal(string MealId)
    {
        var response = await _http.GetFromJsonAsync<MealResponse>($"https://www.themealdb.com/api/json/v1/1/lookup.php?i={MealId}");
        return response.Meals.FirstOrDefault();
    }

    public async Task<List<Meal>> SearchMealByIngredient(string ingredient)
    {
        var response = await _http.GetFromJsonAsync<MealResponse>($"https://www.themealdb.com/api/json/v1/1/filter.php?i={ingredient}");
        return response.Meals;
    }

    private async Task<Meal> GetSingleRandomMeal()
    {
        var response = await _http.GetFromJsonAsync<MealResponse>("https://www.themealdb.com/api/json/v1/1/random.php");
        return response?.Meals?.FirstOrDefault();
    }
}



public class MealResponse
{
    public List<Meal> Meals { get; set; }
}