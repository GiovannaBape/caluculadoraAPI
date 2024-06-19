using Microsoft.AspNetCore.Mvc;
using System;

namespace caluculadoraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Somar")]
        public IActionResult somar(double a, double b)
        {
            return Ok(a + b);
        }

        [HttpGet("Diminuir")]
        public IActionResult diminuir(double a, double b)
        {
            return Ok(a - b);
        }

        [HttpGet("Multiplicar")]
        public IActionResult multiplicar(double a, double b)
        {
            return Ok(a * b);
        }

        [HttpGet("Dividir")]
        public IActionResult dividir(double a, double b)
        {
            return Ok(a / b);
        }

        [HttpGet("Potencia")]
        public IActionResult potencia(double a, double b)
        {
            double resultado = Math.Pow(a, b);
            return Ok(resultado);
        }
        [HttpGet("Raiz Quadrada")]
        public IActionResult raizquadrada(double a)
        {
            if (a < 0)
            {
                return BadRequest("Não é possível calcular a raiz quadrada de um número negativo.");
            }

            double resultado = Math.Sqrt(a);
            return Ok(resultado);
        }
        [HttpGet("Fatorial")]
        public IActionResult fatorial(double a)
        {
            if (a < 0)
            {
                return BadRequest("Não é possível calcular o fatorial de um número negativo.");
            }

            int resultado = 1;
            for (int i = 2; i <= a; i++)
            {
                resultado *= i;
            }

            return Ok(resultado);
        }

        [HttpGet("Exponencial")]
        public IActionResult exponencial(double a, double b)
        {
            double resultado = Math.Pow(a, b);
            return Ok(resultado);
        }

    }
}