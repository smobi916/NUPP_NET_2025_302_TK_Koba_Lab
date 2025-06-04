using Microsoft.AspNetCore.Mvc;
using Warships.REST.Models;
using Warships.BLL.Entities;
using Warships.BLL.Interfaces;
using Warships.BLL.Interfaces;

namespace Warships.REST.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WarshipsController : ControllerBase
{
    private readonly ICrudServiceAsync<Warship> _warshipService;

    public WarshipsController(ICrudServiceAsync<Warship> warshipService)
    {
        _warshipService = warshipService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WarshipModel>>> GetAll()
    {
        var data = await _warshipService.ReadAllAsync();
        return Ok(data.Select(w => new WarshipModel
        {
            Id = w.Id,
            Name = w.Name,
            Type = w.Type,
            YearBuilt = w.YearBuilt
        }));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<WarshipModel>> Get(Guid id)
    {
        var entity = await _warshipService.ReadAsync(id);
        if (entity == null) return NotFound();

        return Ok(new WarshipModel
        {
            Id = entity.Id,
            Name = entity.Name,
            Type = entity.Type,
            YearBuilt = entity.YearBuilt
        });
    }

    [HttpPost]
    public async Task<ActionResult> Create(CreateWarshipModel model)
    {
        var entity = new Warship
        {
            Id = Guid.NewGuid(),
            Name = model.Name,
            Type = model.Type,
            YearBuilt = model.YearBuilt
        };

        await _warshipService.CreateAsync(entity);
        await _warshipService.SaveAsync();

        return CreatedAtAction(nameof(Get), new { id = entity.Id }, model);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult> Update(Guid id, UpdateWarshipModel model)
    {
        var existing = await _warshipService.ReadAsync(id);
        if (existing == null) return NotFound();

        if (model.Name != null) existing.Name = model.Name;
        if (model.YearBuilt.HasValue) existing.YearBuilt = model.YearBuilt.Value;

        var result = await _warshipService.UpdateAsync(existing);
        await _warshipService.SaveAsync();

        return result ? NoContent() : BadRequest();
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        var entity = await _warshipService.ReadAsync(id);
        if (entity == null) return NotFound();

        var result = await _warshipService.RemoveAsync(entity);
        await _warshipService.SaveAsync();

        return result ? NoContent() : BadRequest();
    }
}
