public class ExtratoController : Controller
{
    private readonly ApplicationDbContext _context;

    public ExtratoController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(int dias = 5)
    {
        var dataLimite = DateTime.Now.AddDays(-dias);
        var extratos = _context.Extrato
                               .Where(e => e.Data >= dataLimite)
                               .ToList();

        return View(extratos);
    }
    
    public IActionResult GerarPDF()
    {
        var extratos = _context.Extrato.ToList();
        var pdfContent = RenderViewToString("ExtratoPDF", extratos);
        
        var pdf = _pdfService.GeneratePDF(pdfContent);
        return File(pdf, "application/pdf", "extrato.pdf");
    }
}