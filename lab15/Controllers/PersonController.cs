using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
    }
    [Authorize]
    [HttpGet(Name = "Get2")]
    public IEnumerable<PersonResponse> Get2()
    {
        List<PersonResponse> personas = new List<PersonResponse>();

        for (int i = 0; <= 100; i++)
        {
            PersonResponse persona = new PersonResponse();
            persona.FirstName = "Persona" + i;
            persona.LastName = "Apellido" + i;
            personas.Add(persona);
        }
        return personas;
    
    }
    [Authorize("Administrador")]
    [HttpGet(Name = "Get")]
    public IEnumerable<PersonResponse> Get()
    {
        List<PersonResponse> personas = new List<PersonResponse>();
        for (int i = 0; i < 100; i++)
        {
            PersonResponse persona = new PersonResponse();
            persona.FirstName = "Persona" + i;
            persona.LastName = "Apellido" + i;
            personas.Add(persona);
        }
        return personas;
    }
    [Authorize("Vendedor")]
    [HttpGet(Name = "Get2")]
    public IEnumerable<PersonResponse> Get2()
    {
        List<PersonResponse> personas = new List<PersonResponse>();

        for (int i = 0; i < 100; i++)
        {
            PersonResponse persona = new PersonResponse();
            persona.FirstName = "Persona" + i;
            persona.LastName = "Apellido" + i;
            personas.Add(persona);
        }
        return personas;
    }
}
