using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSWheels.Dtos;
using TrainingSWheels.Models;
using TrainingSWheels.Services;

namespace TrainingSWheels.Controllers
{
    [ApiController]
    [Route("controller")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request) => Ok(await _fightService.WeaponAttack(request));
        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request) => Ok(await _fightService.SkillAttack(request));
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request) => Ok(await _fightService.Fight(request));
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<HighscoreDto>>> GetHighscore() => Ok(await _fightService.GetHighscore());
    }
}
