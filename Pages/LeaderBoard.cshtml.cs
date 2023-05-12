using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ArcadeClasses;
using Arcade.Models;
using Microsoft.EntityFrameworkCore;

namespace SwarmArcade.Pages{
    
    public class LeaderBoardModel : PageModel
    {
        private readonly ArcadeDbContext _Db;
        private readonly ILogger<LeaderBoardModel> _logger;

        public List<score> swarmScores { get; set; } = default!;
        public List<score> ClumsyBirdScores { get; set; } = default!;
        public List<score> _2048Scores { get; set; } = default!;

        public string? swarm_score {get;set;}
        public string? ClumsyBird_score {get;set;}
        public string? _2048_score {get;set;}

        public LeaderBoardModel(ArcadeDbContext Db, ILogger<LeaderBoardModel> logger)
        {
            _logger = logger;
            _Db = Db;
        }

        public void OnGet()
        {
            swarmScores = _Db.scores
                .Where(s => s.title == "Swarm")
                .OrderByDescending(s => s.playerScore)
                .ToList();

            foreach(var s in swarmScores){
                swarm_score = swarm_score + s.username + " / " + s.title + " / Score: " + s.playerScore + "<hr>";
            }
            

            ClumsyBirdScores = _Db.scores
                .Where(s => s.title == "Clumsy Bird")
                .OrderByDescending(s => s.playerScore)
                .ToList();

            foreach(var s in ClumsyBirdScores){
                ClumsyBird_score = ClumsyBird_score + s.username + " / " + s.title + " / Score: " + s.playerScore + "<hr>";
            }

            _2048Scores = _Db.scores
                .Where(s => s.title == "2048")
                .OrderByDescending(s => s.playerScore)
                .ToList();

            foreach(var s in _2048Scores){
                _2048_score = _2048_score + s.username + " / " + s.title + " / Score: " + s.playerScore + "<hr>";
            }
        }
    }
}

