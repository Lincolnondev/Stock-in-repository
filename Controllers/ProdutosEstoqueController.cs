[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosEstoqueController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Produto>> Get()
        => await _context.Produtos.ToListAsync();

    [HttpPost]
    public async Task<ActionResult> Post(Produto p)
    {
        _context.Produtos.Add(p);
        await _context.SaveChangesAsync();
        return Ok(p);
    }
}
