using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamBoss.GAC.Vitality.Logic;
using TeamBoss.GAC.Vitality.AspCore.ViewModels.FoodViewModels;  

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
    public class FoodController : Controller
    {
        //create data
        #region Recipe1
        int id = 1; 
        int preperationTime = 30;
        int totalCalories = 266;
        int servingsCount = 1;

        List<Reaction> reactions = new List<Reaction>()
            {
                new Reaction("Tom", "Heel lekker"),
                new Reaction("Martijn", "Zeker een aanrader!"),
                new Reaction("Mart", "Ik zou er iets minder zout in doen. Voor de rest is het een primma pizza."),
            };

        List<string> imageLinks = new List<string>()
            {
                @"/images/FoodSystem/PizzaSalami.JPG",
                @"/images/FoodSystem/PizzaSalami2.JPG",
            };

        List<string> ingredients = new List<string>()
            {
               "2 Pizzabodem",
                "Tomatenpuree",
                "Salami (plakjes)",
                "Rode paprika",
                "Groene paprika",
                "Gele paprika",
                "strooikaas",
                "Italiaanse tuinkruiden",
                "Oven",
                "Snijplank",
                "3 schaaltjes",
                "Mesje",
                "Bakpapier",
                "Bakplaat",
            };

        string creatorName = "Bryan";
        string description = "- Verwarm de oven op 200 graden" +
            "- Snij de rode, gele en groene paprika's in stukjes en doe ze in de schaaltjes. Op kleur gesorteerd." +
            "- Pak de pizzabodems en ze smeer het in met tomatenpuree." +
            "- Strooi daarna paprikastukjes op de pizza's." +
            "- Leg dan de salami plakjes op de pizza's." +
            "- Strooi daarna de kaas er overheen." +
            "- Dan strooi je een beetje Italiaanse tuinkruiden erover heen." +
            "" +
            "Bedek de bakplaat met bakpapier en doe de pizza erop. Doe het in de voorverwarmde oven en bak de pizza 10 minuten in de oven." +
            "" +
            "Haal de pizza uit de oven en eet het lekker op!";
        string name = "Pizza Salami";
        #endregion

        #region Recipe2
        int id2 = 2; 
        int preperationTime2 = 30;
        int totalCalories2 = 595;
        int servingsCount2 = 4;

        List<Reaction> reactions2 = new List<Reaction>()
            {
                new Reaction("Tom", "Heel lekker"),
                new Reaction("Martijn", "Zeker een aanrader!"),
                new Reaction("Mart", "Ik zou er iets minder zout in doen. Voor de rest is het een primma te eten."),
            };

        List<string> imageLinks2 = new List<string>()
            {
                @"/images/FoodSystem/SnelleBami.JPG",
                @"/images/FoodSystem/SnelleBami2.JPG",
            };

        List<string> ingredients2 = new List<string>()
            {
               "250 g mienestjes",
                "1 teen knoflook",
                "1 cm verse gember",
                "900 g nasi-bamigroenten",
                "4 el arachideolie",
                "3 el sojasaus",
                "50 g ongezouten pinda's",
                "4 middelgrote eieren",
            };

        string creatorName2 = "Romal";
        string description2 = "- Kook de mienestjes volgens de aanwijzingen op de verpakking en giet af. Snijd ondertussen de knoflook fijn en schil en rasp de gember. Snijd het steeltje van 1 rode peper (bij 4 personen) uit de nasi-bamigroente. Halveer de peper in de lengte, verwijder met een scherp mesje de zaadlijsten en snijd het vruchtvlees fijn. De andere peper wordt voor 4 personen niet gebruikt." +
            "- Verhit de helft van de olie in een wok of hapjespan en bak de knoflook en gember 1 min. Voeg de sojasaus, rode peper en nasi-bamigroente toe. Roerbak 4 min. tot de groenten geslonken zijn." +
            "Hak ondertussen de pinda’s grof. Schep de mie door de groenten. Breng eventueel op smaak met extra sojasaus. Houd warm onder een deksel. Verhit de rest van de olie in een koekenpan met antiaanbaklaag en bak een spiegelei per persoon. Breng op smaak met peper en eventueel zout. Verdeel de bami over de borden en serveer met de spiegeleieren. Bestrooi het gerecht met de pinda’s.";
        string name2 = "Snelle Bami";
        #endregion

        public IActionResult Index()
        {
            List<Recipe> recipes = new List<Recipe>()
            {
                new Recipe(id, preperationTime, totalCalories, servingsCount, reactions, imageLinks, ingredients, creatorName, description, name),
                new Recipe(id2, preperationTime2, totalCalories2, servingsCount2, reactions2, imageLinks2, ingredients2, creatorName2, description2, name2)
            };

            //fill viewmodel
            IndexViewModel indexVM = new IndexViewModel();
            indexVM.recipes = recipes; 

            return View(indexVM);
        }

        public IActionResult CreateRecept()
        {
            return View();
        }

        public IActionResult SearchRecepts()
        {
            return View();
        }

        public IActionResult ViewRecept(int recipeId)
        {
            List<Recipe> recipes = new List<Recipe>()
            {
                new Recipe(id, preperationTime, totalCalories, servingsCount, reactions, imageLinks, ingredients, creatorName, description, name),
                new Recipe(id2, preperationTime2, totalCalories2, servingsCount2, reactions2, imageLinks2, ingredients2, creatorName2, description2, name2)
            };

            Recipe recipe = recipes.Find(r => r.Id == recipeId);

            //fill viewmodel
            ViewReceptViewModel viewReceptVM = new ViewReceptViewModel();
            viewReceptVM.recipe = recipe; 

            return View(viewReceptVM);
        }

        public IActionResult RecipeReactions()
        {
            return View();
        }

        public IActionResult SavedRecipes()
        {
            return View();
        }

        public IActionResult CalorieCounter()
        {
            return View();
        }
    }
}