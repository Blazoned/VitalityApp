using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using TeamBoss.GAC.Vitality.Logic;

namespace TeamBoss.GAC.Vitality.AspCore.Controllers
{
    public class MovementController : Controller
    {
        Challenge challenge1 = new Challenge(false, 10, 0, 4, "Ga je mee zwemmen?", "Baantjes", "Baantjes Trekken", "Vijfkamplaan 12, 5624 Eindhoven, Netherlands");
        Challenge challenge2 = new Challenge(true, 25, 1, 5, "Joggen voor je gezondheid!", "KM", "Joggen", "Rachelsmolen R1, Eindhoven, Noord-Brabant 5612, Netherlands");
        Challenge challenge3 = new Challenge(false, 3, 2, 2, "Tennissen!", "Sets", "Sets Tennissen", "Anconalaan 1, 5632 Eindhoven, Netherlands");

        [HttpGet]
        public IActionResult CreateChallenge()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChallengeInfo(int id = 0)
        {
            ChallengeInfoViewModel viewModel = new ChallengeInfoViewModel();
            if(id == 0)
            {
                viewModel.SelectedChallenge = challenge1;
            }
            else if(id == 1)
            {
                viewModel.SelectedChallenge = challenge2;
            }
            else if(id == 2)
            {
                viewModel.SelectedChallenge = challenge3;
            }

            viewModel.PercentageDone = (int)((float)viewModel.SelectedChallenge.Progress / (float)viewModel.SelectedChallenge.Goal * 100.0f);
            viewModel.PercentageToGo = (int)(((float)viewModel.SelectedChallenge.Goal - (float)viewModel.SelectedChallenge.Progress) / viewModel.SelectedChallenge.Goal * 100.0f);

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.PublicChallenges = new List<Challenge>();
            viewModel.PrivateChallenges = new List<Challenge>();

            viewModel.PublicChallenges.Add(challenge1);
            viewModel.PublicChallenges.Add(challenge3);

            viewModel.PrivateChallenges.Add(challenge2);

            return View(viewModel);
        }

        public IActionResult Invite()
        {
            return View();
        }
    }
}